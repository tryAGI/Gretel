
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingData
    {
        /// <summary>
        /// Current plan name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::Gretel.Subscription? Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_methods")]
        public global::System.Collections.Generic.IList<object>? PaymentMethods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public object? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingData" /> class.
        /// </summary>
        /// <param name="plan">
        /// Current plan name
        /// </param>
        /// <param name="subscription"></param>
        /// <param name="paymentMethods"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingData(
            string? plan,
            global::Gretel.Subscription? subscription,
            global::System.Collections.Generic.IList<object>? paymentMethods,
            object? usage)
        {
            this.Plan = plan;
            this.Subscription = subscription;
            this.PaymentMethods = paymentMethods;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingData" /> class.
        /// </summary>
        public BillingData()
        {
        }
    }
}