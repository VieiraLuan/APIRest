

using Microsoft.Extensions.DependencyInjection;
using TemplateApplication.Interfaces;
using TemplateApplication.Services;
using TemplateData.Repositories;
using TemplateDomain.Interfaces;

namespace TemplateIoc
{
    public static class NativeInjector
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IUsuarioServices, UsuarioServices>();
            #endregion

            #region Repositories

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            #endregion
        }
    }
}
