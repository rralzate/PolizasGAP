using SegurosGAP.Entities;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class ApplicationRepository : GenericRepository<DBSegurosGAPEntities, Application>, IApplicationRepository
    {
        public Application FindAplicacion(string clientId)
        {
            var result = GetAll().FirstOrDefault(x => x.CodeApplication == clientId);

            return result;
        }
    }
}
