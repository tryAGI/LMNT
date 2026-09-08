
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRequest
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
        /// Replaces the tags attached to this voice with the given list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest" /> class.
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
        /// <param name="tags">
        /// Replaces the tags attached to this voice with the given list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequest(
            string? description,
            string? gender,
            string? name,
            bool? starred,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Description = description;
            this.Gender = gender;
            this.Name = name;
            this.Starred = starred;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest" /> class.
        /// </summary>
        public UpdateRequest()
        {
        }

    }
}