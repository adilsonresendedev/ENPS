using ENPS.DTOs;
using ENPS.Models;
using ENPS.Mensagens;
using System;
using System.Threading.Tasks;
using System.Linq;
using FluentValidation.Results;
using ENPS.Validadores;
using System.Collections.Generic;
using ENPS.Util;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using ENPS.Data;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Services.Autorizacao
{
    public class AutorizacaoService : IAutorizacaoService
    {
        private readonly IConfiguration _iConfiguration;
        private readonly IMapper _iMapper;
        private readonly DataContext _dataContext;
        public AutorizacaoService(IConfiguration iConfiguration, IMapper iMapper, DataContext dataContext)
        {
            _dataContext = dataContext;
            _iConfiguration = iConfiguration;
            _iMapper = iMapper;
        }

        private async Task<bool> Existe(CAD_usuarioDTO cAD_usuarioDTO)
        {
            await Task.Delay(100);
            return false;
        }

        public async Task<_ServiceResponse<string>> Login(CAD_usuarioDTO cAD_usuarioDTO)
        {
            _ServiceResponse<string> _serviceResponse = new _ServiceResponse<string>();
            try
            {
                CAD_Usuario cAD_Usuario = await _dataContext.CAD_usuario.FirstAsync(x => x.CAD_email.Email == cAD_usuarioDTO.Email);
                if (cAD_Usuario.Equals(null))
                {
                    _serviceResponse.Success = false;
                    _serviceResponse.Message = UsuarioMensagem.UsuarioNaoEncontrado();
                    return _serviceResponse;
                }
                else if (!VerificarPasswordHash(cAD_usuarioDTO.Senha, cAD_Usuario.SenhaHash, cAD_Usuario.SenhaSalt))
                {
                    _serviceResponse.Success = false;
                    _serviceResponse.Message = UsuarioMensagem.SenhaInvalida();
                    return _serviceResponse;
                }

                _serviceResponse.Data = CreateToken(cAD_usuarioDTO);
            }
            catch (Exception ex)
            {
                _serviceResponse.Success = false;
                _serviceResponse.Message = ex.Message;
            }

            return _serviceResponse;
        }

        public async Task<_ServiceResponse<CAD_usuarioDTO>> Registrar(CAD_usuarioDTO cAD_usuarioDTO)
        {
            _ServiceResponse<CAD_usuarioDTO> _serviceResponse = new _ServiceResponse<CAD_usuarioDTO>();
            try
            {
                if (await Existe(cAD_usuarioDTO))
                {
                    _serviceResponse.Success = false;
                    _serviceResponse.Message = UsuarioMensagem.UsuarioJaCadastrado();
                    return _serviceResponse;
                }

                SenhaHashUtil.CriarSenhaHash(cAD_usuarioDTO.Senha, out byte[] senhaHash, out byte[] senhaSalt);
                cAD_usuarioDTO.SenhaHash = senhaHash;
                cAD_usuarioDTO.SenhaSalt = senhaSalt;

                _serviceResponse.Data = cAD_usuarioDTO;
                _serviceResponse.Message = UsuarioMensagem.SucessoCadastro();
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

        private string CreateToken(CAD_usuarioDTO cAD_usuarioDTO)
        {
            List<Claim> claim = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, cAD_usuarioDTO.Id.ToString()),
            };

            SymmetricSecurityKey systemSecurityKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_iConfiguration.GetSection("AppSettings").GetSection("Token").Value)
            );

            SigningCredentials signingCredentials = new SigningCredentials(systemSecurityKey, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = signingCredentials
            };

            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            return jwtSecurityTokenHandler.WriteToken(securityToken);
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
                }

                _serviceResponse.Data = validationResult.IsValid;
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