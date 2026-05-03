
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAccountResponseUsage
    {
        /// <summary>
        /// The number of characters you have synthesized in this billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Characters { get; set; }

        /// <summary>
        /// The number of instant voices you have created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instant_voices")]
        public int? InstantVoices { get; set; }

        /// <summary>
        /// The number of professional voices you have created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProfessionalVoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountResponseUsage" /> class.
        /// </summary>
        /// <param name="characters">
        /// The number of characters you have synthesized in this billing period.
        /// </param>
        /// <param name="professionalVoices">
        /// The number of professional voices you have created.
        /// </param>
        /// <param name="instantVoices">
        /// The number of instant voices you have created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountResponseUsage(
            int characters,
            int professionalVoices,
            int? instantVoices)
        {
            this.Characters = characters;
            this.InstantVoices = instantVoices;
            this.ProfessionalVoices = professionalVoices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountResponseUsage" /> class.
        /// </summary>
        public GetAccountResponseUsage()
        {
        }
    }
}