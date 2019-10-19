using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class PolizasRepository : GenericRepository<DBSegurosGAPEntities, PolizasSeguro>, IPolizasRepository
    {
        public PolizasSeguro GetSingle(int idPoliza)
        {
            var query = GetAll().FirstOrDefault(x => x.IdPolizaSeguro == idPoliza);
            return query;           
        }
    }
}
