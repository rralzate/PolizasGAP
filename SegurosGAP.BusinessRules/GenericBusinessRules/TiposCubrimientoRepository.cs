using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;
using System.Collections.Generic;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class TiposCubrimientoRepository : GenericRepository<DBSegurosGAPEntities, TiposCubrimiento>, ITiposCubrimientoRepository
    {
        public TiposCubrimiento GetSingle(int idTipoCubrimiento)
        {
            var query = GetAll().FirstOrDefault(x => x.IdTipoCubrimiento == idTipoCubrimiento);
            return query;
        }

        public List<TiposCubrimiento> GetTiposCubrimiento()
        {
            var result = GetAll().ToList();
            return result;
        }
    }
}
