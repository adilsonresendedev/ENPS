using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_endereco
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public bool Principal { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public COF_Estado COF_Estado { get; set; }
        public COF_Cidade COF_Cidade { get; set; }
        public List<CAD_empresa> CAD_Empresa { get; set; }
        public List<CAD_pessoa> CAD_Pessoa { get; set; }
    }
}