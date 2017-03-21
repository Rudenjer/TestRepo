using System.Collections.Generic;

namespace TestProject.BusinessLogicLayer.DTO
{
    public class OwnerDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public ICollection<PetDTO> Pets { get; set; } = new List<PetDTO>();
    }
}
