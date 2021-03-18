namespace ENPS.Models
{
    public class CAD_Endereco
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public bool Principal { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public COF_Estado cOF_EstadoDTO { get; set; }
        public COF_Cidade cOF_CidadeDTO { get; set; }
    }
}