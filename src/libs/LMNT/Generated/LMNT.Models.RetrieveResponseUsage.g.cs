
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetrieveResponseUsage
    {
        /// <summary>
        /// The number of characters remaining in this billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResponseUsage" /> class.
        /// </summary>
        /// <param name="characters">
        /// The number of characters remaining in this billing period.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveResponseUsage(
            int characters)
        {
            this.Characters = characters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResponseUsage" /> class.
        /// </summary>
        public RetrieveResponseUsage()
        {
        }

    }
}