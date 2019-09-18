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

            if(number == 6)
            {
                numerals += "VI";
            }
            else if (number == 5)
            {
                numerals += "V";
            }
            else if (number == 4)
            {
                numerals += "IV";
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    numerals += "I";
                }
            }

            return numerals;
        }
    }
}
