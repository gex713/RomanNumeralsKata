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

            converter.Convert(1).Should().Be("I");
        }
    }
}
