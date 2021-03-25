using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_Pessoa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public CAD_Endereco CAD_Endereco { get; set; }
        public List<CAD_Telefone> CAD_Telefone { get; set; }
        public List<CAD_RedeSocial> CAD_RedeSocial { get; set; }
        public ETipoPessoa ETipoPessoa { get; set; }
        public CAD_CNPJ CAD_CNPJ { get; set; }
        public CAD_CPF CAD_CPF { get; set; }
    }
}