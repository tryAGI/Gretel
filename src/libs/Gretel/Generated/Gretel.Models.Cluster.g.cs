
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Cluster
    {
        /// <summary>
        /// Cluster unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_provider")]
        public string? CloudProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        /// <param name="id">
        /// Cluster unique identifier
        /// </param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="ownerId"></param>
        /// <param name="cloudProvider"></param>
        /// <param name="region"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cluster(
            string? id,
            string? name,
            string? status,
            string? ownerId,
            string? cloudProvider,
            string? region,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.OwnerId = ownerId;
            this.CloudProvider = cloudProvider;
            this.Region = region;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cluster" /> class.
        /// </summary>
        public Cluster()
        {
        }
    }
}