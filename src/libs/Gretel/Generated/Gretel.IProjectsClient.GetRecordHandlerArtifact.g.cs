#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get record handler artifact<br/>
        /// Download a record handler artifact such as generated data.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="handlerId"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ArtifactDownload> GetRecordHandlerArtifactAsync(
            string projectId,
            string modelId,
            string handlerId,
            global::Gretel.GetRecordHandlerArtifactType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}