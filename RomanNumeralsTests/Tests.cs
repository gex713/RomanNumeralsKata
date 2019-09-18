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
    }
}
