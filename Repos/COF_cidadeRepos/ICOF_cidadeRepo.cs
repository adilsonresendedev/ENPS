using System.Collections.Generic;
using System.Threading.Tasks;
using ENPS.Models;

namespace ENPS.Repositorios.COF_cidadeRepos
{
    public interface ICOF_cidadeRepo
    {
         Task<List<COF_cidade>> Colecao(int estado_id, string cidade_nome);

         Task<COF_cidade> Objeto(int cidade_id);
    }
}