using System.ComponentModel.DataAnnotations;

namespace ENPS.Models
{
    public class NPS_votacao
    {
        [Key]
        public int cAD_pessoaId { get; set; }
        public CAD_pessoa CAD_Pessoa { get; set; }
        [Key]
        public int nPS_PesquisaId { get; set; }
        public NPS_pesquisa NPS_pesquisa { get; set; }
        public int Nota { get; set; }
        public string LinkVotacao { get; set; }
    }
}