using AutoMapper;
using ENPS.DTOs;
using ENPS.Models;

namespace ENPS.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CAD_usuarioDTO, CAD_Usuario>().ReverseMap();
        }
    }
}