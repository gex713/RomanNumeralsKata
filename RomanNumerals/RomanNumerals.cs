﻿using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        public static List<int> arabicRepresentation = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public static List<string> romanRepresentation = new List<string> { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

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

            return builder.ToString();
        }

        private int AppendNumerals(int arabicNumber, int value, string romanNumeral, StringBuilder builder)
        {
            int result = arabicNumber;

            while (result >= value)
            {
                builder.Append(romanNumeral);
                result -= value;
            }

            return result;
        }
    }
}
