using System.Collections.Generic;

namespace ENPS.DTOs
{
    public class CAD_empresaDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string IE { get; set; }
        public List<CAD_enderecoDTO> CAD_enderecoDTO { get; set; }
        public List<CAD_telefoneDTO> CAD_telefoneDTO { get; set; }
        public List<CAD_redeSocialDTO> CAD_redeSocialDTO { get; set; }
        public CAD_usuarioInserirDTO CAD_usuarioDTO { get; set; }
    }
}