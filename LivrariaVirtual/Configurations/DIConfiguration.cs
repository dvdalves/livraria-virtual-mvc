using AdmCrmProver.Business.Service;
using LivrariaVirtual.Business.Interface;
using LivrariaVirtual.Business.Services;
using LivrariaVirtual.Data.Data;
using LivrariaVirtual.Data.Interface;
using LivrariaVirtual.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace LivrariaVirtual.Configurations
{
    public static class DIConfiguration
    {
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<ILivroCategoriaRepository, LivroCategoriaRepository>();
            services.AddScoped<ILivroCategoriaService, LivroCategoriaService>();
            services.AddScoped<ILivroAvaliacaoRepository, LivroAvaliacaoRepository>();
            services.AddScoped<ILivroAvaliacaoService, LivroAvaliacaoService>();
            services.AddScoped<ILivroAutorRepository, LivroAutorRepository>();
            services.AddScoped<ILivroAutorService, LivroAutorService>();

            services.AddAutoMapper(typeof(Program));
        }

        public static IServiceCollection ConfigureDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                                                options.UseSqlServer(configuration
                                                    .GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
