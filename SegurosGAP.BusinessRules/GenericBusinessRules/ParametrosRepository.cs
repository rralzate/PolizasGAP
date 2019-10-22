using SegurosGAP.Entities;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using SGRepositoryGeneric;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class ParametrosRepository : GenericRepository<DBSegurosGAPEntities, Parametro>, IParametrosRepository
    {
        public Parametro FindParemeter(int id)
        {
            try { 
                var parameter = FindBy(x => x.Id == id).FirstOrDefault();
                return parameter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int getValueParameter(Parametro oParameter, int defaultValue, bool bMayor = true)
        {
            try
            { 
            return oParameter?.Valor.GetValue<string, int>(defaultValue, bMayor) ?? defaultValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
