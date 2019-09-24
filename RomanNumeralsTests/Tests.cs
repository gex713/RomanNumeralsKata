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

        [Fact]
        public void Seven()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(7).Should().Be("VII");
        }

        [Fact]
        public void Eight()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(8).Should().Be("VIII");
        }

        [Fact]
        public void Nine()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(9).Should().Be("IX");
        }

        [Fact]
        public void Ten()
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(10).Should().Be("X");
        }

        [Theory]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(16, "XVI")]
        [InlineData(17, "XVII")]
        [InlineData(18, "XVIII")]
        [InlineData(19, "XIX")]
        public void ArabaicToNumeralsWorksCorrectly(int numToConvert, string expected)
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(numToConvert).Should().Be(expected);
        }
    }
}
