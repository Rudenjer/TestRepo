using AutoMapper;
using TestProject.BusinessLogicLayer.DTO;
using TestProject.DataAccessLayer.Entities;

namespace TestProject.BusinessLogicLayer.Mappers
{
    public class PetMapper : Profile
    {
        protected override void Configure()
        {
            CreateMap<PetDTO, Pet>();
            CreateMap<Pet, PetDTO>();
        }
    }
}
