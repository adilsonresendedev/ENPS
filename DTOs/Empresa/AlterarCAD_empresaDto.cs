using System.Collections.Generic;

namespace ENPS.DTOs.Empresa
{
    public class AlterarCAD_empresaDto
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;
        public string Fantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string IE { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
    }
}