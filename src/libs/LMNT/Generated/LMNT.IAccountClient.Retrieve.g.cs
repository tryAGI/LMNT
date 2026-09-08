#nullable enable

namespace LMNT
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Retrieve account<br/>
        /// Returns details about your account.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.RetrieveResponse> RetrieveAsync(
            string lmntVersion,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve account<br/>
        /// Returns details about your account.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.RetrieveResponse>> RetrieveAsResponseAsync(
            string lmntVersion,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}