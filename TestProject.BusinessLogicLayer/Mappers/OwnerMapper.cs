using AutoMapper;
using TestProject.BusinessLogicLayer.DTO;
using TestProject.DataAccessLayer.Entities;

namespace TestProject.BusinessLogicLayer.Mappers
{
    public class OwnerMapper: Profile
    {
        protected override void Configure()
        {
            CreateMap<OwnerDTO, Owner>();
            CreateMap<Owner, OwnerDTO>();
        }
    }
}