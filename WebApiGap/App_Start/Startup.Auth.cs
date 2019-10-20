namespace WebApiGap
{
    using System;
    using Common;
    using Microsoft.Owin;
    using Microsoft.Owin.Security.OAuth;
    using SegurosGAP.Entities;
    using Owin;
    using Providers;
    using SegurosGAP.BusinessRules.GenericBusinessRules;

    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthServerOptions { get; private set; }
        private readonly ParametrosRepository _parametrosRepository = new ParametrosRepository();

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {            
            Parametro oParameterExpire = null;
            try
            { oParameterExpire = _parametrosRepository.FindParemeter((int)Enumerations.eParameter.AccessTokenExpire); }
            catch (Exception) { }

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthServerOptions = new OAuthAuthorizationServerOptions
            {
                // In production mode set AllowInsecureHttp = false
                AllowInsecureHttp = true,

                TokenEndpointPath = new PathString("/" + SGRepositoryGeneric.StaticValues.GetDefaultUriWebApi(StaticValues.VersionWebApi) + "Token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(_parametrosRepository.getValueParameter(oParameterExpire, SGRepositoryGeneric.StaticValues.DefaultExpiracionDeToken)),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                RefreshTokenProvider = new ApplicationRefreshTokenProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}