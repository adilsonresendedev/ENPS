using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.CAD_telefoneRepos
{
    public class CAD_telefoneRepo : BaseRepo<CAD_Telefone>, ICAD_telefoneRepo
    {
        private readonly DataContext _dataContext;
        public CAD_telefoneRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> Existe(CAD_Telefone cAD_Telefone)
        {
            CAD_Telefone cAD_TelefoneBanco = await _dataContext.CAD_Telefone.FirstOrDefaultAsync(x => x.CodigoPais == cAD_Telefone.CodigoPais && x.CodigoEstado == cAD_Telefone.CodigoEstado && x.Numero == cAD_Telefone.Numero);
            return (cAD_TelefoneBanco != null);
        }

        public async Task<int> Inativar(int Id)
        {
            CAD_Telefone cAD_TelefoneBanco = await _dataContext.CAD_Telefone.FirstOrDefaultAsync(x => x.Id == Id);
            cAD_TelefoneBanco.Ativo = false;
            await _dataContext.SaveChangesAsync();
            return cAD_TelefoneBanco.Id;
        }
    }
}