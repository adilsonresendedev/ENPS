
using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Usuario
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public byte[] SenhaSalt { get; set; }
        public byte[] SenhaHash { get; set; }
        public CAD_pessoa CAD_pessoa { get; set; }
        public List<CAD_empresa> CAD_empresa { get; set; }
    }
}