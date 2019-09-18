using FluentAssertions;
using System;
using Xunit;

namespace RomanNumeralsTests
{
    public class Tests
    {
        [Fact]
        public void One()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(1).Should().Be("I");
        }

        [Fact]
        public void Two()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(2).Should().Be("II");
        }

        [Fact]
        public void Three()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(3).Should().Be("III");
        }

        [Fact]
        public void Four()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(4).Should().Be("IV");
        }

        [Fact]
        public void Five()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(5).Should().Be("V");
        }

        [Fact]
        public void Six()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(6).Should().Be("VI");
        }
    }
}
