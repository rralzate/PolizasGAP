using SegurosGAP.BusinessRules.GenericBusinessRules;
using System.Collections.Generic;
using System.Web.Http;
using SegurosGAP.Entities;
using System;

namespace WebApiGap.Controllers
{
    [Authorize]
    public class ClientesController : ApiController
    {
        private readonly ClientesRepository _clientesRepository;

        public ClientesController() { _clientesRepository = new ClientesRepository(); }

        /// <summary>
        /// Service method to obtain one client
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns>Cliente</returns>
        [Route("api/v1/Clientes/GetClient")]
        [HttpGet]
        public Cliente GetClient(int idClient)
        {
            try
            {
                var result = _clientesRepository.FindClient(idClient);
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
        /// <returns>List<Cliente></returns>
        [Route("api/v1/Clientes/GetClients")]
        [HttpGet]
        public List<Cliente> GetClients()
        {
            try
            {
                var result = _clientesRepository.GetClients();
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
        [Route("api/v1/Clientes/DeleteClient")]
        [HttpPost]
        public bool DeleteClient([FromBody]Cliente value)
        {
            try
            {
                var result = _clientesRepository.DeleteClient(value);
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
        [Route("api/v1/Clientes/AddClient")]
        [HttpPost]
        public bool AddClient([FromBody]Cliente value)
        {
            try
            {
                var result = _clientesRepository.AddClient(value);
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
        [Route("api/v1/Clientes/UpdateClient")]
        [HttpPost]
        public bool UpdateClient([FromBody]Cliente value)
        {
            try
            {
                var result = _clientesRepository.UpdateClient(value);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
