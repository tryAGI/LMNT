#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Update voice<br/>
        /// Updates metadata for a specific voice. Only provided fields will be changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const voice = await client.voices.update('123');<br/>
        /// console.log(voice.voice);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.PutAiVoiceResponse> PutAiVoiceByIdAsync(
            string id,

            global::LMNT.PutAiVoiceRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice<br/>
        /// Updates metadata for a specific voice. Only provided fields will be changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const voice = await client.voices.update('123');<br/>
        /// console.log(voice.voice);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.PutAiVoiceResponse>> PutAiVoiceByIdAsResponseAsync(
            string id,

            global::LMNT.PutAiVoiceRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice<br/>
        /// Updates metadata for a specific voice. Only provided fields will be changed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description">
        /// A description of this voice.
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice, e.g. `male`, `female`, `nonbinary`.
        /// </param>
        /// <param name="name">
        /// The display name for this voice.
        /// </param>
        /// <param name="starred">
        /// If `true`, adds this voice to your starred list.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.PutAiVoiceResponse> PutAiVoiceByIdAsync(
            string id,
            string? description = default,
            string? gender = default,
            string? name = default,
            bool? starred = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}