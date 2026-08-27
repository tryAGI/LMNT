
#nullable enable

namespace LMNT
{
    /// <summary>
    /// The owner of this voice.
    /// </summary>
    public enum VoiceOwner
    {
        /// <summary>
        ///
        /// </summary>
        Me,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceOwnerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceOwner value)
        {
            return value switch
            {
                VoiceOwner.Me => "me",
                VoiceOwner.Other => "other",
                VoiceOwner.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceOwner? ToEnum(string value)
        {
            return value switch
            {
                "me" => VoiceOwner.Me,
                "other" => VoiceOwner.Other,
                "system" => VoiceOwner.System,
                _ => null,
            };
        }
    }
}