using ENPS.Enumeradores;

namespace ENPS.Mensagens
{
    public static class UsuarioMensagem
    {
        public static string UsuarioJaCadastrado()
        {
            return "Usuário já cadastrado!";
        }

        public static string UsuarioNaoEncontrado()
        {
            return "Usuário não encontrado!";
        }

         public static string SenhaInvalida()
        {
            return "Senha inválida!";
        }
    }
}