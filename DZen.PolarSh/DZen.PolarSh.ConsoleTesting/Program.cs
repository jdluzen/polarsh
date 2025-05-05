using Microsoft.Extensions.DependencyInjection;

namespace DZen.PolarSh.ConsoleTesting
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.RegisterPolar(PolarClient.SandboxUrl);
            await RunAsync(services.BuildServiceProvider().GetRequiredService<IPolarClient>());
        }

        private static async Task RunAsync(IPolarClient polar)
        {
            await polar.SendUsageAsync(new UsageEvent
            {
                CustomerId = "",
                Name = ""
            });
        }
    }
}
