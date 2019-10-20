using System;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;
using SGRepositoryGeneric;

namespace WebApiGap.Providers
{
    public class BaseController : ApiController
    {
        private string GetClaims(string claimType)
        {
            var sRetorno = string.Empty;
            var oClaims = ((ClaimsIdentity)User.Identity).Claims;
            if (oClaims.IsNotNull())
                sRetorno = oClaims.FirstOrDefault(x => x.Type == claimType)?.Value ?? string.Empty;

            return sRetorno;
        }

        protected int GetCodeUser => Convert.ToInt32(GetClaims("Code"));

        protected int GetCodeRol => Convert.ToInt32(GetClaims("CodeRol"));

        protected int GetUserName => Convert.ToInt32(GetClaims(ClaimTypes.Name));

        protected ReturnWebApi ReturnMesagge(bool bCondition, Common.Enumerations.eCustomerMessages eSuccess, Common.Enumerations.eCustomerMessages eWarning)
        {
            if (bCondition)
                return new ReturnWebApi(eSuccess, Enumerations.eResponse.Success);
            else
                return new ReturnWebApi(eWarning, Enumerations.eResponse.Warning);
        }
    }
}
