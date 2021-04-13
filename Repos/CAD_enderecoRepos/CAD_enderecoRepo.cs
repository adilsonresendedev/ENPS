using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_enderecoRepos
{
    public class CAD_enderecoRepo : BaseRepo<CAD_endereco>, ICAD_enderecoRepo
    {
        private readonly DataContext _dataContext;
        public CAD_enderecoRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}