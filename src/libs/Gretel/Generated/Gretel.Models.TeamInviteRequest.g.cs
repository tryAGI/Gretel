
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamInviteRequest
    {
        /// <summary>
        /// Team domain GUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_guid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DomainGuid { get; set; }

        /// <summary>
        /// Email of the user to invite or remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteRequest" /> class.
        /// </summary>
        /// <param name="domainGuid">
        /// Team domain GUID
        /// </param>
        /// <param name="userEmail">
        /// Email of the user to invite or remove
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamInviteRequest(
            string domainGuid,
            string userEmail)
        {
            this.DomainGuid = domainGuid ?? throw new global::System.ArgumentNullException(nameof(domainGuid));
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteRequest" /> class.
        /// </summary>
        public TeamInviteRequest()
        {
        }
    }
}