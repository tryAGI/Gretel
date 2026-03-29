
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// User unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Current usage limits and quotas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_limits")]
        public object? ServiceLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="uid">
        /// User unique identifier
        /// </param>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="serviceLimits">
        /// Current usage limits and quotas
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            string? uid,
            string? email,
            string? firstname,
            string? lastname,
            string? username,
            string? avatarUrl,
            global::System.DateTime? createdAt,
            object? serviceLimits)
        {
            this.Uid = uid;
            this.Email = email;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.AvatarUrl = avatarUrl;
            this.CreatedAt = createdAt;
            this.ServiceLimits = serviceLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}