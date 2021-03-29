using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_empresa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public CAD_CNPJ CAD_CNPJ { get; set; }
        public CAD_email CAD_email { get; set; }
        public string IE { get; set; }
        public List<CAD_endereco> CAD_enderedo { get; set; }
        public List<CAD_Telefone> CAD_telefone { get; set; }
        public List<CAD_redeSocial> CAD_redeSocial { get; set; }
        public COF_Estado COF_estado { get; set; }
        public COF_Cidade COF_cidade { get; set; }
        public CAD_Usuario CAD_Usuario { get; set; }
    }
}