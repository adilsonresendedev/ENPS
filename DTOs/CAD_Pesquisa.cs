using System;

namespace ENPS.DTOs
{
    public class CAD_PesquisaNPSDTO
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public int IdEnpresa { get; set; }
        public int IdOperador { get; set; }
        public string Descricao { get; set; }
        public int NotaMinima { get; set; }
        public int NotaMaxima { get; set; }
        public string LinkPesquisa { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }

    }
}