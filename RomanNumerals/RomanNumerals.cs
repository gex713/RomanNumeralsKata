using System;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        public RomanNumerals()
        {

        }

        public string ArabicToRoman(int number)
        {
            StringBuilder builder = new StringBuilder();
            int remainder = number;

            remainder = AppendNumerals(remainder, 14, "XIV", builder);
            remainder = AppendNumerals(remainder, 10, "X", builder);
            remainder = AppendNumerals(remainder, 9, "IX", builder);
            remainder = AppendNumerals(remainder, 5, "V", builder);
            remainder = AppendNumerals(remainder, 4, "IV", builder);

            for (int i = 0; i < remainder; i++)
            {
                builder.Append("I");
            }

            return builder.ToString();
        }

        private int AppendNumerals(int arabicNumber, int value, string romanNumeral, StringBuilder builder)
        {
            int result = arabicNumber;

            if (result >= value)
            {
                builder.Append(romanNumeral);
                result -= value;
            }

            return result;
        }
    }
}
