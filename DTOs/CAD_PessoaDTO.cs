using System.Collections.Generic;
using ENPS.Enumeradores;

namespace ENPS.DTOs
{
    public class CAD_PessoaDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public CAD_EnderecoDTO cAD_EnderecoDTO { get; set; }
        public List<CAD_TelefoneDTO> cAD_TelefoneDTO { get; set; }
        public List<CAD_RedeSocialDTO> cAD_RedeSocialDTO { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public CAD_CNPJDTO cAD_CNPJDTO {get;set;}
        public CAD_CPFDTO cAD_CPFDTO  {get;set;}
    }
}