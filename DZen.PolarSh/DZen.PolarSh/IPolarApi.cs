using Refit;
using System;
using System.Threading.Tasks;

namespace DZen.PolarSh
{
    public interface IPolarApi
    {
        [Get("/v1/customers/{id}")]
        Task<CustomerState> GetCustomerStateAsync(string id);

        [Get("/v1/customers/external/{externalId}/state")]
        Task<CustomerState> GetCustomerStateByExternalIdAsync(string externalId);

        [Post("/v1/events/ingest")]
        [Obsolete("Currently ALPHA")]
        Task<object> PostEventAsync();

        [Get("/api/metered-route")]
        [Obsolete("Currently ALPHA")]
        Task SendEventAsync();
    }
}
