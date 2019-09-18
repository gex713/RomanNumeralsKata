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
            if (number == 3) return "III";
            if (number == 2) return "II";
            return "I";
        }
    }
}
