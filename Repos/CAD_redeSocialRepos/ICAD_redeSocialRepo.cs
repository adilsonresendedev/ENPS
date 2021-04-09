using System.Threading.Tasks;
using ENPS.Models;

namespace ENPS.Repositorios.CAD_redeSocialRepos
{
    public interface ICAD_redeSocialRepo
    {
        Task<bool> Existe(int Id);

        Task<int> Inserir(CAD_redeSocial cAD_redeSocial);

        Task<CAD_redeSocial> Alterar(CAD_redeSocial cAD_redeSocial);

        Task<int> Inativar(int Id);
    }
}