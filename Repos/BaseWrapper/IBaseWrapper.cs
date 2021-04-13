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
        ICAD_empresaRepo iCAD_empresaRepo { get; }
        ICAD_enderecoRepo iCAD_enderecoRepo { get; }
        ICAD_pessoaRepo iCAD_pessoaRepo { get; }
        ICAD_redeSocialRepo iCAD_redeSocialRepo { get; }
        ICAD_telefoneRepo iCAD_telefoneRepo { get; }
        ICAD_usuarioRepo iCAD_usuarioRepo { get; }
        ICOF_cidadeRepo iCOF_cidadeRepo { get; }
        ICOF_estadoRepo iCOF_estadoRepo { get; }
        ICOF_paisRepo iCOF_paisRepo { get; }
        INPS_pesquisaRepo iNPS_pesquisaRepo { get; }
        INPS_votacaoRepo iNPS_votacaoRepo { get; }
        Task Save();
    }
}