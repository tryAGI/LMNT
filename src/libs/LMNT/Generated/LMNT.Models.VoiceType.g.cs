
#nullable enable

namespace LMNT
{
    /// <summary>
    /// The method by which this voice was created: `instant` or `professional`.
    /// </summary>
    public enum VoiceType
    {
        /// <summary>
        /// `instant` or `professional`.
        /// </summary>
        Instant,
        /// <summary>
        /// `instant` or `professional`.
        /// </summary>
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceType value)
        {
            return value switch
            {
                VoiceType.Instant => "instant",
                VoiceType.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceType? ToEnum(string value)
        {
            return value switch
            {
                "instant" => VoiceType.Instant,
                "professional" => VoiceType.Professional,
                _ => null,
            };
        }
    }
}