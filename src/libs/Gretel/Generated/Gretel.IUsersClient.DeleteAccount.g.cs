#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete your account<br/>
        /// Delete the authenticated user's account.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteAccountAsync(
            global::Gretel.DeleteAccountDryRun? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}