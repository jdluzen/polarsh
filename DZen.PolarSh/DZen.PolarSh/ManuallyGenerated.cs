using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DZen.PolarSh
{
    public class ActiveMeter
    {
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonPropertyName("meter_id")]
        public string MeterId { get; set; }

        [JsonPropertyName("consumed_units")]
        public int ConsumedUnits { get; set; }

        [JsonPropertyName("credited_units")]
        public int CreditedUnits { get; set; }

        [JsonPropertyName("balance")]
        public int Balance { get; set; }
    }

    public class ActiveSubscription
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonPropertyName("custom_field_data")]
        public CustomFieldData CustomFieldData { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("recurring_interval")]
        public string RecurringInterval { get; set; }

        [JsonPropertyName("current_period_start")]
        public DateTime CurrentPeriodStart { get; set; }

        [JsonPropertyName("current_period_end")]
        public DateTime CurrentPeriodEnd { get; set; }

        [JsonPropertyName("cancel_at_period_end")]
        public bool CancelAtPeriodEnd { get; set; }

        [JsonPropertyName("canceled_at")]
        public object CanceledAt { get; set; }

        [JsonPropertyName("started_at")]
        public DateTime StartedAt { get; set; }

        [JsonPropertyName("ends_at")]
        public object EndsAt { get; set; }

        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        [JsonPropertyName("discount_id")]
        public object DiscountId { get; set; }

        [JsonPropertyName("meters")]
        public List<Meter> Meters { get; set; }
    }

    public class BillingAddress
    {
        [JsonPropertyName("line1")]
        public string Line1 { get; set; }

        [JsonPropertyName("line2")]
        public string Line2 { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class CustomFieldData
    {
    }

    public class GrantedBenefit
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonPropertyName("granted_at")]
        public DateTime GrantedAt { get; set; }

        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        [JsonPropertyName("benefit_type")]
        public string BenefitType { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class Meter
    {
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("consumed_units")]
        public int ConsumedUnits { get; set; }

        [JsonPropertyName("credited_units")]
        public int CreditedUnits { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("meter_id")]
        public string MeterId { get; set; }
    }

    public class Properties
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        [JsonPropertyName("guild_id")]
        public string GuildId { get; set; }

        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }

    public class CustomerState
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        [JsonPropertyName("tax_id")]
        public List<string> TaxId { get; set; }

        [JsonPropertyName("organization_id")]
        public string OrganizationId { get; set; }

        [JsonPropertyName("deleted_at")]
        public DateTime DeletedAt { get; set; }

        [JsonPropertyName("active_subscriptions")]
        public List<ActiveSubscription> ActiveSubscriptions { get; set; }

        [JsonPropertyName("granted_benefits")]
        public List<GrantedBenefit> GrantedBenefits { get; set; }

        [JsonPropertyName("active_meters")]
        public List<ActiveMeter> ActiveMeters { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }
    }

    public class UsageEvent
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("customer_id")]
        public string CustomerId { get; set; }

        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, object> Metadata { get; set; }
    }
}
