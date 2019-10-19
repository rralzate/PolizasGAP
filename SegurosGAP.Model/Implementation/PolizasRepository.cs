using SegurosGAP.Model.Interfaces;
using SegurosGAP.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SegurosGAP.Entities;

namespace SegurosGAP.Model.Implementation
{
    /// <summary>
    /// Class to implement de the CRUD policy administration
    /// </summary>
    public class PolizasRepository : IPolizasRepository
    {
        private readonly DBSegurosGAPEntities context = new DBSegurosGAPEntities();
        public void Add(PolizasSeguro entity)
        {
            context.PolizasSeguros.Add(entity);
        }

        public void Delete(PolizasSeguro entity)
        {
            context.PolizasSeguros.Remove(entity);
        }

        public void Edit(PolizasSeguro entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<PolizasSeguro> FindBy(Expression<Func<PolizasSeguro, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PolizasSeguro> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<PolizasSeguro> GetPolizasSeguros()
        {
            IQueryable<PolizasSeguro> query = context.PolizasSeguros;
            return query;
        }

        public PolizasSeguro GetSingle(int idPoliza)
        {
            var query = this.GetPolizasSeguros().FirstOrDefault(x => x.IdPolizaSeguro == idPoliza);
            return query;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
