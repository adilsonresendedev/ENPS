namespace ENPS.DTOs
{
    public class CAD_usuarioDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}