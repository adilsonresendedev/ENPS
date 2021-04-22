using System.Threading.Tasks;
using ENPS.Repositorios.CAD_empresaRepos;
using ENPS.Repositorios.CAD_enderecoRepos;
using ENPS.Repositorios.CAD_pessoaRepos;
using ENPS.Repositorios.CAD_redeSocialRepos;
using ENPS.Repositorios.CAD_telefoneRepos;
using ENPS.Repositorios.CAD_usuarioRepos;
using ENPS.Repositorios.COF_cidadeRepos;
using ENPS.Repositorios.COF_estadoRepos;
using ENPS.Repositorios.INPS_pesquisaRepositorio;
using ENPS.Repositorios.NPS_pesquisaRepos;
using ENPS.Repositorios.NPS_votacaoRepos;

namespace ENPS.Repos.BaseWrapper
{
    public interface IBaseWrapper
    {
        ICAD_empresaRepo CAD_empresaRepo { get; }
        ICAD_enderecoRepo ICAD_enderecoRepo { get; }
        ICAD_pessoaRepo ICAD_pessoaRepo { get; }
        ICAD_redeSocialRepo ICAD_redeSocialRepo { get; }
        ICAD_telefoneRepo ICAD_telefoneRepo { get; }
        ICAD_usuarioRepo ICAD_usuarioRepo { get; }
        ICOF_cidadeRepo ICOF_cidadeRepo { get; }
        ICOF_estadoRepo ICOF_estadoRepo { get; }
        ICOF_paisRepo ICOF_paisRepo { get; }
        INPS_pesquisaRepo INPS_pesquisaRepo { get; }
        INPS_votacaoRepo INPS_votacaoRepo { get; }
        Task Save();
    }
}