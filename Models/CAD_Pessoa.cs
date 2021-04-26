using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_pessoa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<CAD_endereco> CAD_Endereco { get; set; }
        public List<CAD_redeSocial> CAD_RedeSocial { get; set; }
        public List<CAD_Telefone> CAD_Telefone { get; set; }
        public List<CAD_empresa> CAD_empresa {get;set;}
        public string CPF { get; set; }
        public List<NPS_votacao> NPS_votacao { get; set; }
    }
}