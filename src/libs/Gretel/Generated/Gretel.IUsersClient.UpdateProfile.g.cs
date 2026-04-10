#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update your profile<br/>
        /// Update the authenticated user's profile.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.User> UpdateProfileAsync(

            global::Gretel.UpdateProfileRequest request,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update your profile<br/>
        /// Update the authenticated user's profile.
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.User> UpdateProfileAsync(
            string? firstname = default,
            string? lastname = default,
            string? username = default,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}