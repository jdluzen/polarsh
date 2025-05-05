using System;
using System.Threading.Tasks;

namespace DZen.PolarSh
{
    public class PolarClient : IPolarClient
    {
        public const string ProductionUrl = "https://api.polar.sh";
        public const string SandboxUrl = "https://sandbox-api.polar.sh";
        private readonly IPolarApi api;

        public PolarClient(IPolarApi api)
        {
            this.api = api;
        }

        public async Task<bool> SendUsageAsync(UsageEvent usage)
        {
            ValidateCustomerOrExternalCustomerId(usage);
            return false;
        }

        protected virtual bool ValidateCustomerOrExternalCustomerId(UsageEvent usage)
        {
            if (string.IsNullOrWhiteSpace(usage.CustomerId) && string.IsNullOrWhiteSpace(usage.ExternalCustomerId))
            {
                throw new ArgumentException("CustomerId or ExternalCustomerId must have a value");
            }
            return true;
        }
    }
}
