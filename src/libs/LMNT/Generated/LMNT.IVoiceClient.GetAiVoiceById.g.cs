#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Voice info<br/>
        /// Returns details of a specific voice.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const voice = await client.voices.retrieve('123');<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> GetAiVoiceByIdAsync(
            string id,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}