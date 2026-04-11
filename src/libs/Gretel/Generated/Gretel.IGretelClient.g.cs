
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Gretel.ai REST API for privacy-preserving synthetic data generation, data classification, and data transformation. These APIs allow you to ingest data to Gretel and explore the data Gretel is able to extract.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IGretelClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Gretel.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Gretel.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Activity logs and search.
        /// </summary>
        public ActivityClient Activity { get; }

        /// <summary>
        /// Compute cluster management.
        /// </summary>
        public ClustersClient Clusters { get; }

        /// <summary>
        /// Manage data source and destination connections.
        /// </summary>
        public ConnectionsClient Connections { get; }

        /// <summary>
        /// Log retrieval.
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// Manage projects, artifacts, models, and record handlers.
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// User management, billing, teams, and invites.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Create and manage data generation workflows.
        /// </summary>
        public WorkflowsClient Workflows { get; }

    }
}