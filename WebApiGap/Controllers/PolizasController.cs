using SegurosGAP.BusinessRules.GenericBusinessRules;
using System.Collections.Generic;
using System.Web.Http;
using SegurosGAP.Entities;
using System;
using SegurosGAP.Entities.DTO;

namespace WebApiGap.Controllers
{
    //[Authorize]
    public class PolizasController : ApiController
    {

        private readonly PolizasRepository _polizasRepository;

        public PolizasController() { _polizasRepository = new PolizasRepository(); }

        /// <summary>
        /// Service method to obtain one policy
        /// </summary>
        /// <param name="idPoliza"></param>
        /// <returns>InfoPolizasSeguro</returns>
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

        /// <summary>
        /// Service method to obtain all policies
        /// </summary>       
        /// <returns>List<InfoPolizasSeguro></returns>
        [Route("api/v1/Polizas/GetPolicies")]
        [HttpGet]
        public List<InfoPolizasSeguro> GetPolicies()
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

        /// <summary>
        /// Service method to delete one policy
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        [Route("api/v1/Polizas/DeletePolicy")]
        [HttpPost]
        public MessageResponse DeletePolicy([FromBody]PolizasSeguro value)
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

        /// <summary>
        /// Service method to Add one policy
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        [Route("api/v1/Polizas/AddPolicy")]
        [HttpPost]
        public MessageResponse AddPolicy([FromBody]PolizasSeguro value)
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

        /// <summary>
        /// Service method to Edit one policy
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        [Route("api/v1/Polizas/EditPolicy")]
        [HttpPost]
        public MessageResponse EditPolicy([FromBody]PolizasSeguro value)
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
