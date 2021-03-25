using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Usuario : CAD_pessoa
    {
        public string Senha { get; set; }
        public byte[] SenhaSalt { get; set; }
        public byte[] SenhaHash { get; set; }
    }
}