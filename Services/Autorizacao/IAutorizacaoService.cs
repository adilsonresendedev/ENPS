using System.Threading.Tasks;
using ENPS.DTOs;
using ENPS.Models;

namespace ENPS.Services.Autorizacao
{
    public interface IAutorizacaoService
    {
         Task<_ServiceResponse<CAD_usuarioDTO>> Registrar (CAD_usuarioDTO cAD_usuarioDTO);

         Task<_ServiceResponse<string>> Logar (string nome, string senha);

         Task<_ServiceResponse<bool>> Validar(CAD_usuarioDTO cAD_usuarioDTO);
    }
}