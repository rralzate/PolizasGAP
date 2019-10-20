using System.Linq;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using SegurosGAP.Entities;
using System.Collections.Generic;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class PolizasClienteRepository : GenericRepository<DBSegurosGAPEntities, PolizasCliente>, IPolizasCliente
    {
        public List<PolizasCliente> FindpPolicyClient(int idClient)
        {
            var client = FindBy(x => x.IdCliente == idClient).ToList();
            return client;
        }

        public List<PolizasCliente> GetPoliciesClients()
        {
            var result = GetAll().ToList();
            return result;
        }

        public bool UpdatePolicyClient(PolizasCliente client)
        {
            Edit(client);
            Save();
            return true;
        }

        public bool AddPolicyClient(PolizasCliente client)
        {
            Add(client);
            Save();
            return true;
        }
        public bool DeletePolicyClient(PolizasCliente client)
        {
            Delete(client);
            Save();
            return true;
        }
    }
}
