using System.ComponentModel.DataAnnotations;

namespace ENPS.Models
{
    public class NPS_votacao
    {
        [Key]
        public int cAD_pessoaId { get; set; }
        public CAD_Pessoa CAD_Pessoa { get; set; }
        [Key]
        public int nPS_PesquisaId { get; set; }
        public NPS_Pesquisa NPS_Pesquisa { get; set; }
        public int Nota { get; set; }
        public string LinkVotacao { get; set; }
    }
}