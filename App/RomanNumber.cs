using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class RomanNumber
    {
        public Int32 Value { get; set; }

        private static Dictionary<Char, Int32> romanValues = new Dictionary<Char, Int32>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static RomanNumber Parse(string roman)
        {
            if (String.IsNullOrEmpty(roman))
            {
                throw new ArgumentException("Roman number is null or Empty");
            }

            Int32 result = 0;
            Int32 prev = 0;
            Int32 lastDigitIndex = roman.StartsWith("-") ? 1 : 0;

            roman = roman.Trim();

            for (Int32 i = roman.Length - 1; i >= 0; i--)
            {

                if (!romanValues.Keys.Any((key) => key == roman[i]))
                {
                    throw new ArgumentException($"'{roman[i]}' is an invalid symbol");
                }

                Int32 current = romanValues[roman[i]];

                if (current < prev)
                {
                    result -= current;
                }
                else
                {
                    result += current;
                }

                prev = current;
            }

            return new()
            {
                Value = lastDigitIndex == 0 ? result : -result
            };
        }

    }
}
