
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamSpeechRequest
    {
        /// <summary>
        /// The voice id of the voice to use; voice ids can be retrieved by calls to `List voices` or `Voice info`.<br/>
        /// Example: leah
        /// </summary>
        /// <example>leah</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// The text to synthesize; max 5000 characters per request (including spaces).<br/>
        /// Example: hello world.
        /// </summary>
        /// <example>hello world.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The model to use for synthesis. Learn more about models [here](https://docs.lmnt.com/guides/models).<br/>
        /// Default Value: blizzard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.ModelJsonConverter))]
        public global::LMNT.Model? Model { get; set; }

        /// <summary>
        /// The desired language. Two letter ISO 639-1 code. Defaults to auto language detection, but specifying the language is recommended for faster generation.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.LanguageCodeJsonConverter))]
        public global::LMNT.LanguageCode? Language { get; set; }

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
        /// Seed used to specify a different take; defaults to random
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// When set to true, the generated speech will also be saved to your [clip library](https://app.lmnt.com/clips) in the LMNT playground.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public bool? Debug { get; set; }

        /// <summary>
        /// Controls the stability of the generated speech. A lower value (like 0.3) produces more consistent, reliable speech. A higher value (like 0.9) gives more flexibility in how words are spoken, but might occasionally produce unusual intonations or speech patterns.<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Influences how expressive and emotionally varied the speech becomes. Lower values (like 0.3) create more neutral, consistent speaking styles. Higher values (like 1.0) allow for more dynamic emotional range and speaking styles.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSpeechRequest" /> class.
        /// </summary>
        /// <param name="voice">
        /// The voice id of the voice to use; voice ids can be retrieved by calls to `List voices` or `Voice info`.<br/>
        /// Example: leah
        /// </param>
        /// <param name="text">
        /// The text to synthesize; max 5000 characters per request (including spaces).<br/>
        /// Example: hello world.
        /// </param>
        /// <param name="model">
        /// The model to use for synthesis. Learn more about models [here](https://docs.lmnt.com/guides/models).<br/>
        /// Default Value: blizzard
        /// </param>
        /// <param name="language">
        /// The desired language. Two letter ISO 639-1 code. Defaults to auto language detection, but specifying the language is recommended for faster generation.<br/>
        /// Default Value: auto
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
        /// <param name="seed">
        /// Seed used to specify a different take; defaults to random
        /// </param>
        /// <param name="debug">
        /// When set to true, the generated speech will also be saved to your [clip library](https://app.lmnt.com/clips) in the LMNT playground.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topP">
        /// Controls the stability of the generated speech. A lower value (like 0.3) produces more consistent, reliable speech. A higher value (like 0.9) gives more flexibility in how words are spoken, but might occasionally produce unusual intonations or speech patterns.<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="temperature">
        /// Influences how expressive and emotionally varied the speech becomes. Lower values (like 0.3) create more neutral, consistent speaking styles. Higher values (like 1.0) allow for more dynamic emotional range and speaking styles.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamSpeechRequest(
            string voice,
            string text,
            global::LMNT.Model? model,
            global::LMNT.LanguageCode? language,
            global::LMNT.OutputFormat? format,
            double? sampleRate,
            int? seed,
            bool? debug,
            double? topP,
            double? temperature)
        {
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Model = model;
            this.Language = language;
            this.Format = format;
            this.SampleRate = sampleRate;
            this.Seed = seed;
            this.Debug = debug;
            this.TopP = topP;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSpeechRequest" /> class.
        /// </summary>
        public StreamSpeechRequest()
        {
        }
    }
}