using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Empresa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public CAD_Usuario cAD_UsuarioDTO { get; set; }
        public CAD_CNPJ cAD_CNPJDTO { get; set; }
        public List<CAD_email> cAD_emailDTO { get; set; }
        public string IE { get; set; }
        public List<CAD_Endereco> enderedoDTO { get; set; }
        public List<CAD_Telefone> telefoneDTO { get; set; }
        public COF_Estado estadoDTO { get; set; }
        public COF_Cidade cidadeDTO { get; set; }
    }
}