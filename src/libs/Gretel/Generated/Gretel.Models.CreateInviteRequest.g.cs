
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInviteRequest
    {
        /// <summary>
        /// Email address of the user to invite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Permission level (1=viewer, 2=member, 3=admin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Email address of the user to invite
        /// </param>
        /// <param name="level">
        /// Permission level (1=viewer, 2=member, 3=admin)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInviteRequest(
            string email,
            int level)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteRequest" /> class.
        /// </summary>
        public CreateInviteRequest()
        {
        }
    }
}