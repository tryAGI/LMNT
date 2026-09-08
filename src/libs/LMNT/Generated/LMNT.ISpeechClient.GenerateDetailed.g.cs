#nullable enable

namespace LMNT
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Generate speech with timestamps<br/>
        /// Generates speech from text and returns a JSON object that contains a base64-encoded audio string and optionally word-level timestamps.<br/>
        /// This endpoint waits for all speech to be generated before responding, so it is not ideal for latency-sensitive applications.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.GenerateDetailedResponse> GenerateDetailedAsync(
            string lmntVersion,

            global::LMNT.SpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech with timestamps<br/>
        /// Generates speech from text and returns a JSON object that contains a base64-encoded audio string and optionally word-level timestamps.<br/>
        /// This endpoint waits for all speech to be generated before responding, so it is not ideal for latency-sensitive applications.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.GenerateDetailedResponse>> GenerateDetailedAsResponseAsync(
            string lmntVersion,

            global::LMNT.SpeechRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech with timestamps<br/>
        /// Generates speech from text and returns a JSON object that contains a base64-encoded audio string and optionally word-level timestamps.<br/>
        /// This endpoint waits for all speech to be generated before responding, so it is not ideal for latency-sensitive applications.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.GenerateDetailedResponse> GenerateDetailedAsync(
            string lmntVersion,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}