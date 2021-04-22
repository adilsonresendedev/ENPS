using System;
using ENPS.Data;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Repos.BaseRepos
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly DataContext _dataContext;
        public BaseRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public T Alterar(T entidade)
        {
            _dataContext.Set<T>().Update(entidade);
            return entidade;
        }

        public T Inserir(T entidade)
        {
            _dataContext.Set<T>().Add(entidade);
            return entidade;
        }

        public IQueryable<T> ListarTodos()
        {
            return _dataContext.Set<T>()
                .AsNoTracking();
        }

        public IQueryable<T> ListarTodos(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>()
            .Where(expression)
            .AsNoTracking();
        }
    }
}