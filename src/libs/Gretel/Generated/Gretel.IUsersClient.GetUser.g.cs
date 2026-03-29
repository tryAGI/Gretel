#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user<br/>
        /// Get a user's profile by ID.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.User> GetUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}