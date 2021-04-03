namespace ENPS.DTOs
{
    public class CAD_enderecoDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public bool Principal { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Cidade {get;set;}
        public string Estado {get;set;}
        public string Pais {get;set;}
    }
}