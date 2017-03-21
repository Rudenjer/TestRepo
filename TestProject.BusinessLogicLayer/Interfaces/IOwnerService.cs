using System.Collections.Generic;
using TestProject.BusinessLogicLayer.DTO;

namespace TestProject.BusinessLogicLayer.Interfaces
{
    public interface IOwnerService
    {
        IEnumerable<OwnerDTO> GetAllOwners();

        void AddOwner(OwnerDTO owner);

        OwnerDTO GetOwnerById(int id);

        void DeleteOwner(int id);
    }
}
