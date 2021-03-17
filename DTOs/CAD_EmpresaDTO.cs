using System.Collections.Generic;

namespace ENPS.DTOs
{
    public class CAD_EmpresaDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public CAD_CNPJDTO cAD_CNPJDTO { get; set; }
        public string IE { get; set; }
        public List<CAD_EnderecoDTO> enderedoDTO { get; set; }
        public List<CAD_TelefoneDTO> telefoneDTO { get; set; }
        public COF_EstadoDTO estadoDTO { get; set; }
        public COF_CidadeDTO cidadeDTO { get; set; }
    }
}