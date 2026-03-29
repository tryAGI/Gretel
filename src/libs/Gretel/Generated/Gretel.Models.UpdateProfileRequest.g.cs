
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProfileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfileRequest" /> class.
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProfileRequest(
            string? firstname,
            string? lastname,
            string? username)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfileRequest" /> class.
        /// </summary>
        public UpdateProfileRequest()
        {
        }
    }
}