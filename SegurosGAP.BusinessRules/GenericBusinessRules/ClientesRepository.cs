using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegurosGAP.Entities;
using SegurosGAP.Model.Implementation;
using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;

namespace SegurosGAP.BusinessRules.GenericBusinessRules
{
    public class ClientesRepository : GenericRepository<DBSegurosGAPEntities, Cliente>, IClientesRepository
    {
        public Cliente FindClient(int idClient)
        {
            var client = FindBy(x => x.IdCliente == idClient).FirstOrDefault();
            return client;
        }

        public List<Cliente> GetClients()
        {
            var result = GetAll().ToList();
            return result;
        }

        public bool UpdateClient(Cliente client)
        {
            Edit(client);
            Save();
            return true;
        }

        public bool AddClient(Cliente client)
        {
            Add(client);
            Save();
            return true;
        }
        public bool DeleteClient(Cliente client)
        {
            Delete(client);
            Save();
            return true;
        }
    }
}
