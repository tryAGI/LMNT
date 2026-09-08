
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRequest
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
        /// A list of tags to attach to this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </summary>
        /// <example>@input.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </summary>
        /// <example>@input.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="file">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="filename">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="tags">
        /// A list of tags to attach to this voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest(
            string name,
            byte[] file,
            string filename,
            string? gender,
            string? description,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Gender = gender;
            this.Description = description;
            this.Tags = tags;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        public CreateRequest()
        {
        }

    }
}