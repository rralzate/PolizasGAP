using SegurosGAP.BusinessRules.GenericBusinessRules;
using System.Collections.Generic;
using System.Web.Http;
using SegurosGAP.Entities;
using System;
using SegurosGAP.Entities.DTO;

namespace WebApiGap.Controllers
{
    //[Authorize]
    public class PolizasClienteController : ApiController
    {
        private readonly PolizasClienteRepository _polizasClienteRepository;

        public PolizasClienteController() { _polizasClienteRepository = new PolizasClienteRepository(); }

        /// <summary>
        /// Service method to obtain one client policies
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns>Cliente</returns>
        [Route("api/v1/PolizasCliente/GetPolicyClient")]
        [HttpGet]
        public List<PolizasCliente> GetPolicyClient(int idClient)
        {
            try
            {
                var result = _polizasClienteRepository.FindpPolicyClient(idClient);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Service method to obtain all clients
        /// </summary>       
        /// <returns>List<PolizasCliente></returns>
        [Route("api/v1/PolizasCliente/GetPoliciesClients")]
        [HttpGet]
        public List<PolizasCliente> GetPoliciesClients()
        {
            try
            {
                var result = _polizasClienteRepository.GetPoliciesClients();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Service method to delete one Client
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        [Route("api/v1/PolizasCliente/DeleteClient")]
        [HttpPost]
        public bool DeletePolicyClient([FromBody]PolizasCliente value)
        {
            try
            {
                var result = _polizasClienteRepository.DeletePolicyClient(value);
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
        [Route("api/v1/PolizasCliente/AddPolicyClient")]
        [HttpPost]
        public MessageResponse AddPolicyClient([FromBody]PolizasCliente value)
        {
            try
            {
                var result = _polizasClienteRepository.AddPolicyClient(value);              
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Service method to Edit one Client
        /// </summary>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        [Route("api/v1/PolizasCliente/UpdateClient")]
        [HttpPost]
        public MessageResponse UpdatePolicyClient([FromBody]PolizasCliente value)
        {
            try
            {
                var result = _polizasClienteRepository.UpdatePolicyClient(value);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
