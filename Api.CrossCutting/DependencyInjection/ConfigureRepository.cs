using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddDbContext<SqlContext>(
                options => options.UseSqlServer("Server=localhost,1433;Database=taskManager;Uid=sa;Pwd=Sqlsa!23")
            );
        }
    }
}
