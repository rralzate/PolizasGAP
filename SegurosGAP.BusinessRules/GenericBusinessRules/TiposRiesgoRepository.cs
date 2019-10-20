using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;
using System.Collections.Generic;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class TiposRiesgoRepository : GenericRepository<DBSegurosGAPEntities, TiposRiesgo>, ITiposRiesgoRepository
    {
        public TiposRiesgo GetSinlge(int idTipoRiesgo)
        {
            var query = GetAll().FirstOrDefault(x => x.IdTipoRiesgo == idTipoRiesgo);
            return query;
        }

        public List<TiposRiesgo> GetTiposRiesgo()
        {
            var result = GetAll().ToList();    
            return result;
        }
    }
}
