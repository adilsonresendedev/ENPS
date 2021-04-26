using System.Threading.Tasks;
using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repositorios.CAD_enderecoRepos
{
    public class CAD_enderecoRepo : BaseRepo<CAD_endereco>, ICAD_enderecoRepo
    {
        private readonly DataContext _dataContext;
        public CAD_enderecoRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> Existe(CAD_endereco cAD_endereco)
        {
            CAD_endereco cAD_enderecoBanco = await _dataContext.CAD_endereco.FirstOrDefaultAsync(x => x.Logradouro == cAD_endereco.Logradouro && x.Numero == cAD_endereco.Numero && x.Bairro == cAD_endereco.Bairro && x.Complemento == cAD_endereco.Complemento);
            return (cAD_enderecoBanco != null);
        }

        public async Task<int> Inativar(int Id)
        {
            CAD_endereco cAD_enderecoBanco = await _dataContext.CAD_endereco.FirstOrDefaultAsync(x => x.Id == Id);
            cAD_enderecoBanco.Ativo = false;
            await _dataContext.SaveChangesAsync();
            return cAD_enderecoBanco.Id;
        }
    }
}