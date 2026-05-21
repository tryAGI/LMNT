#nullable enable

namespace LMNT
{
    public partial interface IVoiceClient
    {
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
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
        /// const voice = await client.voices.create({<br/>
        ///   enhance: false,<br/>
        ///   files: [fs.createReadStream('path/to/file')],<br/>
        ///   name: 'new-voice',<br/>
        /// });<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> CreateAiVoiceAsync(

            global::LMNT.CreateAiVoiceRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
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
        /// const voice = await client.voices.create({<br/>
        ///   enhance: false,<br/>
        ///   files: [fs.createReadStream('path/to/file')],<br/>
        ///   name: 'new-voice',<br/>
        /// });<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.Voice>> CreateAiVoiceAsResponseAsync(

            global::LMNT.CreateAiVoiceRequest request,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="enhance">
        /// For unclean audio with background noise, applies processing to attempt to improve quality. Default is `false` as this can also degrade quality in some circumstances.<br/>
        /// Example: false
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="files">
        /// One or more input audio files to train the voice in the form of binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachments.<br/>
        /// - Max attached files: 20.<br/>
        /// - Max total file size: 250 MB.<br/>
        /// Example: @/Users/user/file.wav
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> CreateAiVoiceAsync(
            string name,
            bool enhance,
            global::System.Collections.Generic.IList<byte[]> files,
            string? gender = default,
            string? description = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="enhance">
        /// For unclean audio with background noise, applies processing to attempt to improve quality. Default is `false` as this can also degrade quality in some circumstances.<br/>
        /// Example: false
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="files">
        /// One or more input audio files to train the voice in the form of binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachments.<br/>
        /// - Max attached files: 20.<br/>
        /// - Max total file size: 250 MB.<br/>
        /// Example: @/Users/user/file.wav
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const voice = await client.voices.create({<br/>
        ///   enhance: false,<br/>
        ///   files: [fs.createReadStream('path/to/file')],<br/>
        ///   name: 'new-voice',<br/>
        /// });<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.Voice> CreateAiVoiceAsync(
            string name,
            bool enhance,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            string? gender = default,
            string? description = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Submits a request to create a voice with a supplied voice configuration and a batch of input audio data.
        /// </summary>
        /// <param name="name">
        /// The display name for this voice<br/>
        /// Example: new-voice
        /// </param>
        /// <param name="enhance">
        /// For unclean audio with background noise, applies processing to attempt to improve quality. Default is `false` as this can also degrade quality in some circumstances.<br/>
        /// Example: false
        /// </param>
        /// <param name="gender">
        /// A tag describing the gender of this voice. Has no effect on voice creation.
        /// </param>
        /// <param name="description">
        /// A text description of this voice.
        /// </param>
        /// <param name="files">
        /// One or more input audio files to train the voice in the form of binary `wav`, `mp3`, `mp4`, `m4a`, or `webm` attachments.<br/>
        /// - Max attached files: 20.<br/>
        /// - Max total file size: 250 MB.<br/>
        /// Example: @/Users/user/file.wav
        /// </param>
        /// <param name="filesFileNames">
        /// Optional file names to use for the multipart 'files' file parts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LMNT.ApiException"></exception>
        /// <remarks>
        /// import Lmnt from 'lmnt-node';<br/>
        /// const client = new Lmnt({<br/>
        ///   apiKey: 'My API Key',<br/>
        /// });<br/>
        /// const voice = await client.voices.create({<br/>
        ///   enhance: false,<br/>
        ///   files: [fs.createReadStream('path/to/file')],<br/>
        ///   name: 'new-voice',<br/>
        /// });<br/>
        /// console.log(voice.id);
        /// </remarks>
        global::System.Threading.Tasks.Task<global::LMNT.AutoSDKHttpResponse<global::LMNT.Voice>> CreateAiVoiceAsResponseAsync(
            string name,
            bool enhance,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream> files,
            string? gender = default,
            string? description = default,
            global::System.Collections.Generic.IReadOnlyList<string>? filesFileNames = default,
            global::LMNT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}