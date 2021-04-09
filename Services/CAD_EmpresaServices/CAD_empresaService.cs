using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using ENPS.Data;
using ENPS.DTOs;

namespace ENPS.Services.CAD_EmpresaServices
{
    public class CAD_empresaService : ICAD_empresaService
    {
        private readonly IConfiguration _iConfiguration;
        private readonly IMapper _iMapper;
        private readonly DataContext _dataContext;
        public CAD_empresaService(IConfiguration iConfiguration, IMapper iMapper, DataContext dataContext)
        {
            _dataContext = dataContext;
            _iConfiguration = iConfiguration;
            _iMapper = iMapper;
        }
        
        public Task<CAD_empresaDTO> Alterar(CAD_empresaDTO cAD_empresaDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task<CAD_empresaDTO> Inserir(CAD_empresaDTO cAD_empresaDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<CAD_empresaDTO>> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}