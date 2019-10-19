using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;


namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class TiposRiesgoRepository : GenericRepository<DBSegurosGAPEntities, TiposRiesgo>, ITiposRiesgoRepository
    {
        public TiposRiesgo GetSinlge(int idTipoRiesgo)
        {
            var query = GetAll().FirstOrDefault(x => x.IdTipoRiesgo == idTipoRiesgo);
            return query;
        }
    }
}
