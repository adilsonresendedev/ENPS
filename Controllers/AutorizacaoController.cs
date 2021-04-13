using ENPS.DTOs;
using ENPS.Services.AutorizacaoServices;
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
        public async Task<ActionResult> Registrar(CAD_usuarioInserirDTO cAD_usuarioDTO)
        {
            ServiceResponse<bool> _serviceResponseValidar = await _iAutorizacaoService.Validar(cAD_usuarioDTO);
            if (!_serviceResponseValidar.Data || !_serviceResponseValidar.Success)
            {
                return BadRequest(_serviceResponseValidar.Message);
            }

            ServiceResponse<CAD_usuarioInserirDTO> _ServiceResponseCAD_usuarioDTO = await _iAutorizacaoService.Registrar(cAD_usuarioDTO);
            if (!_ServiceResponseCAD_usuarioDTO.Success)
            {
                return BadRequest(_ServiceResponseCAD_usuarioDTO.Message);
            }

            return Ok(_ServiceResponseCAD_usuarioDTO.Message);
        }

        [HttpPost(nameof(Login))]
        public async Task<ActionResult> Login(CAD_usuarioInserirDTO cAD_usuarioDTO)
        {
            ServiceResponse<string> _serviceResponse = await _iAutorizacaoService.Login(cAD_usuarioDTO);
            if (!_serviceResponse.Success)
            {
                return BadRequest(_serviceResponse);
            }

            return Ok(_serviceResponse);
        }

        [HttpPost(nameof(Alterar))]
        public async Task<ActionResult> Alterar(CAD_usuarioDTO cAD_usuarioDTO)
        {
            ServiceResponse<CAD_usuarioDTO> _serviceResponse = await _iAutorizacaoService.Alterar(cAD_usuarioDTO);
            if (!_serviceResponse.Success)
            {
                return BadRequest(_serviceResponse);
            }

            return Ok(_serviceResponse);
        }
    }
}