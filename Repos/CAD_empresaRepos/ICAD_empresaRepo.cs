using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_empresaRepos
{
    public interface ICAD_empresaRepo : IBaseRepo<CAD_empresa>
    {
        Task<List<CAD_empresa>> ListarTodasEmpresas();
        Task<CAD_empresa> Objeto(int empresaId);
        Task<CAD_empresa> ObjetoComDependencias(int empresaId);
        Task<List<CAD_empresa>> ListarEmpresasPorUsuario(int userId);
    }
}