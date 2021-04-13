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

        public async Task<int> Inserir(CAD_redeSocial cAD_redeSocial)
        {
            await _dataContext.CAD_redeSocial.AddAsync(cAD_redeSocial);
            await _dataContext.SaveChangesAsync();
            return cAD_redeSocial.Id;
        }
    }
}