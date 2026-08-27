#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SpeechRequest : global::System.IEquatable<SpeechRequest>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LMNT.StreamSpeechRequest? Stream { get; init; }
#else
        public global::LMNT.StreamSpeechRequest? Stream { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stream))]
#endif
        public bool IsStream => Stream != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStream(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LMNT.StreamSpeechRequest? value)
        {
            value = Stream;
            return IsStream;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LMNT.StreamSpeechRequest PickStream() => IsStream
            ? Stream!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stream' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LMNT.SpeechRequestVariant2? SpeechRequestVariant2 { get; init; }
#else
        public global::LMNT.SpeechRequestVariant2? SpeechRequestVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechRequestVariant2))]
#endif
        public bool IsSpeechRequestVariant2 => SpeechRequestVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LMNT.SpeechRequestVariant2? value)
        {
            value = SpeechRequestVariant2;
            return IsSpeechRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LMNT.SpeechRequestVariant2 PickSpeechRequestVariant2() => IsSpeechRequestVariant2
            ? SpeechRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechRequest(global::LMNT.StreamSpeechRequest value) => new SpeechRequest((global::LMNT.StreamSpeechRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LMNT.StreamSpeechRequest?(SpeechRequest @this) => @this.Stream;

        /// <summary>
        ///
        /// </summary>
        public SpeechRequest(global::LMNT.StreamSpeechRequest? value)
        {
            Stream = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechRequest FromStream(global::LMNT.StreamSpeechRequest? value) => new SpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechRequest(global::LMNT.SpeechRequestVariant2 value) => new SpeechRequest((global::LMNT.SpeechRequestVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LMNT.SpeechRequestVariant2?(SpeechRequest @this) => @this.SpeechRequestVariant2;

        /// <summary>
        ///
        /// </summary>
        public SpeechRequest(global::LMNT.SpeechRequestVariant2? value)
        {
            SpeechRequestVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechRequest FromSpeechRequestVariant2(global::LMNT.SpeechRequestVariant2? value) => new SpeechRequest(value);

        /// <summary>
        ///
        /// </summary>
        public SpeechRequest(
            global::LMNT.StreamSpeechRequest? stream,
            global::LMNT.SpeechRequestVariant2? speechRequestVariant2
            )
        {
            Stream = stream;
            SpeechRequestVariant2 = speechRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SpeechRequestVariant2 as object ??
            Stream as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Stream?.ToString() ??
            SpeechRequestVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStream && IsSpeechRequestVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LMNT.StreamSpeechRequest, TResult>? stream = null,
            global::System.Func<global::LMNT.SpeechRequestVariant2, TResult>? speechRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream && stream != null)
            {
                return stream(Stream!);
            }
            else if (IsSpeechRequestVariant2 && speechRequestVariant2 != null)
            {
                return speechRequestVariant2(SpeechRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LMNT.StreamSpeechRequest>? stream = null,

            global::System.Action<global::LMNT.SpeechRequestVariant2>? speechRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream)
            {
                stream?.Invoke(Stream!);
            }
            else if (IsSpeechRequestVariant2)
            {
                speechRequestVariant2?.Invoke(SpeechRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LMNT.StreamSpeechRequest>? stream = null,
            global::System.Action<global::LMNT.SpeechRequestVariant2>? speechRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStream)
            {
                stream?.Invoke(Stream!);
            }
            else if (IsSpeechRequestVariant2)
            {
                speechRequestVariant2?.Invoke(SpeechRequestVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Stream,
                typeof(global::LMNT.StreamSpeechRequest),
                SpeechRequestVariant2,
                typeof(global::LMNT.SpeechRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SpeechRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LMNT.StreamSpeechRequest?>.Default.Equals(Stream, other.Stream) &&
                global::System.Collections.Generic.EqualityComparer<global::LMNT.SpeechRequestVariant2?>.Default.Equals(SpeechRequestVariant2, other.SpeechRequestVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpeechRequest obj1, SpeechRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechRequest obj1, SpeechRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechRequest o && Equals(o);
        }
    }
}
