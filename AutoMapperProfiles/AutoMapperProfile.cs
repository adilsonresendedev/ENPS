using AutoMapper;
using ENPS.DTOs;
using ENPS.Models;

namespace ENPS.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CAD_usuarioDTO, CAD_Usuario>()
            .ForMember(dest => dest.CAD_email, src => src.MapFrom(opt => opt.Email));

            CreateMap<CAD_Usuario, CAD_usuarioDTO>()
            .ForMember(dest => dest.Email, src => src.MapFrom(opt => opt.CAD_email.Email));
        }
    }
}