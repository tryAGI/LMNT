
#nullable enable

namespace LMNT
{
    /// <summary>
    /// The model to use for synthesis. Learn more about models [here](https://docs.lmnt.com/guides/models).<br/>
    /// Default Value: blizzard
    /// </summary>
    public enum Model
    {
        /// <summary>
        /// 
        /// </summary>
        Blizzard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Model value)
        {
            return value switch
            {
                Model.Blizzard => "blizzard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Model? ToEnum(string value)
        {
            return value switch
            {
                "blizzard" => Model.Blizzard,
                _ => null,
            };
        }
    }
}