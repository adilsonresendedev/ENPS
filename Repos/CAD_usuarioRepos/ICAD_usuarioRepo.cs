using System.Threading.Tasks;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_usuarioRepos
{
    public interface ICAD_usuarioRepo : IBaseRepo<CAD_Usuario>
    {
        Task<CAD_Usuario> Objeto(int userId);
    }
}