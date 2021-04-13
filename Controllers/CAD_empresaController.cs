using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.DTOs;
using ENPS.DTOs.Empresa;
using ENPS.Services.CAD_EmpresaServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ENPS.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CAD_empresaController : ControllerBase
    {
        private readonly ICAD_empresaService _cAD_empresaService;
        public CAD_empresaController(ICAD_empresaService cAD_empresaService)
        {
            _cAD_empresaService = cAD_empresaService;
        }

        [HttpPost(nameof(Inserir))]
        public async Task<IActionResult> Inserir(InserirCAD_empresaDto inserirCAD_empresaDto)
        {
            ServiceResponse<int> response = await _cAD_empresaService.Inserir(inserirCAD_empresaDto);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut(nameof(Alterar))]
        public async Task<IActionResult> Alterar(AlterarCAD_empresaDto alterarCAD_empresaDto)
        {
            ServiceResponse<CAD_empresaDTO> response = await _cAD_empresaService.Alterar(alterarCAD_empresaDto);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet(nameof(Colecao))]
        public async Task<IActionResult> Colecao()
        {
            return Ok(await _cAD_empresaService.Colecao());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Objeto(int id)
        {
            ServiceResponse<CAD_empresaDTO> response = await _cAD_empresaService.ObjetoEmpresa(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}