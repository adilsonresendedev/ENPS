
namespace ENPS.Models
{
    public class CAD_Usuario
    {
        public int Id {get;set;}
        public string Senha { get; set; }
        public byte[] SenhaSalt { get; set; }
        public byte[] SenhaHash { get; set; }
        public CAD_pessoa CAD_pessoa { get; set; }
    }
}