using System.Threading.Tasks;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_redeSocialRepos
{
    public interface ICAD_redeSocialRepo
    { 
        Task<bool> Existe(string LinkRedeSocial);
        Task<int> Inativar(int Id);
    }
}