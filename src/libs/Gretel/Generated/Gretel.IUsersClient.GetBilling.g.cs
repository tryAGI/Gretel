#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get billing data<br/>
        /// Get billing information for the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.BillingData> GetBillingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}