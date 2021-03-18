using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.Models
{
    public class CAD_Pessoa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public CAD_Endereco cAD_EnderecoDTO { get; set; }
        public List<CAD_Telefone> cAD_TelefoneDTO { get; set; }
        public List<CAD_RedeSocial> cAD_RedeSocialDTO { get; set; }
        public ETipoPessoa tipoPessoa { get; set; }
        public CAD_CNPJ cAD_CNPJDTO { get; set; }
        public CAD_CPF cAD_CPFDTO { get; set; }
    }
}