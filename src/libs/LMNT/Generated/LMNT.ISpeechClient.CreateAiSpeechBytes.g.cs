#nullable enable

namespace LMNT
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Generate speech (binary stream)<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const response = await client.speech.generate({ text: 'hello world.', voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateAiSpeechBytesAsync(

            global::LMNT.StreamSpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech (binary stream)<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const response = await client.speech.generate({ text: 'hello world.', voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateAiSpeechBytesAsStreamAsync(

            global::LMNT.StreamSpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech (binary stream)<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const response = await client.speech.generate({ text: 'hello world.', voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<byte[]>> CreateAiSpeechBytesAsResponseAsync(

            global::LMNT.StreamSpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech (binary stream)<br/>
        /// Generates speech from text and streams the audio as binary data chunks in real-time as they are generated.<br/>
        /// This is the recommended endpoint for most text-to-speech use cases. You can either stream the chunks for low-latency playback or collect all chunks to get the complete audio file.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateAiSpeechBytesAsync(
            string voice,
            string text,
            global::LMNT.Model? model = default,
            global::LMNT.LanguageCode? language = default,
            global::LMNT.OutputFormat? format = default,
            double? sampleRate = default,
            int? seed = default,
            bool? debug = default,
            double? topP = default,
            double? temperature = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}