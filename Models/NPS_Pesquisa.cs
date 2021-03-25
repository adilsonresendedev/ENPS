using System.Collections.Generic;
using System;

namespace ENPS.Models
{
    public class NPS_Pesquisa
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public CAD_Empresa CAD_Empresa { get; set; }
        public int IdOperador { get; set; }
        public string Descricao { get; set; }
        public int NotaMinima { get; set; }
        public int NotaMaxima { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public List<NPS_votacao> NPS_votacao { get; set; }
    }
}