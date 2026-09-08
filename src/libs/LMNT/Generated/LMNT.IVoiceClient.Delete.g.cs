#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Delete voice<br/>
        /// Deletes a voice and cancels any pending operations on it. Cannot be undone.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lmntVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.DeleteResponse> DeleteAsync(
            string id,
            string lmntVersion,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete voice<br/>
        /// Deletes a voice and cancels any pending operations on it. Cannot be undone.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lmntVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.DeleteResponse>> DeleteAsResponseAsync(
            string id,
            string lmntVersion,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}