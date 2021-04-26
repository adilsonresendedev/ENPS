using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.Models;

namespace ENPS.Repositorios.CAD_pessoaRepos
{
    public interface ICAD_pessoaRepo
    {
         Task<CAD_pessoa> Objeto(int PessoaId);

         Task<CAD_pessoa> ObjetoComDependencias(int PessoaId);

         Task<List<CAD_pessoa>> ColecaoPorEmpresa(int empresaId);
    }
}