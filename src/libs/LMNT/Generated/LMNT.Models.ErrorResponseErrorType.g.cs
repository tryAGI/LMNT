
#nullable enable

namespace LMNT
{
    /// <summary>
    /// A short slug describing what went wrong.
    /// </summary>
    public enum ErrorResponseErrorType
    {
        /// <summary>
        ///
        /// </summary>
        AuthenticationError,
        /// <summary>
        ///
        /// </summary>
        InternalServerError,
        /// <summary>
        ///
        /// </summary>
        InvalidRequestError,
        /// <summary>
        ///
        /// </summary>
        NotFoundError,
        /// <summary>
        ///
        /// </summary>
        PaymentRequiredError,
        /// <summary>
        ///
        /// </summary>
        PermissionError,
        /// <summary>
        ///
        /// </summary>
        RateLimitError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorResponseErrorType value)
        {
            return value switch
            {
                ErrorResponseErrorType.AuthenticationError => "authentication_error",
                ErrorResponseErrorType.InternalServerError => "internal_server_error",
                ErrorResponseErrorType.InvalidRequestError => "invalid_request_error",
                ErrorResponseErrorType.NotFoundError => "not_found_error",
                ErrorResponseErrorType.PaymentRequiredError => "payment_required_error",
                ErrorResponseErrorType.PermissionError => "permission_error",
                ErrorResponseErrorType.RateLimitError => "rate_limit_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authentication_error" => ErrorResponseErrorType.AuthenticationError,
                "internal_server_error" => ErrorResponseErrorType.InternalServerError,
                "invalid_request_error" => ErrorResponseErrorType.InvalidRequestError,
                "not_found_error" => ErrorResponseErrorType.NotFoundError,
                "payment_required_error" => ErrorResponseErrorType.PaymentRequiredError,
                "permission_error" => ErrorResponseErrorType.PermissionError,
                "rate_limit_error" => ErrorResponseErrorType.RateLimitError,
                _ => null,
            };
        }
    }
}