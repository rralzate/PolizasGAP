using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;
using System.Collections.Generic;
using SegurosGAP.Entities.DTO;
using System;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class PolizasRepository : GenericRepository<DBSegurosGAPEntities, PolizasSeguro>, IPolizasRepository
    {
        public InfoPolizasSeguro GetPoliza(int idPoliza)
        {
            try
            {
                var result = GetAll().FirstOrDefault(x => x.IdPolizaSeguro == idPoliza);
                
                InfoPolizasSeguro poliza = new InfoPolizasSeguro
                {
                    IdPolizaSeguro = result.IdPolizaSeguro,
                    Nombre = result.Nombre,
                    Descripcion = result.Descripcion,
                    InicioVigencia = result.InicioVigencia.Value.ToString("MM/dd/yyyy"),
                    PeriodoCobertura = result.PeriodoCobertura,
                    PrecioPoliza = result.PrecioPoliza,
                    TipoCubrimiento = result.TiposCubrimiento.TipoCubrimiento,
                    TipoRiesgo = result.TiposRiesgo.TipoRiesgo,
                    IdTipoCubrimiento = result.TiposCubrimiento.IdTipoCubrimiento,
                    IdTipoRiesgo = result.TiposRiesgo.IdTipoRiesgo,
                };

                return poliza;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
                
        public List<InfoPolizasSeguro> GetPolizas()
        {
            try
            {
                var result = GetAll().ToList();
                List<InfoPolizasSeguro> lista = new List<InfoPolizasSeguro>();

                foreach (var item in result)
                {
                    InfoPolizasSeguro poliza = new InfoPolizasSeguro
                    {
                        IdPolizaSeguro = item.IdPolizaSeguro,
                        Nombre = item.Nombre,
                        Descripcion = item.Descripcion,
                        InicioVigencia = item.InicioVigencia.Value.ToString("MM/dd/yyyy"),
                        PeriodoCobertura = item.PeriodoCobertura,
                        PrecioPoliza = item.PrecioPoliza,
                        TipoCubrimiento = item.TiposCubrimiento.TipoCubrimiento,
                        TipoRiesgo = item.TiposRiesgo.TipoRiesgo,
                        IdTipoCubrimiento = item.TiposCubrimiento.IdTipoCubrimiento,
                        IdTipoRiesgo = item.TiposRiesgo.IdTipoRiesgo,
                    };
                    lista.Add(poliza);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MessageResponse DeletePoliza(PolizasSeguro policy)
        {
            try
            {
                MessageResponse response = new MessageResponse();
                Delete(policy);
                Save();
                response.Code = 1;
                response.Message = "Success";
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MessageResponse EditPoliza(PolizasSeguro policy)
        {
            try
            {
                MessageResponse response = new MessageResponse();
                Edit(policy);
                Save();
                response.Code = 1;
                response.Message = "Success";
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MessageResponse AddPoliza(PolizasSeguro policy)
        {
            try
            {
                MessageResponse response = new MessageResponse();
                Add(policy);
                Save();
                response.Code = 1;
                response.Message = "Success";
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PolizasSeguro GetSingle(int idPoliza)
        {
            throw new System.NotImplementedException();
        }
    }
}
