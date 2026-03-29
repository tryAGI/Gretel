#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List projects<br/>
        /// List all projects accessible to the authenticated user.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="withMembers"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ProjectList> ListProjectsAsync(
            int? limit = default,
            bool? withMembers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}