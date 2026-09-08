
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetrieveResponsePlan
    {
        /// <summary>
        /// The maximum number of characters per billing period allowed by your plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharacterLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commercial_use_allowed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CommercialUseAllowed { get; set; }

        /// <summary>
        /// The type of plan you are subscribed to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResponsePlan" /> class.
        /// </summary>
        /// <param name="characterLimit">
        /// The maximum number of characters per billing period allowed by your plan.
        /// </param>
        /// <param name="commercialUseAllowed"></param>
        /// <param name="type">
        /// The type of plan you are subscribed to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveResponsePlan(
            int characterLimit,
            bool commercialUseAllowed,
            string type)
        {
            this.CharacterLimit = characterLimit;
            this.CommercialUseAllowed = commercialUseAllowed;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveResponsePlan" /> class.
        /// </summary>
        public RetrieveResponsePlan()
        {
        }

    }
}