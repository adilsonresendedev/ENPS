using System.Collections.Generic;
using ENPS.DTOs.Cidade;
using ENPS.DTOs.Estado;
using ENPS.DTOs.Pais;

namespace ENPS.DTOs.Empresa
{
    public class InserirCAD_empresaDto
    {
        public bool Ativo { get; set; } = true;
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string IE { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public List<CAD_enderecoDTO> CAD_enderecoDtos { get; set; }
        public List<CAD_telefoneDTO> CAD_telefoneDtos { get; set; }
        public List<CAD_redeSocialDTO> CAD_redeSocialDtos { get; set; }
    }
}