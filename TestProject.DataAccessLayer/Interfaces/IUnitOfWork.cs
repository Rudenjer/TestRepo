using TestProject.DataAccessLayer.Entities;

namespace TestProject.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Owner, int> OwnerRepository { get; }

        IRepository<Pet, int> PetRepository { get; }

        void Save();
    }
}
