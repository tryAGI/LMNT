
#nullable enable

namespace LMNT
{
    /// <summary>
    /// The desired language. Two letter ISO 639-1 code. Defaults to auto language detection, but specifying the language is recommended for faster generation.<br/>
    /// Default Value: auto
    /// </summary>
    public enum LanguageCode
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageCode value)
        {
            return value switch
            {
                LanguageCode.Ar => "ar",
                LanguageCode.Auto => "auto",
                LanguageCode.De => "de",
                LanguageCode.En => "en",
                LanguageCode.Es => "es",
                LanguageCode.Fr => "fr",
                LanguageCode.Hi => "hi",
                LanguageCode.Id => "id",
                LanguageCode.It => "it",
                LanguageCode.Ja => "ja",
                LanguageCode.Ko => "ko",
                LanguageCode.Nl => "nl",
                LanguageCode.Pl => "pl",
                LanguageCode.Pt => "pt",
                LanguageCode.Ru => "ru",
                LanguageCode.Sv => "sv",
                LanguageCode.Th => "th",
                LanguageCode.Tr => "tr",
                LanguageCode.Uk => "uk",
                LanguageCode.Ur => "ur",
                LanguageCode.Vi => "vi",
                LanguageCode.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageCode? ToEnum(string value)
        {
            return value switch
            {
                "ar" => LanguageCode.Ar,
                "auto" => LanguageCode.Auto,
                "de" => LanguageCode.De,
                "en" => LanguageCode.En,
                "es" => LanguageCode.Es,
                "fr" => LanguageCode.Fr,
                "hi" => LanguageCode.Hi,
                "id" => LanguageCode.Id,
                "it" => LanguageCode.It,
                "ja" => LanguageCode.Ja,
                "ko" => LanguageCode.Ko,
                "nl" => LanguageCode.Nl,
                "pl" => LanguageCode.Pl,
                "pt" => LanguageCode.Pt,
                "ru" => LanguageCode.Ru,
                "sv" => LanguageCode.Sv,
                "th" => LanguageCode.Th,
                "tr" => LanguageCode.Tr,
                "uk" => LanguageCode.Uk,
                "ur" => LanguageCode.Ur,
                "vi" => LanguageCode.Vi,
                "zh" => LanguageCode.Zh,
                _ => null,
            };
        }
    }
}