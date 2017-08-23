using System.Collections.Generic;

namespace HadwareInventorySystem.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);



    }
}