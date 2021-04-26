using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.CAD_empresaRepos
{
    public class CAD_empresaRepo : BaseRepo<CAD_empresa>, ICAD_empresaRepo
    {
        private readonly DataContext _dataContext;
        public CAD_empresaRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<CAD_empresa>> ListarEmpresasPorUsuario(int userId)
        {
            return await ListarTodos(x => x.CAD_usuario.Any(u => u.Id == userId))
                .ToListAsync();
        }

        public async Task<List<CAD_empresa>> ListarTodasEmpresas()
        {
            return await ListarTodos()
                .ToListAsync();
        }

        public async Task<CAD_empresa> Objeto(int empresaId)
        {
            return await ListarTodos(x => x.Id == empresaId)
                .FirstOrDefaultAsync();
        }

        public async Task<CAD_empresa> ObjetoComDependencias(int empresaId)
        {
            return await ListarTodos(x => x.Id == empresaId)
                .Include(x => x.CAD_endereco)
                .Include(x => x.CAD_redeSocial)
                .Include(x => x.CAD_telefone)
                .Include(x => x.CAD_usuario)
                .FirstOrDefaultAsync();
        }
    }
}