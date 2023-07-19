using Clinica.Interface;
using Clinica.Repositories;
using Clinica.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Clinica
{
    public static class IoC
    {
        public static void AddDependencyInjection(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<IMedicoService, MedicoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            
            services.AddAutoMapper(typeof(Mapping));
        }
    }
}
