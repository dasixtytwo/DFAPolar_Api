using AutoMapper;
using DFAPolar.API.Dtos;
using DFAPolar.Domain.Models;

namespace DFAPolar.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            // Domain to Resource
            CreateMap<UserModel, UserResultDto>().ReverseMap();

            //Resource to Domain
            CreateMap<UserResultDto, UserModel>().ReverseMap();
        }   
    }
}
