using AbstractModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Models
{
    public class DbRespository<T> : IRepository<T> where T : class
    {
        public DbContext Context { get; set; }
        public DbRespository(){}
        public DbRespository(DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            var dbSet = Context.Set<T>();

            if (dbSet == null) return;

            dbSet.Add(entity);

            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var dbSet = Context.Set<T>();

            if (dbSet == null) return;

            dbSet.Remove(entity);

            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            var dbSet = Context.Set<T>();

            if (dbSet == null) return;

            dbSet.Add(entity);

            Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            var dbSet = Context.Set<T>();

            if (dbSet == null) return null;

            return dbSet.ToList();
        }
    }
}
