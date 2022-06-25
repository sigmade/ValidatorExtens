using System;
using System.Linq.Expressions;
using ValidatorExtens.Exceptions;

namespace ValidatorExtens.Extensions
{
    public static class ValidatorExtensions
    {
        public static T EnsureValid<T>(this T val, Expression<Func<T, bool>> exp) where T : class
        {
            if (val is null)
            {
                throw new ValidateException($"Value: {val} is null");
            }
            var func = exp.Compile();
            if (!func(val))
            {
                throw new ValidateException($"No valid value: {val} for expresion: {exp}");
            }
            return val;
        }

        public static string EnsureValid(this string val, Expression<Func<string, bool>> exp)
        {
            if (val is null)
            {
                throw new ValidateException($"Value: {val} is null");
            }
            var func = exp.Compile();
            if (!func(val))
            {
                throw new ValidateException($"No valid value: {val} for expresion: {exp}");
            }
            return val;
        }

        public static int EnsureValid(this int val, Expression<Func<int, bool>> exp)
        {
            var func = exp.Compile();
            if (!func(val))
            {
                throw new ValidateException($"No valid value: {val} for expresion: {exp}");
            }
            return val;
        }

        public static string LengthValid(this string val, int minLen, int maxLen)
        {
            if (val is null)
            {
                throw new ValidateException($"Value: {val} is null");
            }
            if (val.Length < minLen)
            {
                throw new ValidateException($"Length value: {val} can not be less {minLen}");
            }
            if (val.Length > maxLen)
            {
                throw new ValidateException($"Length value: {val} can not be more {maxLen}");
            }
            return val;
        }

        public static bool IsValid<T>(this T val, Func<T, bool> func) where T : class
        {
            if (func(val))
            {
                return true;
            }
            return false;
        }

        public static bool IsValid(this string val, Func<string, bool> func)
        {
            if (func(val))
            {
                return true;
            }
            return false;
        }

        public static bool IsValid(this int val, Func<int, bool> func)
        {
            if (func(val))
            {
                return true;
            }
            return false;
        }

        public static int MinMaxValid(this int val, int minVal, int maxVal)
        {
            if (val < minVal)
            {
                throw new ValidateException($"Value: {val} can not be less {minVal}");
            }
            if (val > maxVal)
            {
                throw new ValidateException($"Value: {val} can not be more {maxVal}");
            }
            return val;
        }

        public static DateTime MinMaxValid(this DateTime val, DateTime minVal, DateTime maxVal)
        {
            if (val < minVal)
            {
                throw new ValidateException($"Value: {val} can not be less {minVal}");
            }
            if (val > maxVal)
            {
                throw new ValidateException($"Value: {val} can not be more {maxVal}");
            }
            return val;
        }
    }
}
