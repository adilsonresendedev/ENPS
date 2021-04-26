using AutoMapper;
using ENPS.DTOs;
using ENPS.DTOs.Empresa;
using ENPS.Models;

namespace ENPS.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CAD_usuarioInserirDTO, CAD_Usuario>().ReverseMap();
            CreateMap<InserirCAD_empresaDto, CAD_empresa>();
            CreateMap<CAD_enderecoDTO, CAD_endereco>();
            CreateMap<CAD_redeSocialDTO, CAD_redeSocial>();
            CreateMap<CAD_telefoneDTO, CAD_telefone>();
        }
    }
}