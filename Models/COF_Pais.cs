using System.Collections.Generic;

namespace ENPS.Models
{
    public class COF_pais
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public List<COF_estado> COF_estado { get; set; }
    }
}