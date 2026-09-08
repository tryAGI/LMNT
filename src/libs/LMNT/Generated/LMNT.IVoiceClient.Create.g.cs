#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> CreateAsync(
            string lmntVersion,

            global::LMNT.CreateRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.Voice>> CreateAsResponseAsync(
            string lmntVersion,

            global::LMNT.CreateRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="tags">
        /// A list of tags to attach to this voice.
        /// </param>
        /// <param name="file">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="filename">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> CreateAsync(
            string lmntVersion,
            string name,
            byte[] file,
            string filename,
            string? gender = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="tags">
        /// A list of tags to attach to this voice.
        /// </param>
        /// <param name="file">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="filename">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> CreateAsync(
            string lmntVersion,
            string name,
            global::System.IO.Stream file,
            string filename,
            string? gender = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="lmntVersion"></param>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="tags">
        /// A list of tags to attach to this voice.
        /// </param>
        /// <param name="file">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="filename">
        /// The input audio file to train the voice with, as a binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachment.<br/>
        /// - Max file size: 250 MB.<br/>
        /// Example: @input.mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.Voice>> CreateAsResponseAsync(
            string lmntVersion,
            string name,
            global::System.IO.Stream file,
            string filename,
            string? gender = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}