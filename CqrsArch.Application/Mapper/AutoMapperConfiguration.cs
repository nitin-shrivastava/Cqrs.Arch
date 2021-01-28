using AutoMapper;

namespace CqrsArch.Application.Mapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UniversityProfiles());
            });
        }
    }
}
