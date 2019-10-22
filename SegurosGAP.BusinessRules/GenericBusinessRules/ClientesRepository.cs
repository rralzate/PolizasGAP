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
            try { 
                var client = FindBy(x => x.IdCliente == idClient).FirstOrDefault();
                return client;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> GetClients()
        {
            try { 
                var result = GetAll().ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateClient(Cliente client)
        {
            try { 
                Edit(client);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddClient(Cliente client)
        {
            try
            { 
                Add(client);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteClient(Cliente client)
        {
            try { 
                Delete(client);
                Save();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
