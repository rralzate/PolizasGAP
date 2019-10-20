using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using SegurosGAP.Entities;

namespace WebApiGap.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;

        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException(nameof(publicClientId));
            }

            _publicClientId = publicClientId;
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            if (!context.TryGetBasicCredentials(out _, out _))
                context.TryGetFormCredentials(out _, out _);

            // Resource owner password credentials does not provide a client ID.
            if (context.ClientId == null)
            {
                //Remove the comments from the below line context.SetError, and invalidate context 
                //if you want to force sending clientId/secrects once obtain access tokens. 
                context.Validated();
                context.SetError("invalid_clientId", "ClientId should be sent.");
                return Task.FromResult<object>(null);
            }

            Application oAplicaciones = null;
            using (var repo = new AuthRepository())
            {
                oAplicaciones = repo.FindAplicacion(context.ClientId);
            }

            if (oAplicaciones == null)
            {
                context.SetError("invalid_clientId", $"Application '{context.ClientId}' is not registered in the system.");
                return Task.FromResult<object>(null);
            }
            else
            {
                if (!oAplicaciones.Active)
                {
                    context.SetError("inactive_clientId", $"Application '{oAplicaciones.Name}' is inactive in the system.");
                    return Task.FromResult<object>(null);
                }
            }

            context.OwinContext.Set<string>("as:clientAllowedOrigin", oAplicaciones.AllowedOrigin);
            context.OwinContext.Set<string>("as:clientRefreshTokenLifeTime", oAplicaciones.RefreshTokenLifeTime.ToString());

            context.Validated();
            return Task.FromResult<object>(null);
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var allowedOrigin = context.OwinContext.Get<string>("as:clientAllowedOrigin") ?? "*";
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { allowedOrigin });

            Usuario oUser;
            using (var repo = new AuthRepository())
            {
                oUser = repo.FindUser(context.UserName, context.Password);
                if (oUser == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
                else
                {
                    if (!oUser.Estado)
                    {
                        context.SetError("inactive_grant", $"The user '{oUser.Nombre}' is inactive/Locked.");
                        return;
                    }
                    else
                    {
                        oUser.FechaUltimoAcceso = DateTime.Now;
                        repo.UpdateUser(oUser);
                    }
                }
            }

            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            oAuthIdentity.AddClaim(new Claim("Code", (oUser?.IdUsuario ?? 0).ToString()));
  
            var properties = CreateProperties(context.UserName, context.ClientId, oUser?.Nombre);
            var ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
        }

        public static AuthenticationProperties CreateProperties(string userName, string clientId, string name)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "as:client_id", clientId },
                { "userName", userName },
                { "nameUser", name }
            };

            return new AuthenticationProperties(data);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (var property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                var expectedRootUri = new Uri(context.Request.Uri, "/");
                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }
    }
}