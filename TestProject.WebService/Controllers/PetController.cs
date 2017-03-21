using System.Collections.Generic;
using System.Web.Http;
using TestProject.BusinessLogicLayer.DTO;
using TestProject.BusinessLogicLayer.Interfaces;

namespace TestProject.WebService.Controllers
{
    public class PetController : ApiController
    {
        private readonly IPetService _petService;

        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        // GET: api/Owner
        public IEnumerable<PetDTO> Get()
        {
            return _petService.GetAllPets();
        }

        // GET: api/Owner/5
        public PetDTO Get(int id)
        {
            return _petService.GetPetById(id);
        }

        // POST: api/Owner
        public void Post([FromBody]PetDTO pet)
        {
            _petService.AddPet(pet);
        }

        // DELETE: api/Owner/5
        public void Delete(int id)
        {
            _petService.DeletePet(id);
        }
    }
}
