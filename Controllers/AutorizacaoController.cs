using ENPS.DTOs;
using ENPS.Services.Autorizacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ENPS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorizacaoController : ControllerBase
    {
        private readonly IAutorizacaoService _iAutorizacaoService;
        public AutorizacaoController(IAutorizacaoService iAutorizacaoService)
        {
            _iAutorizacaoService = iAutorizacaoService;
        }

        [HttpPost]
        public async Task<ActionResult> Registrar(CAD_usuarioDTO cAD_usuarioDTO)
        {
            _ServiceResponse<bool> _serviceResponseValidar = await _iAutorizacaoService.Validar(cAD_usuarioDTO);
            if (!_serviceResponseValidar.Data || !_serviceResponseValidar.Success)
            {
                return BadRequest(_serviceResponseValidar.Message);
            }

            _ServiceResponse<CAD_usuarioDTO> _ServiceResponseCAD_usuarioDTO = await _iAutorizacaoService.Registrar(cAD_usuarioDTO);
            if (!_ServiceResponseCAD_usuarioDTO.Success)
            {
                return BadRequest(_ServiceResponseCAD_usuarioDTO.Message);
            }

            return Ok(_ServiceResponseCAD_usuarioDTO);
        }
    }
}