#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// List voices<br/>
        /// Returns a list of voices available to you.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="starred">
        /// Default Value: false
        /// </param>
        /// <param name="owner">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LMNT.Voice>> ListAsync(
            string lmntVersion,
            string? starred = default,
            string? owner = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List voices<br/>
        /// Returns a list of voices available to you.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="starred">
        /// Default Value: false
        /// </param>
        /// <param name="owner">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LMNT.Voice>>> ListAsResponseAsync(
            string lmntVersion,
            string? starred = default,
            string? owner = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}