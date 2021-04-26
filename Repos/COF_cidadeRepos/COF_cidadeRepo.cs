using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.COF_cidadeRepos
{
    public class COF_cidadeRepo : BaseRepo<COF_cidade>, ICOF_cidadeRepo
    {
        private readonly DataContext _dataContext;
        public COF_cidadeRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;

        }
        public async Task<List<COF_cidade>> Colecao(int estado_id, string cidade_nome)
        {
            return await _dataContext.COF_Cidade
                .Where(x => x.COF_estado.Id == estado_id && x.Nome.Contains(cidade_nome))
                .ToListAsync();
        }

        public async Task<COF_cidade> Objeto(int cidade_id)
        {
            return await _dataContext.COF_Cidade
                .FirstOrDefaultAsync(x => x.Id == cidade_id);
        }
    }
}