using SegurosGAP.BusinessRules.GenericBusinessRules;
using System.Collections.Generic;
using System.Web.Http;
using SegurosGAP.Entities;
using System;

namespace WebApiGap.Controllers
{
    //[Authorize]
    public class CubrimientosController : ApiController
    {
        private readonly TiposCubrimientoRepository _tiposCubrimientoRepository;

        public CubrimientosController() { _tiposCubrimientoRepository = new TiposCubrimientoRepository(); }

        /// <summary>
        /// Service method to obtain all cover types
        /// </summary>       
        /// <returns>List<TiposCubrimiento></returns>
        [Route("api/v1/Cubrimientos/GetCoverTypes")]
        [HttpGet]
        public List<TiposCubrimiento> GetCoverTypes()
        {
            try
            {
                var result = _tiposCubrimientoRepository.GetTiposCubrimiento();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
