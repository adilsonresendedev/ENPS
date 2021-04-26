using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_empresa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string IE { get; set; }
        public List<CAD_endereco> CAD_endereco { get; set; }
        public List<CAD_telefone> CAD_telefone { get; set; }
        public List<CAD_redeSocial> CAD_redeSocial { get; set; }
        public List<CAD_Usuario> CAD_Usuario { get; set; }
        public List<CAD_pessoa> CAD_pessoa { get; set; }
    }
}