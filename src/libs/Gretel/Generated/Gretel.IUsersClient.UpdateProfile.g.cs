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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.User> UpdateProfileAsync(

            global::Gretel.UpdateProfileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update your profile<br/>
        /// Update the authenticated user's profile.
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.User> UpdateProfileAsync(
            string? firstname = default,
            string? lastname = default,
            string? username = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}