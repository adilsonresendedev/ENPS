using System;
using System.Linq;
using System.Linq.Expressions;

namespace ENPS.Repos.BaseRepos
{
    public interface IBaseRepo<T>
    {
        IQueryable<T> ListarTodos();
        IQueryable<T> ListarTodos(Expression<Func<T, bool>> expression);
        T Inserir(T entidade);
        T Alterar(T entidade);
    }
}