using AutoMapper;
using PlatformUserApi.Dtos;
using PlatformUserApi.Models;

namespace PlatformUserApi.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper() 
        {
            CreateMap<User, UserDto>();
        }
    }
}
