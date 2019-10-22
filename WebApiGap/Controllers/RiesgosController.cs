using SegurosGAP.BusinessRules.GenericBusinessRules;
using System.Collections.Generic;
using System.Web.Http;
using SegurosGAP.Entities;
using System;

namespace WebApiGap.Controllers
{
   // [Authorize]
    public class RiesgosController : ApiController
    {
        private readonly TiposRiesgoRepository _tiposRiesgoRepository;

        public RiesgosController() { _tiposRiesgoRepository = new TiposRiesgoRepository(); }

        /// <summary>
        /// Service method to obtain all Risk Types
        /// </summary>       
        /// <returns>List<TiposRiesgo></returns>
        [Route("api/v1/Riesgos/GetRiskTypes")]
        [HttpGet]
        public List<TiposRiesgo> GetRiskTypes()
        {
            try
            {
                var result = _tiposRiesgoRepository.GetTiposRiesgo();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
