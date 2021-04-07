using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_pessoa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public CAD_email CAD_email { get; set; }
        public List<CAD_endereco> CAD_Endereco { get; set; }
        public List<CAD_redeSocial> CAD_RedeSocial { get; set; }
        public List<CAD_Telefone> CAD_Telefone { get; set; }
        public CAD_CPF CAD_CPF { get; set; }
        public List<NPS_votacao> NPS_votacao { get; set; }
    }
}