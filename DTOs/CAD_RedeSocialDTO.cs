using ENPS.Enumeradores;

namespace ENPS.DTOs
{
    public class CAD_RedeSocialDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public ERedeSocial eRedeSocial { get; set; }

        public string LinkRedeSocial { get; set; }

    }
}