namespace ENPS.Models
{
    public class COF_Cidade
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public int CEP { get; set; }
        public string Nome { get; set; }
    }
}