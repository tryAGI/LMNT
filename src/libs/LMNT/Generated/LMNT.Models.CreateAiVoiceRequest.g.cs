
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAiVoiceRequest
    {
        /// <summary>
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </summary>
        /// <example>new-voice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// For unclean audio with background noise, applies processing to attempt to improve quality. Default is `false` as this can also degrade quality in some circumstances.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enhance { get; set; }

        /// <summary>
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// A text description of this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// One or more input audio files to train the voice in the form of binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachments.<br/>
        /// - Max attached files: 20.<br/>
        /// - Max total file size: 250 MB.<br/>
        /// Example: @/Users/user/file.wav
        /// </summary>
        /// <example>@/Users/user/file.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiVoiceRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="enhance">
        /// For unclean audio with background noise, applies processing to attempt to improve quality. Default is `false` as this can also degrade quality in some circumstances.<br/>
        /// Example: false
        /// </param>
        /// <param name="files">
        /// One or more input audio files to train the voice in the form of binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachments.<br/>
        /// - Max attached files: 20.<br/>
        /// - Max total file size: 250 MB.<br/>
        /// Example: @/Users/user/file.wav
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiVoiceRequest(
            string name,
            bool enhance,
            global::System.Collections.Generic.IList<byte[]> files,
            string? gender,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enhance = enhance;
            this.Gender = gender;
            this.Description = description;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiVoiceRequest" /> class.
        /// </summary>
        public CreateAiVoiceRequest()
        {
        }
    }
}