using System;
using ValidatorExtens.Exceptions;

namespace ValidatorExtens.Extensions
{
    public static class ValidatorExtensions
    {
        /// <summary>
        /// Validates type by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated type</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static T EnsureValid<T>(this T val, Func<T, bool> predicate)
        {
            if (val == null)
            {
                throw new ValidateException(ExcMsg.ValueNull, val);
            }
            if (!predicate(val))
            {
                throw new ValidateException(ExcMsg.Notvalid, val);
            }
            return val;
        }

        /// <summary>
        /// Validates string by length
        /// </summary>
        /// <param name="minLength">Minimum number of characters</param>
        /// <param name="maxLength">Maximum number of characters</param>
        /// <returns>Validated string</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static string LengthValid(this string val, int minLength, int maxLength)
        {
            if (val is null)
            {
                throw new ValidateException(ExcMsg.ValueNull, val);
            }
            if (val.Length < minLength)
            {
                throw new ValidateException(ExcMsg.MinLength, minLength);
            }
            if (val.Length > maxLength)
            {
                throw new ValidateException(ExcMsg.MaxLength, maxLength);
            }
            return val;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid<T>(this T val, Func<T, bool> predicate) 
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates IComparable types by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated int</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static T MinMaxValid<T>(this T val, T minValue, T maxValue) where T : IComparable<T>
        {
            if (val.CompareTo(minValue) < 0)
            {
                throw new ValidateException(ExcMsg.MinValue, minValue);
            }
            if (val.CompareTo(maxValue) > 0)
            {
                throw new ValidateException(ExcMsg.MaxValue, maxValue);
            }
            return val;
        }
    }
}
