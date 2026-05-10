
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DurationObject
    {
        /// <summary>
        /// The synthesized input elements; beginning and ending with a short silence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The spoken duration of each synthesized input element, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The start time of each synthsized input element, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DurationObject" /> class.
        /// </summary>
        /// <param name="text">
        /// The synthesized input elements; beginning and ending with a short silence.
        /// </param>
        /// <param name="duration">
        /// The spoken duration of each synthesized input element, in seconds.
        /// </param>
        /// <param name="start">
        /// The start time of each synthsized input element, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DurationObject(
            string text,
            double duration,
            double start)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Duration = duration;
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DurationObject" /> class.
        /// </summary>
        public DurationObject()
        {
        }

    }
}