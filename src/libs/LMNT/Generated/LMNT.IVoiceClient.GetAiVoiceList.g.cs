#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// List voices<br/>
        /// Returns a list of voices available to you.
        /// </summary>
        /// <param name="starred">
        /// Default Value: false
        /// </param>
        /// <param name="owner">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const voices = await client.voices.list();<br/>
        /// console.log(voices);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LMNT.Voice>> GetAiVoiceListAsync(
            string? starred = default,
            string? owner = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}