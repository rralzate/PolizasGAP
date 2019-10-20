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
            var result = GetAll().FirstOrDefault(x => x.IdPolizaSeguro == idPoliza);

            InfoPolizasSeguro poliza = new InfoPolizasSeguro
            {
                IdPolizaSeguro = result.IdPolizaSeguro,
                Nombre = result.Nombre,
                Descripcion = result.Descripcion,
                InicioVigencia = result.InicioVigencia,
                PeriodoCobertura = result.PeriodoCobertura,
                PrecioPoliza = result.PrecioPoliza,
                TipoRiesgo = result.TiposCubrimiento.TipoCubrimiento,
                TipoCubrimiento = result.TiposRiesgo.TipoRiesgo
            };

            return poliza;           
        }
                
        public List<InfoPolizasSeguro> GetPolizas()
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
                    InicioVigencia = item.InicioVigencia,
                    PeriodoCobertura = item.PeriodoCobertura,
                    PrecioPoliza = item.PrecioPoliza,
                    TipoRiesgo = item.TiposCubrimiento.TipoCubrimiento,
                    TipoCubrimiento = item.TiposRiesgo.TipoRiesgo
                };
                lista.Add(poliza);
            }
            return lista;
        }

        public bool DeletePoliza(PolizasSeguro policy)
        {
            try
            {
                Delete(policy);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditPoliza(PolizasSeguro policy)
        {
            try
            {
                Edit(policy);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddPoliza(PolizasSeguro policy)
        {
            try
            {
                Add(policy);
                Save();
                return true;
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
