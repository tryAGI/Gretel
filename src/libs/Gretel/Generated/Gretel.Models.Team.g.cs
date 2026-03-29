
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Team
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_guid")]
        public string? DomainGuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Gretel.User>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="domainGuid"></param>
        /// <param name="name"></param>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Team(
            string? domainGuid,
            string? name,
            global::System.Collections.Generic.IList<global::Gretel.User>? members)
        {
            this.DomainGuid = domainGuid;
            this.Name = name;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        public Team()
        {
        }
    }
}