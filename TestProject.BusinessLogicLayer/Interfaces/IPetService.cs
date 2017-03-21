using System.Collections.Generic;
using TestProject.BusinessLogicLayer.DTO;

namespace TestProject.BusinessLogicLayer.Interfaces
{
    public interface IPetService
    {
        IEnumerable<PetDTO> GetAllPets();

        void AddPet(PetDTO owner);

        PetDTO GetPetById(int id);

        void DeletePet(int id);
    }
}
