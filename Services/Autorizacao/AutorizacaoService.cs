using ENPS.DTOs;
using ENPS.Models;
using ENPS.Mensagens;
using System;
using System.Threading.Tasks;

using DOTNET_RPG.Util;
using FluentValidation.Results;
using ENPS.Validadores;

namespace ENPS.Services.Autorizacao
{
    public class AutorizacaoService : IAutorizacaoService
    {
        private async Task<bool> Existe(CAD_usuarioDTO cAD_usuarioDTO)
        {
            await Task.Delay(100);
            return false;
        }

        public Task<_ServiceResponse<string>> Logar(string nome, string senha)
        {
            throw new System.NotImplementedException();
        }

        public async Task<_ServiceResponse<CAD_usuarioDTO>> Registrar(CAD_usuarioDTO cAD_usuarioDTO)
        {
            _ServiceResponse<CAD_usuarioDTO> _serviceResponse = new _ServiceResponse<CAD_usuarioDTO>();
            try
            {
                if (await Existe(cAD_usuarioDTO))
                {
                    _serviceResponse.Success = false;
                    _serviceResponse.Message = Mensagem.UsuarioJaCadastrado();
                    return _serviceResponse;
                }

                SenhaHashUtil.CriarSenhaHash(cAD_usuarioDTO.Senha, out byte[] senhaHash, out byte[] senhaSalt);
                cAD_usuarioDTO.SenhaHash = senhaHash;
                cAD_usuarioDTO.SenhaSalt = senhaSalt;

                _serviceResponse.Data = cAD_usuarioDTO;

                return _serviceResponse;
            }
            catch (Exception ex)
            {
                _serviceResponse.Success = false;
                _serviceResponse.Message = ex.Message;
                return _serviceResponse;
            }
        }


        private bool VerificarPasswordHash(string senha, byte[] senhaHash, byte[] senhadSalt)
        {
            using (var hmacsha = new System.Security.Cryptography.HMACSHA512(senhadSalt))
            {
                var ComputeHash = hmacsha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
                for (int i = 0; i < ComputeHash.Length; i++)
                {
                    if (ComputeHash[i] != senhaHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public async Task<_ServiceResponse<bool>> Validar(CAD_usuarioDTO cAD_usuarioDTO)
        {
            _ServiceResponse<bool> _serviceResponse = new _ServiceResponse<bool>();
            try
            {
                CAD_usuarioValidador cAD_usuarioValidador = new CAD_usuarioValidador();
                ValidationResult validationResult = await cAD_usuarioValidador.ValidateAsync(cAD_usuarioDTO);
                if (!validationResult.IsValid)
                {
                    _serviceResponse.Message = validationResult.ToString();
                    _serviceResponse.Data = false;
                }
            }
            catch (Exception ex)
            {
                _serviceResponse.Message = ex.Message;
                _serviceResponse.Data = false;
            }

            return _serviceResponse;
        }
    }
}