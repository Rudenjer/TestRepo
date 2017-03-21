using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TestProject.DataAccessLayer.Interfaces;

namespace TestProject.DataAccessLayer.Repository
{
    public class GenericRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }

        public virtual TEntity Get(TKey id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TResult> Select<TResult>(Func<TEntity, TResult> selector)
        {
            return _dbContext.Set<TEntity>().Select(selector).ToList();
        }

        public virtual void Create(TEntity item)
        {
            _dbContext.Set<TEntity>().Add(item);
        }

        public virtual void Update(TEntity item)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity item)
        {
            _dbContext.Set<TEntity>().Remove(item);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(expression);
        }

        public TEntity First(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().First(expression);
        }
    }
}