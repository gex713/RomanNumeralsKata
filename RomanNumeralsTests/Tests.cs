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
        [InlineData(20, "XX")]
        [InlineData(21, "XXI")]
        [InlineData(22, "XXII")]
        [InlineData(23, "XXIII")]
        [InlineData(24, "XXIV")]
        [InlineData(25, "XXV")]
        [InlineData(26, "XXVI")]
        [InlineData(27, "XXVII")]
        [InlineData(28, "XXVIII")]
        [InlineData(29, "XXIX")]
        [InlineData(30, "XXX")]
        [InlineData(31, "XXXI")]
        [InlineData(32, "XXXII")]
        [InlineData(33, "XXXIII")]
        [InlineData(34, "XXXIV")]
        [InlineData(35, "XXXV")]
        [InlineData(36, "XXXVI")]
        [InlineData(37, "XXXVII")]
        [InlineData(38, "XXXVIII")]
        [InlineData(39, "XXXIX")]
        [InlineData(40, "XL")]
        [InlineData(41, "XLI")]
        [InlineData(42, "XLII")]
        [InlineData(43, "XLIII")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(46, "XLVI")]
        [InlineData(47, "XLVII")]
        [InlineData(48, "XLVIII")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(80, "LXXX")]
        [InlineData(85, "LXXXV")]
        [InlineData(89, "LXXXIX")]
        [InlineData(95, "XCV")]
        [InlineData(98, "XCVIII")]
        [InlineData(99, "XCIX")]
        public void ArabicToNumeralsWorksCorrectly(int numToConvert, string expected)
        {
            var converter = new RomanNumerals.RomanNumerals();

            converter.ArabicToRoman(numToConvert).Should().Be(expected);
        }
    }
}
