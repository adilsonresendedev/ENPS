using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_Usuario
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Senha { get; set; }
        public CAD_Pessoa cAD_PessoaDTO { get; set; }
        public List<CAD_Empresa> cAD_EmpresaDTOs { get; set; }
    }
}