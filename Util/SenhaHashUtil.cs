namespace ENPS.Util
{
    public static class SenhaHashUtil
    {
        public static void CriarSenhaHash(string senha, out byte[] senhadHash, out byte[] senhaSalt)
        {
            using (var hmacsha = new System.Security.Cryptography.HMACSHA512())
            {
                senhaSalt = hmacsha.Key;
                senhadHash = hmacsha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}