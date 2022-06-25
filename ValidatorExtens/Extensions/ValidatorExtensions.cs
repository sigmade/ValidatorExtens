using System;
using System.Linq.Expressions;
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
        public static T EnsureValid<T>(this T val, Func<T, bool> predicate) where T : class
        {
            if (val is null)
            {
                throw new ValidateException($"Value: {val} is null");
            }
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
            }
            return val;
        }

        /// <summary>
        /// Validates string by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated string</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static string EnsureValid(this string val, Func<string, bool> predicate)
        {
            if (val is null)
            {
                throw new ValidateException($"String: {val} is null");
            }
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
            }
            return val;
        }

        /// <summary>
        /// Validates int by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated int</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static int EnsureValid(this int val, Func<int, bool> predicate)
        {
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
            }
            return val;
        }

        /// <summary>
        /// Validates decimal by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated decimal</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static decimal EnsureValid(this decimal val, Func<decimal, bool> predicate)
        {
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
            }
            return val;
        }

        /// <summary>
        /// Validates long by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated long</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static long EnsureValid(this long val, Func<long, bool> predicate)
        {
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
            }
            return val;
        }

        /// <summary>
        /// Validates double by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated double</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static double EnsureValid(this double val, Func<double, bool> predicate)
        {
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
            }
            return val;
        }

        /// <summary>
        /// Validates float by predicate
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Validated double</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static float EnsureValid(this float val, Func<double, bool> predicate)
        {
            if (!predicate(val))
            {
                throw new ValidateException($"No valid value: {val}");
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
                throw new ValidateException($"Value: {val} is null");
            }
            if (val.Length < minLength)
            {
                throw new ValidateException($"Length value: {val} can not be less {minLength}");
            }
            if (val.Length > maxLength)
            {
                throw new ValidateException($"Length value: {val} can not be more {maxLength}");
            }
            return val;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid<T>(this T val, Func<T, bool> predicate) where T : class
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid(this string val, Func<string, bool> predicate)
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid(this int val, Func<int, bool> predicate)
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid(this long val, Func<long, bool> predicate)
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid(this decimal val, Func<decimal, bool> predicate)
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid(this double val, Func<double, bool> predicate)
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validity check
        /// </summary>
        /// <param name="predicate">Validate predicate</param>
        /// <returns>Boolean result</returns>
        public static bool IsValid(this float val, Func<float, bool> predicate)
        {
            if (predicate(val))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates int by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated int</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static int MinMaxValid(this int val, int minValue, int maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }

        /// <summary>
        /// Validates long by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated long</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static long MinMaxValid(this long val, long minValue, long maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }

        /// <summary>
        /// Validates DateTime by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated DateTime</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static DateTime MinMaxValid(this DateTime val, DateTime minValue, DateTime maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }

        /// <summary>
        /// Validates DateTimeOffset by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated DateTimeOffset</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static DateTimeOffset MinMaxValid(this DateTimeOffset val, DateTimeOffset minValue, DateTimeOffset maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }

        /// <summary>
        /// Validates decimal by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated decimal</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static decimal MinMaxValid(this decimal val, decimal minValue, decimal maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }

        /// <summary>
        /// Validates float by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated float</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static float MinMaxValid(this float val, float minValue, float maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }

        /// <summary>
        /// Validates double by Minimum-Maximum value
        /// </summary>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Validated double</returns>
        /// <exception cref="ValidateException">Exception message with validated type</exception>
        public static double MinMaxValid(this double val, double minValue, double maxValue)
        {
            if (val < minValue)
            {
                throw new ValidateException($"Value: {val} can not be less {minValue}");
            }
            if (val > maxValue)
            {
                throw new ValidateException($"Value: {val} can not be more {maxValue}");
            }
            return val;
        }
    }
}
