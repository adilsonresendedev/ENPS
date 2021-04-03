using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.DTOs;

namespace ENPS.Services.CAD_empresa
{
    public interface ICAD_empresaService
    {
         Task<CAD_empresaDTO> Inserir(CAD_empresaDTO cAD_empresaDTO);

         Task<CAD_empresaDTO> Alterar(CAD_empresaDTO cAD_empresaDTO);

         Task<List<CAD_empresaDTO>> Listar();
    }
}