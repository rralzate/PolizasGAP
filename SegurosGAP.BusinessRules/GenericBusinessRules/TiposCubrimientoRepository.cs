using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;


namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    class TiposCubrimientoRepository : GenericRepository<DBSegurosGAPEntities, TiposCubrimiento>, ITiposCubrimientoRepository
    {
        public TiposCubrimiento GetSingle(int idTipoCubrimiento)
        {
            var query = GetAll().FirstOrDefault(x => x.IdTipoCubrimiento == idTipoCubrimiento);
            return query;
        }
    }
}
