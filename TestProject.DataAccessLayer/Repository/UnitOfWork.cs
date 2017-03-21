using System;
using TestProject.DataAccessLayer.Context;
using TestProject.DataAccessLayer.Entities;
using TestProject.DataAccessLayer.Interfaces;

namespace TestProject.DataAccessLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FarmDbContext _dbContext;
        private readonly Lazy<Repository<Owner, int>> _ownersRepository;
        private readonly Lazy<Repository<Pet, int>> _petsRepository;

        public UnitOfWork()
        {
            _dbContext = new FarmDbContext();
            _ownersRepository =
                new Lazy<Repository<Owner, int>>(
                    () => new Repository<Owner, int>(new GenericRepository<Owner, int>(_dbContext)));
            _petsRepository =
                new Lazy<Repository<Pet, int>>(
                    () =>new Repository<Pet, int>(new GenericRepository<Pet,int>(_dbContext)));
        }

        public IRepository<Owner, int> OwnerRepository => _ownersRepository.Value;

        public IRepository<Pet, int> PetRepository => _petsRepository.Value;

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
