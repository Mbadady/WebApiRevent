using AutoMapper;
using WebApplication3.Data;
using WebApplication3.DTO;

namespace WebApplication3.Mapper
{
    public class MappingConfig : Profile
    {

        public MappingConfig()
        {
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<User, AddUserDTO>().ReverseMap();

        }
    }
}
