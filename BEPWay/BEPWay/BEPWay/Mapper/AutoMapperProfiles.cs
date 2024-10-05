using AutoMapper;
using BEPWay.Models.Domain;
using BEPWay.Models.DTO;

namespace BEPWay.Mapper
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<UserDTO,User>().ReverseMap();
        }
    }
}
