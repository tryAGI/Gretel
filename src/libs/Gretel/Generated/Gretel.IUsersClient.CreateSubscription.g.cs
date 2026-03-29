#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create or modify subscription<br/>
        /// Create or modify a subscription plan.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Subscription> CreateSubscriptionAsync(

            global::Gretel.CreateSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or modify subscription<br/>
        /// Create or modify a subscription plan.
        /// </summary>
        /// <param name="productId">
        /// Product ID for the subscription plan
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Subscription> CreateSubscriptionAsync(
            string productId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}