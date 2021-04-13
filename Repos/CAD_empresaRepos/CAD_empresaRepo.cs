using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.CAD_empresaRepos
{
    public class CAD_empresaRepo : BaseRepo<CAD_empresa>, ICAD_empresaRepo
    {
        private readonly DataContext _dataContext;
        public CAD_empresaRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}