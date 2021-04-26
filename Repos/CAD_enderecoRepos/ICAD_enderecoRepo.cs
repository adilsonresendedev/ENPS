using System.Threading.Tasks;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_enderecoRepos
{
    public interface ICAD_enderecoRepo : IBaseRepo<CAD_endereco>
    {
        Task<bool> Existe(CAD_endereco cAD_endereco);
        Task<int> Inativar(int Id);
    }
}