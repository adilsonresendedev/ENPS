using System.Collections.Generic;

namespace ENPS.DTOs.Empresa
{
    public class AlterarCAD_empresaDto
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string IE { get; set; }
        public string CAD_CNPJ { get; set; }
        public string Email { get; set; }
        public List<CAD_enderecoDTO> CAD_enderecoDtos { get; set; }
        public List<CAD_telefoneDTO> CAD_telefoneDtos { get; set; }
        public List<CAD_redeSocialDTO> CAD_redeSocialDtos { get; set; }
    }
}