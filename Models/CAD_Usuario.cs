using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Usuario
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Senha { get; set; }
        public byte[] SenhaSalt { get; set; }
        public byte[] SenhaHash { get; set; }
        public CAD_Pessoa CAD_Pessoa { get; set; }
        public List<CAD_Empresa> CAD_Empresa { get; set; }
        public CAD_email CAD_email { get; set; }
    }
}