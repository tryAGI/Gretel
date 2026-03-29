
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSubscriptionRequest
    {
        /// <summary>
        /// Product ID for the subscription plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="productId">
        /// Product ID for the subscription plan
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSubscriptionRequest(
            string productId)
        {
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        public CreateSubscriptionRequest()
        {
        }
    }
}