
#nullable enable

namespace LMNT
{
    /// <summary>
    /// The desired output format of the audio. If you are using a streaming endpoint, you'll generate audio faster by selecting a streamable format since chunks are encoded and returned as they're generated. For non-streamable formats, the entire audio will be synthesized before encoding.<br/>
    /// Streamable formats:<br/>
    /// - `mp3`: 96kbps MP3 audio.<br/>
    /// - `ulaw`: 8-bit G711 µ-law audio with a WAV header.<br/>
    /// - `webm`: WebM format with Opus audio codec.<br/>
    /// - `pcm_s16le`: PCM signed 16-bit little-endian audio.<br/>
    /// - `pcm_f32le`: PCM 32-bit floating-point little-endian audio.<br/>
    /// Non-streamable formats:<br/>
    /// - `aac`: AAC audio codec.<br/>
    /// - `wav`: 16-bit PCM audio in WAV container.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// AAC audio codec.
        /// </summary>
        Aac,
        /// <summary>
        /// 96kbps MP3 audio.
        /// </summary>
        Mp3,
        /// <summary>
        /// PCM 32-bit floating-point little-endian audio.
        /// </summary>
        PcmF32le,
        /// <summary>
        /// PCM signed 16-bit little-endian audio.
        /// </summary>
        PcmS16le,
        /// <summary>
        /// 8-bit G711 µ-law audio with a WAV header.
        /// </summary>
        Ulaw,
        /// <summary>
        /// 16-bit PCM audio in WAV container.
        /// </summary>
        Wav,
        /// <summary>
        /// WebM format with Opus audio codec.
        /// </summary>
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat value)
        {
            return value switch
            {
                OutputFormat.Aac => "aac",
                OutputFormat.Mp3 => "mp3",
                OutputFormat.PcmF32le => "pcm_f32le",
                OutputFormat.PcmS16le => "pcm_s16le",
                OutputFormat.Ulaw => "ulaw",
                OutputFormat.Wav => "wav",
                OutputFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "aac" => OutputFormat.Aac,
                "mp3" => OutputFormat.Mp3,
                "pcm_f32le" => OutputFormat.PcmF32le,
                "pcm_s16le" => OutputFormat.PcmS16le,
                "ulaw" => OutputFormat.Ulaw,
                "wav" => OutputFormat.Wav,
                "webm" => OutputFormat.Webm,
                _ => null,
            };
        }
    }
}