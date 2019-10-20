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
    public class UsuariosRepository : GenericRepository<DBSegurosGAPEntities, Usuario>, IUsuariosRepository
    {
        public Usuario FindUser(string email, string password)
        {
            var user = FindBy(x =>  x.Email == email && x.Contrasena == password).FirstOrDefault();
            return user;
        }

        public bool UpdateUser(Usuario user)
        {
            Edit(user);
            Save();
            return true;
        }

        public bool AddUser(Usuario user)
        {
            Add(user);
            Save();
            return true;
        }
        public bool DeleteUser(Usuario user)
        {
            Delete(user);
            Save();
            return true;
        }
    }
}
