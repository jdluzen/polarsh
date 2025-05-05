using System.Threading.Tasks;

namespace DZen.PolarSh
{
    public interface IPolarClient
    {
        Task<bool> SendUsageAsync(UsageEvent usage);
    }
}