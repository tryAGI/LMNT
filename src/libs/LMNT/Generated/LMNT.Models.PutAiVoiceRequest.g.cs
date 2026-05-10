
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutAiVoiceRequest
    {
        /// <summary>
        /// A description of this voice. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A tag describing the gender of this voice, e.g. `male`, `female`, `nonbinary`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// The display name for this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If `true`, adds this voice to your starred list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred")]
        public bool? Starred { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAiVoiceRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of this voice. 
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice, e.g. `male`, `female`, `nonbinary`.
        /// </param>
        /// <param name="name">
        /// The display name for this voice.
        /// </param>
        /// <param name="starred">
        /// If `true`, adds this voice to your starred list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAiVoiceRequest(
            string? description,
            string? gender,
            string? name,
            bool? starred)
        {
            this.Description = description;
            this.Gender = gender;
            this.Name = name;
            this.Starred = starred;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAiVoiceRequest" /> class.
        /// </summary>
        public PutAiVoiceRequest()
        {
        }

    }
}