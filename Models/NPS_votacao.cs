namespace ENPS.Models
{
    public class NPS_votacao
    {
        public CAD_Pessoa cAD_PessoaDTO { get; set; }
        public NPS_Pesquisa nPS_PesquisaDTO { get; set; }
        public int Nota { get; set; }
        public string LinkVotacao { get; set; }
    }
}