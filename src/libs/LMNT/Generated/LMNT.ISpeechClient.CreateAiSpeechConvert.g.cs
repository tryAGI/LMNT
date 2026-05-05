#nullable enable

namespace LMNT
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// const response = await client.speech.convert({ audio: fs.createReadStream('path/to/file'), voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateAiSpeechConvertAsync(

            global::LMNT.CreateAiSpeechConvertRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// const response = await client.speech.convert({ audio: fs.createReadStream('path/to/file'), voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateAiSpeechConvertAsStreamAsync(

            global::LMNT.CreateAiSpeechConvertRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// const response = await client.speech.convert({ audio: fs.createReadStream('path/to/file'), voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<byte[]>> CreateAiSpeechConvertAsResponseAsync(

            global::LMNT.CreateAiSpeechConvertRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateAiSpeechConvertAsync(
            byte[] audio,
            string audioname,
            string voice,
            global::LMNT.OutputFormat? format = default,
            double? sampleRate = default,
            global::LMNT.LanguageCode? language = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const response = await client.speech.convert({ audio: fs.createReadStream('path/to/file'), voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<byte[]> CreateAiSpeechConvertAsync(
            global::System.IO.Stream audio,
            string audioname,
            string voice,
            global::LMNT.OutputFormat? format = default,
            double? sampleRate = default,
            global::LMNT.LanguageCode? language = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const response = await client.speech.convert({ audio: fs.createReadStream('path/to/file'), voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateAiSpeechConvertAsStreamAsync(
            global::System.IO.Stream audio,
            string audioname,
            string voice,
            global::LMNT.OutputFormat? format = default,
            double? sampleRate = default,
            global::LMNT.LanguageCode? language = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert audio using a specific voice<br/>
        /// Converts speech from one voice to another.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const response = await client.speech.convert({ audio: fs.createReadStream('path/to/file'), voice: 'leah' });<br/>
        /// console.log(response);<br/>
        /// const content = await response.blob();<br/>
        /// console.log(content);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<byte[]>> CreateAiSpeechConvertAsResponseAsync(
            global::System.IO.Stream audio,
            string audioname,
            string voice,
            global::LMNT.OutputFormat? format = default,
            double? sampleRate = default,
            global::LMNT.LanguageCode? language = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}