using System.Threading.Tasks;
using ENPS.Models;

namespace ENPS.Repositorios.CAD_telefoneRepos
{
    public interface ICAD_telefoneRepo
    {
         Task<bool> Existe(CAD_Telefone cAD_Telefone);
        Task<int> Inativar(int Id);
    }
}