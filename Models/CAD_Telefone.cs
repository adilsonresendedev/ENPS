using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_telefone
    {
        public long Id { get; set; }
        public bool Ativo { get; set; } = true;
        public bool Princial { get; set; }
        public int CodigoPais { get; set; }
        public int CodigoEstado { get; set; }
        public int Numero { get; set; }
        public List<CAD_empresa> CAD_empresa { get; set; }
        public List<CAD_pessoa> CAD_pessoa { get; set; }
    }
}