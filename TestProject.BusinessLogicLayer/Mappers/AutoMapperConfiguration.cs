using AutoMapper;

namespace TestProject.BusinessLogicLayer.Mappers
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<OwnerMapper>();
                x.AddProfile<PetMapper>();
            });
        }
    }
}
