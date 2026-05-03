
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAiSpeechConvertRequest
    {
        /// <summary>
        /// The audio file to be converted into a new voice. Specify source language using the `language` parameter. Acceptable formats: `wav`, `mp3`. Max file size: 1 MB.<br/>
        /// Example: @/Users/user/file1.wav
        /// </summary>
        /// <example>@/Users/user/file1.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Audio { get; set; }

        /// <summary>
        /// The audio file to be converted into a new voice. Specify source language using the `language` parameter. Acceptable formats: `wav`, `mp3`. Max file size: 1 MB.<br/>
        /// Example: @/Users/user/file1.wav
        /// </summary>
        /// <example>@/Users/user/file1.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audioname { get; set; }

        /// <summary>
        /// The voice id of the voice to use; voice ids can be retrieved by calls to `List voices` or `Voice info`.<br/>
        /// Example: leah
        /// </summary>
        /// <example>leah</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// The desired output format of the audio. If you are using a streaming endpoint, you'll generate audio faster by selecting a streamable format since chunks are encoded and returned as they're generated. For non-streamable formats, the entire audio will be synthesized before encoding.<br/>
        /// Streamable formats:<br/>
        /// - `mp3`: 96kbps MP3 audio.<br/>
        /// - `ulaw`: 8-bit G711 µ-law audio with a WAV header.<br/>
        /// - `webm`: WebM format with Opus audio codec.<br/>
        /// - `pcm_s16le`: PCM signed 16-bit little-endian audio.<br/>
        /// - `pcm_f32le`: PCM 32-bit floating-point little-endian audio.<br/>
        /// Non-streamable formats:<br/>
        /// - `aac`: AAC audio codec.<br/>
        /// - `wav`: 16-bit PCM audio in WAV container.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.OutputFormatJsonConverter))]
        public global::LMNT.OutputFormat? Format { get; set; }

        /// <summary>
        /// The desired output sample rate in Hz. Defaults to `24000` for all formats except `mulaw` which defaults to `8000`.<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// The desired language. Two letter ISO 639-1 code. Defaults to auto language detection, but specifying the language is recommended for faster generation.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.LanguageCodeJsonConverter))]
        public global::LMNT.LanguageCode? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiSpeechConvertRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// The audio file to be converted into a new voice. Specify source language using the `language` parameter. Acceptable formats: `wav`, `mp3`. Max file size: 1 MB.<br/>
        /// Example: @/Users/user/file1.wav
        /// </param>
        /// <param name="audioname">
        /// The audio file to be converted into a new voice. Specify source language using the `language` parameter. Acceptable formats: `wav`, `mp3`. Max file size: 1 MB.<br/>
        /// Example: @/Users/user/file1.wav
        /// </param>
        /// <param name="voice">
        /// The voice id of the voice to use; voice ids can be retrieved by calls to `List voices` or `Voice info`.<br/>
        /// Example: leah
        /// </param>
        /// <param name="format">
        /// The desired output format of the audio. If you are using a streaming endpoint, you'll generate audio faster by selecting a streamable format since chunks are encoded and returned as they're generated. For non-streamable formats, the entire audio will be synthesized before encoding.<br/>
        /// Streamable formats:<br/>
        /// - `mp3`: 96kbps MP3 audio.<br/>
        /// - `ulaw`: 8-bit G711 µ-law audio with a WAV header.<br/>
        /// - `webm`: WebM format with Opus audio codec.<br/>
        /// - `pcm_s16le`: PCM signed 16-bit little-endian audio.<br/>
        /// - `pcm_f32le`: PCM 32-bit floating-point little-endian audio.<br/>
        /// Non-streamable formats:<br/>
        /// - `aac`: AAC audio codec.<br/>
        /// - `wav`: 16-bit PCM audio in WAV container.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// The desired output sample rate in Hz. Defaults to `24000` for all formats except `mulaw` which defaults to `8000`.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="language">
        /// The desired language. Two letter ISO 639-1 code. Defaults to auto language detection, but specifying the language is recommended for faster generation.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiSpeechConvertRequest(
            byte[] audio,
            string audioname,
            string voice,
            global::LMNT.OutputFormat? format,
            double? sampleRate,
            global::LMNT.LanguageCode? language)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Audioname = audioname ?? throw new global::System.ArgumentNullException(nameof(audioname));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Format = format;
            this.SampleRate = sampleRate;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiSpeechConvertRequest" /> class.
        /// </summary>
        public CreateAiSpeechConvertRequest()
        {
        }
    }
}