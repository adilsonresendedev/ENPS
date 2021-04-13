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

namespace ENPS.Services.AutorizacaoServices
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

        private async Task<bool> Existe(CAD_usuarioInserirDTO cAD_usuarioDTO)
        {
            await Task.Delay(100);
            return false;
        }

        public async Task<ServiceResponse<string>> Login(CAD_usuarioInserirDTO cAD_usuarioDTO)
        {
            ServiceResponse<string> _serviceResponse = new ServiceResponse<string>();
            try
            {
                CAD_pessoa cAD_pessoa = _dataContext.CAD_Pessoa.FirstOrDefault(x => x.Email == cAD_usuarioDTO.Email);
                CAD_Usuario cAD_Usuario = await _dataContext.CAD_usuario.FirstOrDefaultAsync(x => x.CAD_pessoa.Id == cAD_pessoa.Id);
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

                _serviceResponse.Data = CreateToken(cAD_Usuario);
            }
            catch (Exception ex)
            {
                _serviceResponse.Success = false;
                _serviceResponse.Message = ex.Message;
            }

            return _serviceResponse;
        }

        public async Task<ServiceResponse<CAD_usuarioInserirDTO>> Registrar(CAD_usuarioInserirDTO cAD_usuarioDTO)
        {
            CAD_Usuario cAD_usuario = new CAD_Usuario();
            ServiceResponse<CAD_usuarioInserirDTO> _serviceResponse = new ServiceResponse<CAD_usuarioInserirDTO>();
            try
            {
                if (await Existe(cAD_usuarioDTO))
                {
                    _serviceResponse.Success = false;
                    _serviceResponse.Message = UsuarioMensagem.UsuarioJaCadastrado();
                    return _serviceResponse;
                }

                SenhaHashUtil.CriarSenhaHash(cAD_usuarioDTO.Senha, out byte[] senhaHash, out byte[] senhaSalt);
                cAD_usuario.SenhaHash = senhaHash;
                cAD_usuario.SenhaSalt = senhaSalt;
                cAD_usuario.CAD_pessoa = new CAD_pessoa
                {
                    Nome = cAD_usuarioDTO.Nome,
                    Email = cAD_usuarioDTO.Email
                };

                await _dataContext.CAD_usuario.AddAsync(cAD_usuario);
                await _dataContext.SaveChangesAsync();

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

        private string CreateToken(CAD_Usuario cAD_Usuario)
        {
            List<Claim> claim = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, cAD_Usuario.Id.ToString()),
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

        public async Task<ServiceResponse<bool>> Validar(CAD_usuarioInserirDTO cAD_usuarioInserirDTO)
        {
            ServiceResponse<bool> _serviceResponse = new ServiceResponse<bool>();
            try
            {
                CAD_usuarioValidador cAD_usuarioValidador = new CAD_usuarioValidador();
                ValidationResult validationResult = await cAD_usuarioValidador.ValidateAsync(cAD_usuarioInserirDTO);
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

        public async Task<ServiceResponse<CAD_usuarioDTO>> Alterar(CAD_usuarioDTO cAD_usuarioDTO)
        {
            ServiceResponse<CAD_usuarioDTO> _serviceResponse = new ServiceResponse<CAD_usuarioDTO>();
            try
            {
                await Task.Delay(1);
            }
            catch (Exception ex)
            {
                _serviceResponse.Message = ex.Message;
            }

            return _serviceResponse;
        }
    }
}