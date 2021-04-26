using ENPS.Repos.BaseWrapper;
using ENPS.Repositorios.CAD_empresaRepos;
using Microsoft.Extensions.DependencyInjection;

namespace ENPS.Util
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IBaseWrapper, BaseWrapper>();
        }
    }
}