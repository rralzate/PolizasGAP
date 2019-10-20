namespace SegurosGAP.Model.Implementation
{
    using SegurosGAP.Model.Interfaces;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    public abstract class GenericRepository<C, T> : IGenericRepository<T> where T : class where C : DbContext, new()
    {
        private C _entities = new C();

        public C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual void Add(T entity)
        {
            _entities.Entry(entity).State = EntityState.Added;
        }

        public virtual void Delete(T entity)
        {
            _entities.Entry(entity).State = EntityState.Deleted;
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual  IQueryable<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
