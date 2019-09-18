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

            for(int i = 0; i < number; i++)
            {
                numerals += "I";
            }

            return numerals;
        }
    }
}
