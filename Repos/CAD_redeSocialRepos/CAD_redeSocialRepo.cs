using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.CAD_redeSocialRepos
{
    public class CAD_redeSocialRepo : BaseRepo<CAD_redeSocial>,  ICAD_redeSocialRepo
    {
        private readonly DataContext _dataContext;
        public CAD_redeSocialRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> Existe(string  LinkRedeSocial)
        {
            CAD_redeSocial cAD_redeSocial = await _dataContext.CAD_redeSocial.FirstOrDefaultAsync(x => x.LinkRedeSocial == LinkRedeSocial);
            return (cAD_redeSocial != null);
        }

        public async Task<int> Inativar(int Id)
        {
            CAD_redeSocial cAD_redeSocial = await _dataContext.CAD_redeSocial.FirstOrDefaultAsync(x => x.Id == Id);
            cAD_redeSocial.Ativo = false;
            await _dataContext.SaveChangesAsync();
            return cAD_redeSocial.Id;
        }
    }
}