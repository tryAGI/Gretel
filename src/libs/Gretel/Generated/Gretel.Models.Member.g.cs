
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Member
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Permission level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        public int? Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="userId"></param>
        /// <param name="email"></param>
        /// <param name="level">
        /// Permission level
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Member(
            string? uid,
            string? userId,
            string? email,
            int? level)
        {
            this.Uid = uid;
            this.UserId = userId;
            this.Email = email;
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        public Member()
        {
        }
    }
}