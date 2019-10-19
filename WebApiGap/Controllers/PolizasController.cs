using SegurosGAP.BusinessRules.GenericBusinessRules;
using SegurosGAP.Model.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SegurosGAP.Entities;
using Newtonsoft.Json;
using System;

namespace WebApiGap.Controllers
{
    public class PolizasController : ApiController
    {

        private readonly PolizasRepository _polizasRepository;

        public PolizasController() { _polizasRepository = new PolizasRepository(); }
        
        public PolizasSeguro GetSigle(int idPoliza)
        {
            try
            {                
                var result = _polizasRepository.GetSingle(idPoliza);
                PolizasSeguro poliza = new PolizasSeguro {
                    IdPolizaSeguro = result.IdPolizaSeguro,
                    Nombre = result.Nombre,
                    Descripcion = result.Descripcion,
                    InicioVigencia = result.InicioVigencia,
                    PeriodoCobertura = result.PeriodoCobertura,
                    PrecioPoliza = result.PrecioPoliza,
                    IdTipoRiesgo = result.IdTipoRiesgo,
                    IdTipoCubrimiento = result.IdTipoCubrimiento
                };

                return poliza;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
