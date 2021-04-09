using System.Linq;
using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.CAD_redeSocialRepos
{
    public class CAD_redeSocialRepo : ICAD_redeSocialRepo
    {
        private readonly DataContext _dataContext;
        public CAD_redeSocialRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<CAD_redeSocial> Alterar(CAD_redeSocial cAD_redeSocial)
        {
            CAD_redeSocial cAD_redeSocialBanco = await _dataContext.CAD_redeSocial.FirstOrDefaultAsync(x => x.Id == cAD_redeSocial.Id);
            if (cAD_redeSocialBanco.Equals(null))
            {
                return cAD_redeSocialBanco;
            }

            cAD_redeSocialBanco.ERedeSocial = cAD_redeSocial.ERedeSocial;
            cAD_redeSocialBanco.LinkRedeSocial = cAD_redeSocial.LinkRedeSocial;
            await _dataContext.SaveChangesAsync();

            return cAD_redeSocialBanco;
        }

        public Task<bool> Existe(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Inativar(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Inserir(CAD_redeSocial cAD_redeSocial)
        {
            throw new System.NotImplementedException();
        }
    }
}