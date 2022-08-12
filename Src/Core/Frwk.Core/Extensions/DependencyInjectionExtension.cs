using Frwk.Core.Interfaces;
using Frwk.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Frwk.Core.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void AddDependencyInjectionExtension(this IServiceCollection services)
        {
            services.AddScoped<IDecomposicao, Decomposicao>();
        }
    }
}
