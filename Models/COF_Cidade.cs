namespace ENPS.Models
{
    public class COF_cidade
    {
        public int Id { get; set; }
        public COF_estado COF_estado { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
    }
}