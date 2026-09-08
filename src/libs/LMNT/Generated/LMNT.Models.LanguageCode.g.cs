
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
        As,
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Bn,
        /// <summary>
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        Da,
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
        Fi,
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
        Ml,
        /// <summary>
        ///
        /// </summary>
        Mr,
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
        Sk,
        /// <summary>
        ///
        /// </summary>
        Sv,
        /// <summary>
        ///
        /// </summary>
        Ta,
        /// <summary>
        ///
        /// </summary>
        Te,
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
                LanguageCode.As => "as",
                LanguageCode.Auto => "auto",
                LanguageCode.Bn => "bn",
                LanguageCode.Cs => "cs",
                LanguageCode.Da => "da",
                LanguageCode.De => "de",
                LanguageCode.En => "en",
                LanguageCode.Es => "es",
                LanguageCode.Fi => "fi",
                LanguageCode.Fr => "fr",
                LanguageCode.Hi => "hi",
                LanguageCode.Id => "id",
                LanguageCode.It => "it",
                LanguageCode.Ja => "ja",
                LanguageCode.Ko => "ko",
                LanguageCode.Ml => "ml",
                LanguageCode.Mr => "mr",
                LanguageCode.Nl => "nl",
                LanguageCode.Pl => "pl",
                LanguageCode.Pt => "pt",
                LanguageCode.Ru => "ru",
                LanguageCode.Sk => "sk",
                LanguageCode.Sv => "sv",
                LanguageCode.Ta => "ta",
                LanguageCode.Te => "te",
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
                "as" => LanguageCode.As,
                "auto" => LanguageCode.Auto,
                "bn" => LanguageCode.Bn,
                "cs" => LanguageCode.Cs,
                "da" => LanguageCode.Da,
                "de" => LanguageCode.De,
                "en" => LanguageCode.En,
                "es" => LanguageCode.Es,
                "fi" => LanguageCode.Fi,
                "fr" => LanguageCode.Fr,
                "hi" => LanguageCode.Hi,
                "id" => LanguageCode.Id,
                "it" => LanguageCode.It,
                "ja" => LanguageCode.Ja,
                "ko" => LanguageCode.Ko,
                "ml" => LanguageCode.Ml,
                "mr" => LanguageCode.Mr,
                "nl" => LanguageCode.Nl,
                "pl" => LanguageCode.Pl,
                "pt" => LanguageCode.Pt,
                "ru" => LanguageCode.Ru,
                "sk" => LanguageCode.Sk,
                "sv" => LanguageCode.Sv,
                "ta" => LanguageCode.Ta,
                "te" => LanguageCode.Te,
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