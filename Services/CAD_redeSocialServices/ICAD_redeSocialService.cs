using System.Threading.Tasks;
using ENPS.DTOs;

namespace ENPS.Services.CAD_redeSocialServices
{
    public interface ICAD_redeSocialService
    {
         Task<int> Inserir(CAD_redeSocialDTO CAD_redeSocialDTO);
    }
}