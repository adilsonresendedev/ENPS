using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using ENPS.Data;
using ENPS.DTOs;
using ENPS.DTOs.Empresa;
using ENPS.Mensagens;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Services.CAD_empresa
{
    public class CAD_empresaService : ICAD_empresaService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CAD_empresaService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<_ServiceResponse<CAD_empresaDTO>> Alterar(AlterarCAD_empresaDto alterarCAD_empresaDto)
        {
            _ServiceResponse<CAD_empresaDTO> response = new _ServiceResponse<CAD_empresaDTO>();
            try
            {
                Models.CAD_empresa cAD_empresa = await _context.CAD_Empresa.Include(e => e.CAD_Usuario).FirstOrDefaultAsync(e => e.Id == alterarCAD_empresaDto.Id);
                if (cAD_empresa.CAD_Usuario.Any(u => u.Id == GetUserId()))
                {
                    cAD_empresa.Ativo = alterarCAD_empresaDto.Ativo;
                    cAD_empresa.Fantasia = alterarCAD_empresaDto.Fantasia;
                    cAD_empresa.RazaoSocial = alterarCAD_empresaDto.RazaoSocial;
                    cAD_empresa.IE = alterarCAD_empresaDto.IE;
                    cAD_empresa.CNPJ = alterarCAD_empresaDto.CNPJ;
                    cAD_empresa.Email = alterarCAD_empresaDto.Email;

                    _context.CAD_Empresa.Update(cAD_empresa);
                    await _context.SaveChangesAsync();

                    response.Data = _mapper.Map<CAD_empresaDTO>(cAD_empresa);
                }
                else
                {
                    response.Message = EmpresaMensagem.EmpresaNaoEncontrada;
                    response.Success = false;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        public async Task<_ServiceResponse<List<CAD_empresaDTO>>> Colecao()
        {
            _ServiceResponse<List<CAD_empresaDTO>> response = new _ServiceResponse<List<CAD_empresaDTO>>();
            List<Models.CAD_empresa> cAD_empresaColecao = await _context.CAD_Empresa
                .Include(e => e.CAD_enderedo)
                .Include(e => e.CAD_telefone)
                .Include(e => e.CAD_redeSocial)
                .Where(e => e.CAD_Usuario.Any(u => u.Id == GetUserId()))
                .ToListAsync();

            response.Data = _mapper.Map<List<CAD_empresaDTO>>(cAD_empresaColecao);
            return response;
        }

        public async Task<_ServiceResponse<int>> Inserir(InserirCAD_empresaDto inserirCAD_empresaDto)
        {
            _ServiceResponse<int> response = new _ServiceResponse<int>();
            Models.CAD_empresa cAD_empresa = _mapper.Map<Models.CAD_empresa>(inserirCAD_empresaDto);
            cAD_empresa.CAD_Usuario.Add(await _context.CAD_usuario.FirstOrDefaultAsync(u => u.Id == GetUserId()));
            await _context.AddAsync(cAD_empresa);

            return response;
        }

        public async Task<_ServiceResponse<CAD_empresaDTO>> Objeto(int Id)
        {
            _ServiceResponse<CAD_empresaDTO> response = new _ServiceResponse<CAD_empresaDTO>();
            Models.CAD_empresa cAD_empresa = await _context.CAD_Empresa
                .Include(e => e.CAD_Usuario)
                .FirstOrDefaultAsync(e => e.Id == Id);

            if(cAD_empresa.CAD_Usuario.Any(u => u.Id == GetUserId()))
            {
                response.Data = _mapper.Map<CAD_empresaDTO>(cAD_empresa);
            }
            else
            {
                response.Success = false;
                response.Message = EmpresaMensagem.EmpresaNaoEncontrada;
            }
            return response;
        }
    }
}