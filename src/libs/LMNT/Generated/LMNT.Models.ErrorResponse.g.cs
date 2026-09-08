
#nullable enable

namespace LMNT
{
    /// <summary>
    /// The shape of every non-2xx response body.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Discriminator. Always `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LMNT.JsonConverters.ErrorResponseTypeJsonConverter))]
        public global::LMNT.ErrorResponseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LMNT.ErrorResponseError Error { get; set; }

        /// <summary>
        /// The unique identifier for the request that produced this error. Echoed by the `request-id` response header.<br/>
        /// Example: req_NCwcMfUDpDJoBg7QaMnYRk
        /// </summary>
        /// <example>req_NCwcMfUDpDJoBg7QaMnYRk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId">
        /// The unique identifier for the request that produced this error. Echoed by the `request-id` response header.<br/>
        /// Example: req_NCwcMfUDpDJoBg7QaMnYRk
        /// </param>
        /// <param name="type">
        /// Discriminator. Always `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            global::LMNT.ErrorResponseError error,
            string requestId,
            global::LMNT.ErrorResponseType type)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }

    }
}