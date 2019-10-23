using SegurosGAP.BusinessRules.GenericBusinessRules;
using SegurosGAP.Entities;
using SegurosGAP.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiGap.Controllers
{
    //[Authorize]
    public class UsuariosController : ApiController
    {
        private readonly UsuariosRepository _usuariosRepository;

        public UsuariosController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        [Route("api/v1/Usuarios/GetUser")]
        [HttpPost]
        public Usuario GetUser([FromBody]Usuario value)
        {
            try
            {
                var result = _usuariosRepository.FindUser(value.Email, value.Contrasena);
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
        [Route("api/v1/Usuarios/AddUser")]
        [HttpPost]
        public MessageResponse AddUser([FromBody]Usuario value)
        {
            try
            {
                var result = _usuariosRepository.AddUser(value);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
