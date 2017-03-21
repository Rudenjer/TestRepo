using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TestProject.DataAccessLayer.Interfaces;

namespace TestProject.DataAccessLayer.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
    {
        private readonly IRepository<TEntity, TKey> _entityRepository;

        public Repository(IRepository<TEntity, TKey> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public TEntity Get(TKey id)
        {
            return _entityRepository.Get(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return _entityRepository.Get(filter);
        }

        public IEnumerable<TResult> Select<TResult>(Func<TEntity, TResult> selector)
        {
            return _entityRepository.Select(selector);
        }

        public void Create(TEntity item)
        {
            _entityRepository.Create(item);
        }

        public void Update(TEntity item)
        {
            _entityRepository.Update(item);
        }

        public void Delete(TEntity item)
        {
            _entityRepository.Delete(item);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return _entityRepository.FirstOrDefault(expression);
        }

        public TEntity First(Expression<Func<TEntity, bool>> expression)
        {
            return _entityRepository.First(expression);
        }
    }
}
