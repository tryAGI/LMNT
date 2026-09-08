
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetrieveResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LMNT.RetrieveResponsePlan Plan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LMNT.RetrieveResponseUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResponse" /> class.
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveResponse(
            global::LMNT.RetrieveResponsePlan plan,
            global::LMNT.RetrieveResponseUsage usage)
        {
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResponse" /> class.
        /// </summary>
        public RetrieveResponse()
        {
        }

    }
}