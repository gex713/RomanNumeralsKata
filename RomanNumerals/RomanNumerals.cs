﻿using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        public static List<int> arabicRepresentation = new List<int> { 14, 10, 9, 5, 4 };
        public static List<string> romanRepresentation = new List<string> { "XIV", "X", "IX", "V", "IV" };

        public RomanNumerals()
        {

        }

        public string ArabicToRoman(int number)
        {
            StringBuilder builder = new StringBuilder();
            int remainder = number;

            for (int i = 0; i < arabicRepresentation.Count; i++)
            {
                remainder = AppendNumerals(remainder, arabicRepresentation[i], romanRepresentation[i], builder);
            }

            while(remainder >= 1)
            {
                builder.Append("I");
                remainder--;
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
