
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAccountResponsePlan
    {
        /// <summary>
        /// The number of characters you are allowed to synthesize in this billing period.
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
        /// The number of instant voices you are allowed to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instant_voice_limit")]
        public int? InstantVoiceLimit { get; set; }

        /// <summary>
        /// The number of professional voices you are allowed to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voice_limit")]
        public int? ProfessionalVoiceLimit { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAccountResponsePlan" /> class.
        /// </summary>
        /// <param name="characterLimit">
        /// The number of characters you are allowed to synthesize in this billing period.
        /// </param>
        /// <param name="commercialUseAllowed"></param>
        /// <param name="type">
        /// The type of plan you are subscribed to.
        /// </param>
        /// <param name="instantVoiceLimit">
        /// The number of instant voices you are allowed to create.
        /// </param>
        /// <param name="professionalVoiceLimit">
        /// The number of professional voices you are allowed to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountResponsePlan(
            int characterLimit,
            bool commercialUseAllowed,
            string type,
            int? instantVoiceLimit,
            int? professionalVoiceLimit)
        {
            this.CharacterLimit = characterLimit;
            this.CommercialUseAllowed = commercialUseAllowed;
            this.InstantVoiceLimit = instantVoiceLimit;
            this.ProfessionalVoiceLimit = professionalVoiceLimit;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountResponsePlan" /> class.
        /// </summary>
        public GetAccountResponsePlan()
        {
        }

    }
}