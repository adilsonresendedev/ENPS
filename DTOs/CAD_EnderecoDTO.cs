namespace ENPS.DTOs
{
    public class CAD_EnderecoDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public COF_EstadoDTO cOF_EstadoDTO { get; set; }
        public COF_CidadeDTO cOF_CidadeDTO { get; set; }
    }
}