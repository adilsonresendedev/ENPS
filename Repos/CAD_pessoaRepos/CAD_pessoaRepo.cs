using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_pessoaRepos
{
    public class CAD_pessoaRepo : BaseRepo<CAD_pessoa>, ICAD_pessoaRepo
    {
        private readonly DataContext _dataContext;
        public CAD_pessoaRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;

        }
        public Task<List<CAD_pessoa>> ColecaoPorEmpresa(int empresaId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CAD_pessoa> Objeto(int PessoaId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CAD_pessoa> ObjetoComDependencias(int PessoaId)
        {
            throw new System.NotImplementedException();
        }
    }
}