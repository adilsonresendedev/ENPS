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
using ENPS.Models;
using ENPS.Repos.BaseWrapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Services.CAD_EmpresaServices
{
    public class CAD_empresaService : ICAD_empresaService
    {
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBaseWrapper _wrapper;

        public CAD_empresaService(IBaseWrapper wrapper, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _wrapper = wrapper;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<ServiceResponse<CAD_empresaDTO>> Alterar(AlterarCAD_empresaDto alterarCAD_empresaDto)
        {
            ServiceResponse<CAD_empresaDTO> response = new ServiceResponse<CAD_empresaDTO>();
            try
            {
                CAD_empresa cAD_empresa = await _wrapper.ICAD_empresaRepo.ObjetoComDependencias(alterarCAD_empresaDto.Id);
                if (cAD_empresa.CAD_Usuario.Any(u => u.Id == GetUserId()))
                {
                    cAD_empresa.Ativo = alterarCAD_empresaDto.Ativo;
                    cAD_empresa.Fantasia = alterarCAD_empresaDto.Fantasia;
                    cAD_empresa.RazaoSocial = alterarCAD_empresaDto.RazaoSocial;
                    cAD_empresa.IE = alterarCAD_empresaDto.IE;
                    cAD_empresa.CNPJ = alterarCAD_empresaDto.CNPJ;
                    cAD_empresa.Email = alterarCAD_empresaDto.Email;

                    cAD_empresa = _wrapper.ICAD_empresaRepo.Alterar(cAD_empresa);
                    await _wrapper.Save();

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

        public async Task<ServiceResponse<List<CAD_empresaDTO>>> Colecao()
        {
            ServiceResponse<List<CAD_empresaDTO>> response = new ServiceResponse<List<CAD_empresaDTO>>();
            List<CAD_empresa> cAD_empresaColecao = await _wrapper.ICAD_empresaRepo.ListarEmpresasPorUsuario(GetUserId());
            response.Data = _mapper.Map<List<CAD_empresaDTO>>(cAD_empresaColecao);
            return response;
        }

        public async Task<ServiceResponse<int>> Inserir(InserirCAD_empresaDto inserirCAD_empresaDto)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            CAD_empresa cAD_empresa = _mapper.Map<CAD_empresa>(inserirCAD_empresaDto);

            cAD_empresa.CAD_Usuario.Add(await _wrapper.ICAD_usuarioRepo.Objeto(GetUserId()));
            cAD_empresa = _wrapper.ICAD_empresaRepo.Inserir(cAD_empresa);
            await _wrapper.Save();

            return response;
        }

        public async Task<ServiceResponse<CAD_empresaDTO>> ObjetoEmpresa(int empresaId)
        {
            ServiceResponse<CAD_empresaDTO> response = new ServiceResponse<CAD_empresaDTO>();
            CAD_empresa cAD_empresa = await _wrapper.ICAD_empresaRepo.ObjetoComDependencias(empresaId);

            if (cAD_empresa.CAD_Usuario.Any(u => u.Id == GetUserId()))
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