using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestProject.DataAccessLayer.Interfaces
{
    public interface IRepository<TEntity, in TKey>
    {
        TEntity Get(TKey id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null);

        IEnumerable<TResult> Select<TResult>(Func<TEntity, TResult> selector);

        void Create(TEntity item);

        void Update(TEntity item);

        void Delete(TEntity item);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression);

        TEntity First(Expression<Func<TEntity, bool>> expression);
    }
}
