using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_redeSocial
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public ERedeSocial ERedeSocial { get; set; }
        public string LinkRedeSocial { get; set; }
    }
}