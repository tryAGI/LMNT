#nullable enable

namespace LMNT
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Generate speech (JSON with metadata)<br/>
        /// Generates speech from text and returns a JSON object that contains a **base64-encoded audio string** and optionally word-level durations (timestamps).<br/>
        /// This endpoint waits for the entire synthesis before responding, so it is not ideal for latency-sensitive applications.
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
        /// const response = await client.speech.generateDetailed({ text: 'hello world.', voice: 'leah' });<br/>
        /// console.log(response.audio);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.CreateAiSpeechResponse> CreateAiSpeechAsync(

            global::LMNT.SpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech (JSON with metadata)<br/>
        /// Generates speech from text and returns a JSON object that contains a **base64-encoded audio string** and optionally word-level durations (timestamps).<br/>
        /// This endpoint waits for the entire synthesis before responding, so it is not ideal for latency-sensitive applications.
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
        /// const response = await client.speech.generateDetailed({ text: 'hello world.', voice: 'leah' });<br/>
        /// console.log(response.audio);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.CreateAiSpeechResponse>> CreateAiSpeechAsResponseAsync(

            global::LMNT.SpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech (JSON with metadata)<br/>
        /// Generates speech from text and returns a JSON object that contains a **base64-encoded audio string** and optionally word-level durations (timestamps).<br/>
        /// This endpoint waits for the entire synthesis before responding, so it is not ideal for latency-sensitive applications.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.CreateAiSpeechResponse> CreateAiSpeechAsync(
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}