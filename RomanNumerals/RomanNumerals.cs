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
            int remainder = number;

            if(number >= 10)
            {
                numerals += "X";
                remainder -= 10;
            }
            else if(number == 9)
            {
                numerals += "IX";
                remainder -= 9;
            }
            else if (number >= 5)
            {
                numerals += "V";
                remainder -= 5;
            }
            else if (number == 4)
            {
                numerals += "IV";
                remainder -= 4;
            }

            for (int i = 0; i < remainder; i++)
            {
                numerals += "I";
            }

            return numerals;
        }
    }
}
