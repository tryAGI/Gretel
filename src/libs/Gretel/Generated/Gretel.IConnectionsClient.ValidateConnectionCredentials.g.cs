#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// Validate connection credentials<br/>
        /// Test that connection credentials are valid.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ValidationResult> ValidateConnectionCredentialsAsync(
            string connectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}