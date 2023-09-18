using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class ExceptionMessages
    {
        public ExceptionMessages()
        {
            NullOrEmpty = "Roman number is null or Empty";

        }

        public static string NullOrEmpty;

        public static string InvalidNumbersMessage(List<char> invalid)
        {
            string invalidChars = string.Join(", ", invalid.Select(val => $"'{val}'").ToArray());
            return $"Invalid numbers found in input {invalidChars}";
        }

        public static string InvalidSequence(string roman)
        {
            return $"Invalid sequence of characters '{roman}'";
        }
    }
}