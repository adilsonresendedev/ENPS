using System.Collections.Generic;

namespace ENPS.Models
{
    public class CAD_endereco
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public bool Principal { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public COF_estado COF_estado { get; set; }
        public COF_cidade COF_cidade { get; set; }
        public COF_pais COF_pais { get; set; }
        public List<CAD_empresa> CAD_Empresa { get; set; }
        public List<CAD_pessoa> CAD_Pessoa { get; set; }
    }
}