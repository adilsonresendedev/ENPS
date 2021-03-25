using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Empresa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public CAD_Usuario cAD_Usuario { get; set; }
        public CAD_CNPJ cAD_CNPJ { get; set; }
        public List<CAD_email> cAD_email { get; set; }
        public string IE { get; set; }
        public List<CAD_Endereco> enderedo { get; set; }
        public List<CAD_Telefone> telefone { get; set; }
        public COF_Estado estado { get; set; }
        public COF_Cidade cidade { get; set; }
    }
}