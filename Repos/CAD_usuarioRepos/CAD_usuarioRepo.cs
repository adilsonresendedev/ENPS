using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.CAD_usuarioRepos
{
    public class CAD_usuarioRepo : BaseRepo<CAD_Usuario>, ICAD_usuarioRepo
    {
        private readonly DataContext _dataContext;
        public CAD_usuarioRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<CAD_Usuario> Objeto(int userId)
        {
            return await ListarTodos(x => x.Id == userId)
                .FirstOrDefaultAsync();
        }
    }
}