
#nullable enable

namespace LMNT
{
    /// <summary>
    /// Voice details
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// A text description of this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A tag describing the gender of this voice, e.g. `male`, `female`, `nonbinary`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// The unique identifier of this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The display name of this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The owner of this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.VoiceOwnerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LMNT.VoiceOwner Owner { get; set; }

        /// <summary>
        /// Whether this voice has been starred by you or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred")]
        public bool? Starred { get; set; }

        /// <summary>
        /// The state of this voice in the training pipeline (e.g., `ready`, `training`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// The method by which this voice was created: `instant` or `professional`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.VoiceTypeJsonConverter))]
        public global::LMNT.VoiceType? Type { get; set; }

        /// <summary>
        /// A URL that returns a preview speech sample of this voice. The file can be played directly in a browser or audio player.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of this voice.
        /// </param>
        /// <param name="name">
        /// The display name of this voice.
        /// </param>
        /// <param name="owner">
        /// The owner of this voice.
        /// </param>
        /// <param name="state">
        /// The state of this voice in the training pipeline (e.g., `ready`, `training`).
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice, e.g. `male`, `female`, `nonbinary`.
        /// </param>
        /// <param name="starred">
        /// Whether this voice has been starred by you or not.
        /// </param>
        /// <param name="type">
        /// The method by which this voice was created: `instant` or `professional`.
        /// </param>
        /// <param name="previewUrl">
        /// A URL that returns a preview speech sample of this voice. The file can be played directly in a browser or audio player.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            string id,
            string name,
            global::LMNT.VoiceOwner owner,
            string state,
            string? description,
            string? gender,
            bool? starred,
            global::LMNT.VoiceType? type,
            string? previewUrl)
        {
            this.Description = description;
            this.Gender = gender;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner;
            this.Starred = starred;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Type = type;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }

    }
}