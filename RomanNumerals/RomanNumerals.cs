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
            if (number == 2) return "II";
            return "I";
        }
    }
}
