using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace App
{
    public class RomanNumber
    {
        public int Value { get; set; }

        public RomanNumber(int value)
        {
            this.Value = value;
        }

        private static Dictionary<char, int> romanValues = new Dictionary<char, int>
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
            IsValid(roman);
            IsLegal(roman);

            int result = 0;
            int prev = 0;
            int lastDigitIndex = roman.StartsWith("-") ? 1 : 0;
            roman = roman.Replace("-", "");
            roman = roman.Trim();

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int current = romanValues[roman[i]];

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

            return new(lastDigitIndex == 0 ? result : -result);
        }

        private static bool IsValid(string roman)
        {
            if (String.IsNullOrEmpty(roman))
            {
                throw new ArgumentException(ExceptionMessages.NullOrEmpty);
            }

            List<char> invalid = new List<char>();

            foreach (var number in roman)
            {
                if (!romanValues.Keys.Any((val) => val == number))
                {
                    invalid.Add(number);
                }
            }

            if (invalid.Count > 0)
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumbersMessage(invalid));
            }

            return true;
        }

        private static bool IsLegal(string roman)
        {
            int maxDigit = 0;
            int consecutiveLessCount = 0;

            foreach (char digitChar in roman.Reverse())
            {
                int digitValue = romanValues[digitChar];

                if (digitValue < maxDigit)
                {
                    consecutiveLessCount++;
                    if (consecutiveLessCount > 1)
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidSequence(roman));
                    }
                }
                else
                {
                    maxDigit = digitValue;
                    consecutiveLessCount = 0;
                }
            }

            return true;
        }

        public override string ToString()
        {
            if (this.Value == 0)
            {
                return "N";
            }

            if (this.Value < 0)
            {
                return "-" + ToRoman(-Value);
            }

            return ToRoman(Value);

        }

        private string ToRoman(int num)
        {
            string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string roman = "";
            int index = 0;

            while (num > 0)
            {
                if (num - values[index] >= 0)
                {
                    roman += romanSymbols[index];
                    num -= values[index];
                }
                else
                {
                    index++;
                }
            }

            return roman;
        }

        public RomanNumber Plus(RomanNumber r2)
        {
            return new RomanNumber(Value + r2.Value);
        }

        public RomanNumber Minus(RomanNumber r2)
        {
            return new RomanNumber(Value - r2.Value);
        }

        public static RomanNumber? Sum(params RomanNumber[] romans)
        {
            if (romans.Length == 0)
            {
                return new(0);
            }

            if (romans.Equals(null) || romans.All((roman) => roman == null))
            {
                return null;
            }

            var resRoman = new RomanNumber(0);
            foreach (var roman in romans)
            {
                resRoman.Value += roman.Value;
            }
            return resRoman;
        }

    }
}
