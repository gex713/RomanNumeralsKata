using System;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        public RomanNumerals()
        {

        }

        public string ArabicToRoman(int number)
        {
            string numerals = String.Empty;

            if (number == 5) return "V";
            if (number == 4) return "IV";

            for(int i = 0; i < number; i++)
            {
                numerals += "I";
            }

            return numerals;
        }
    }
}
