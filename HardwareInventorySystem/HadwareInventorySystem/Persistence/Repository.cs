using HadwareInventorySystem.Core;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HadwareInventorySystem.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext dbContext)
        {
            Context = dbContext;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

       


    }
}