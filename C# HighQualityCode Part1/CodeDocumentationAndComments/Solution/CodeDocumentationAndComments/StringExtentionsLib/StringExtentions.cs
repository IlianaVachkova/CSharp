using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Telerik.ILS.Common
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the MD5 hash code of the string.
        /// </summary>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            // Format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Checks if a string value can be interpreted as a boolean.
        /// </summary>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the string to 16-bit integer
        /// </summary>
        /// <returns>
        /// 16-bit integer, if the input is 16-bit number,
        /// or 0 if the input is in the wrong format.
        /// </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the string to 32-bit integer
        /// </summary>
        /// <returns>
        /// 32-bit integer, if the input is 32-bit number,
        /// or 0 if the input is in the wrong format.
        /// </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the string to 64-bit integer
        /// </summary>
        /// <returns>
        /// 64-bit integer, if the input is 64-bit number,
        /// or 0 if the input is in the wrong format.
        /// </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the string to Date and Time
        /// </summary>
        /// <returns>
        /// The date and the time of the day, if the input is in DateTime format,
        /// otherwise returns the DateTime default value.
        /// </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Returns string with capitalized first letter or 
        /// an empty string if the input is empty or null
        /// </summary>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
                input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns string between two given strings.
        /// </summary>
        /// <param name="startFrom">The position we start the search from.</param>
        /// <returns><see cref="System.String"/> with the string between two strings or
        /// an empty string if the startString or the endString don't exist.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts all cyrillic letters to their latin representation.
        /// </summary>
        /// <returns>A new string with the replaced cyrillic letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters =
                new[]
                {
                    "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                    "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                };
            var latinRepresentationsOfBulgarianLetters =
                new[]
                {
                    "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                    "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                    "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                };

            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(
                    bulgarianLetters[i],
                    latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(
                    bulgarianLetters[i].ToUpper(),
                    latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts all latin letters to their cyrillic representation/pronounciation/.
        /// </summary>
        /// <returns>A new string with the replaced latin letters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters =
                new[]
                {
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                    "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                };

            var bulgarianRepresentationOfLatinKeyboard =
                new[]
                {
                    "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                    "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                    "в", "ь", "ъ", "з"
                };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(
                    latinLetters[i],
                    bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(
                    latinLetters[i].ToUpper(),
                    bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts the given string into its correct username.
        /// </summary>
        /// <returns>A new string with the converted username.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts the given string into its correct latin file name.
        /// </summary>
        /// <returns>A new string with the converted file name.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets the first characters in a given string.
        /// </summary>
        /// <param name="charsCount">The count of the first characters in the given string</param>
        /// <returns>A new string with the first characters.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Returns the file extension of a given file name.
        /// The "." is mandatory for the file name.
        /// </summary>
        /// <returns>A new string with the extension of a file or
        /// an empty string if the is empty or not in the correct format</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the content format of a file according to its file extension.
        /// </summary>
        /// <returns>A new string with the content format of the file or
        /// "application/octet-stream" if the file is in rare format.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType =
                new Dictionary<string, string>
                {
                    { "jpg", "image/jpeg" },
                    { "jpeg", "image/jpeg" },
                    { "png", "image/x-png" },
                    {
                        "docx",
                        "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                    },
                    { "doc", "application/msword" },
                    { "pdf", "application/pdf" },
                    { "txt", "text/plain" },
                    { "rtf", "application/rtf" }
                };

            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts the string into array of bytes.
        /// Every character in the string is converted to its ASCII code.
        /// </summary>
        /// <returns>
        /// A byte array of the ASCII codes of the given string
        /// </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];

            Buffer.BlockCopy(
                input.ToCharArray(), 0,
                bytesArray, 0, bytesArray.Length);

            return bytesArray;
        }
    }
}