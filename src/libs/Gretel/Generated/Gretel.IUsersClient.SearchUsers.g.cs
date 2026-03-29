#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Search users<br/>
        /// Search for users by text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.UserList> SearchUsersAsync(

            global::Gretel.SearchUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users<br/>
        /// Search for users by text.
        /// </summary>
        /// <param name="text">
        /// Search text
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.UserList> SearchUsersAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}