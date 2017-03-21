using System.Collections.Generic;
using System.Web.Http;
using TestProject.BusinessLogicLayer.DTO;
using TestProject.BusinessLogicLayer.Interfaces;

namespace TestProject.WebService.Controllers
{
    public class OwnerController : ApiController
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/Ownerrrtytyyty
        public IEnumerable<OwnerDTO> Get()
        {
            return _ownerService.GetAllOwners();
        }

        // GET: api/Owner/5
        public OwnerDTO Get(int id)
        {
            return _ownerService.GetOwnerById(id);
        }

        // POST: api/Owner
        public void Post([FromBody]OwnerDTO owner)
        {
            _ownerService.AddOwner(owner);
        }

        // DELETE: api/Owner/5
        public void Delete(int id)
        {
            _ownerService.DeleteOwner(id);
        }
    }
}
