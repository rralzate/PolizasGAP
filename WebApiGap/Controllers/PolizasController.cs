using SegurosGAP.BusinessRules.GenericBusinessRules;
using System.Collections.Generic;
using System.Web.Http;
using SegurosGAP.Entities;
using System;
using SegurosGAP.Entities.DTO;

namespace WebApiGap.Controllers
{
    public class PolizasController : ApiController
    {

        private readonly PolizasRepository _polizasRepository;

        public PolizasController() { _polizasRepository = new PolizasRepository(); }

        [Route("api/v1/Polizas/GetSingle")]
        [HttpGet]
        public InfoPolizasSeguro GetSingle(int idPoliza)
        {
            try
            {                
                var result = _polizasRepository.GetPoliza(idPoliza);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Route("api/v1/Polizas/GetPolizas")]
        [HttpGet]
        public List<InfoPolizasSeguro> GetPolizas()
        {
            try
            {               
                var result = _polizasRepository.GetPolizas();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Route("api/v1/Polizas/DeletePoliza")]
        [HttpPost]
        public bool DeletePoliza([FromBody]PolizasSeguro value)
        {
            try
            {                
                var result = _polizasRepository.DeletePoliza(value);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("api/v1/Polizas/AddPoliza")]
        [HttpPost]
        public bool AddPoliza([FromBody]PolizasSeguro value)
        {
            try
            {
                var result = _polizasRepository.AddPoliza(value);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("api/v1/Polizas/EditPoliza")]
        [HttpPost]
        public bool EditPoliza([FromBody]PolizasSeguro value)
        {
            try
            {
                var result = _polizasRepository.EditPoliza(value);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
