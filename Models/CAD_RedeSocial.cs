using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_redeSocial
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public ERedeSocial ERedeSocial { get; set; }
        public string LinkRedeSocial { get; set; }
        public List<CAD_pessoa> CAD_Pessoa { get; set; }
        public List<CAD_empresa> CAD_empresa { get; set; }
    }
}