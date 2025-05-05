using Microsoft.Extensions.DependencyInjection;

namespace DZen.PolarSh
{
    public static class RegistrationExtensions
    {
        public static IServiceCollection RegisterPolar(this IServiceCollection services, string baseUrl)
        {
            IPolarApi api = Refit.RestService.For<IPolarApi>(baseUrl);
            services.AddSingleton(api);
            services.AddSingleton<IPolarClient, PolarClient>();
            return services;
        }
    }
}
