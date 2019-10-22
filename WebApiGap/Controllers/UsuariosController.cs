using SegurosGAP.BusinessRules.GenericBusinessRules;
using SegurosGAP.Entities;
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
    }
}
