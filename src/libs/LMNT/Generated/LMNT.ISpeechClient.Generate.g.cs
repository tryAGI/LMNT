#nullable enable

namespace LMNT
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Generate speech<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateAsync(
            string lmntVersion,

            global::LMNT.StreamSpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GenerateAsStreamAsync(
            string lmntVersion,

            global::LMNT.StreamSpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<byte[]>> GenerateAsResponseAsync(
            string lmntVersion,

            global::LMNT.StreamSpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="voice">
        /// The voice id of the voice to use; voice ids can be retrieved by calls to `List voices` or `Voice info`.<br/>
        /// Example: leah
        /// </param>
        /// <param name="text">
        /// The text to generate speech from; max 5000 characters per request (including spaces).<br/>
        /// Example: Uhh, did you see the weather in Palo Alto tomorrow? Yeah, can't believe it's gonna rain, dude. Like what?
        /// </param>
        /// <param name="model">
        /// The model to use for speech generation. Learn more about models [here](https://docs.lmnt.com/models/overview).<br/>
        /// Default Value: blizzard
        /// </param>
        /// <param name="language">
        /// The desired language. Two letter ISO 639-1 code. Defaults to auto language detection, but specifying the language is recommended for faster generation.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="format">
        /// The desired output format of the audio. If you are using a streaming endpoint, you'll generate audio faster by selecting a streamable format since chunks are encoded and returned as they're generated. For non-streamable formats, all speech will be generated before encoding.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateAsync(
            string lmntVersion,
            string voice,
            string text,
            global::LMNT.Model? model = default,
            global::LMNT.LanguageCode? language = default,
            global::LMNT.OutputFormat? format = default,
            double? sampleRate = default,
            bool? debug = default,
            double? topP = default,
            double? temperature = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}