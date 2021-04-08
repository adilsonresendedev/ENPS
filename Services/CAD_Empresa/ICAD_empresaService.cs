using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.DTOs;
using ENPS.DTOs.Empresa;

namespace ENPS.Services.CAD_empresa
{
    public interface ICAD_empresaService
    {
        Task<_ServiceResponse<int>> Inserir(InserirCAD_empresaDto inserirCAD_empresaDto);
        Task<_ServiceResponse<CAD_empresaDTO>> Alterar(AlterarCAD_empresaDto alterarCAD_empresaDto);
        Task<_ServiceResponse<List<CAD_empresaDTO>>> Colecao();
    }
}