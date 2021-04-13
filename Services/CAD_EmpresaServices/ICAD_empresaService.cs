using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.DTOs;
using ENPS.DTOs.Empresa;

namespace ENPS.Services.CAD_EmpresaServices
{
    public interface ICAD_empresaService
    {
        Task<ServiceResponse<int>> Inserir(InserirCAD_empresaDto inserirCAD_empresaDto);
        Task<ServiceResponse<CAD_empresaDTO>> Alterar(AlterarCAD_empresaDto alterarCAD_empresaDto);
        Task<ServiceResponse<List<CAD_empresaDTO>>> Colecao();
        Task<ServiceResponse<CAD_empresaDTO>> ObjetoEmpresa(int Id);
    }
}