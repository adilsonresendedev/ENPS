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
        public string CPF { get; set; }
        public List<CAD_endereco> CAD_endereco { get; set; }
        public List<CAD_redeSocial> CAD_redeSocial { get; set; }
        public List<CAD_telefone> CAD_telefone { get; set; }
        public List<NPS_votacao> NPS_votacao { get; set; }
    }
}