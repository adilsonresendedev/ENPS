namespace ENPS.DTOs
{
    public class CAD_usuarioInserirDTO
    {
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}