using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_RedeSocial
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public ERedeSocial eRedeSocial { get; set; }

        public string LinkRedeSocial { get; set; }

    }
}