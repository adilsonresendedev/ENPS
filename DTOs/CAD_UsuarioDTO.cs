namespace ENPS.DTOs
{
    public class CAD_UsuarioDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public CAD_PessoaDTO cAD_PessoaDTO { get; set; }
        public CAD_EmpresaDTO cAD_EmpresaDTO { get; set; }
    }
}