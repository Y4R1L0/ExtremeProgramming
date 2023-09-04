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
        public static RomanNumber Parse(String input)
        {
            return new()
            {
                Value = input.Length
            };
        }
    }
}
