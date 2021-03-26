using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_email
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public bool Princial { get; set; }
        public string Email { get; set; }
        public List<CAD_empresa> CAD_empresa { get; set; }
        public List<CAD_pessoa> CAD_pessoa { get; set; }
    }
}