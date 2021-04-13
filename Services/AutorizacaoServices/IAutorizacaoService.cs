using System.Threading.Tasks;
using ENPS.DTOs;
using ENPS.Models;

namespace ENPS.Services.AutorizacaoServices
{
    public interface IAutorizacaoService
    {
         Task<ServiceResponse<CAD_usuarioInserirDTO>> Registrar (CAD_usuarioInserirDTO cAD_usuarioDTO);

         Task<ServiceResponse<string>> Login (CAD_usuarioInserirDTO cAD_usuarioDTO);

         Task<ServiceResponse<bool>> Validar(CAD_usuarioInserirDTO cAD_usuarioDTO);

         Task<ServiceResponse<CAD_usuarioDTO>> Alterar(CAD_usuarioDTO cAD_usuarioDTO);
    }
}