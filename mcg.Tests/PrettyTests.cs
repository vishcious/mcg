using System;
using Xunit;
using mcg;

namespace mcg.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetDigitsAfter_10s_GreaterThan10()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(12, 1);
            Assert.Equal("1", digits);
            Assert.Equal(2, remainder);
        }

        [Fact]
        public void GetDigitsAfter_10s_LessThan10()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(9, 1);
            Assert.Equal("", digits);
            Assert.Equal(9, remainder);
        }

        [Fact]
        public void GetDigitsAfter_100s_GreaterThan100()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(789, 2);
            Assert.Equal("7", digits);
            Assert.Equal(89, remainder);
        }

        [Fact]
        public void GetDigitsAfter_100s_LessThan100()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(99, 2);
            Assert.Equal("", digits);
            Assert.Equal(99, remainder);
        }

        [Fact]
        public void GetDigitsAfter_Millions_GreaterThanMillion()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(5679456, 6);
            Assert.Equal("5", digits);
            Assert.Equal(679456, remainder);
        }

        [Fact]
        public void GetDigitsAfter_Millions_LessThanMillion()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(998877, 6);
            Assert.Equal("", digits);
            Assert.Equal(998877, remainder);
        }

        [Fact]
        public void GetDigitsAfter_Billions_GreaterThanBillion()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(5679456333, 9);
            Assert.Equal("5", digits);
            Assert.Equal(679456333, remainder);
        }

        [Fact]
        public void GetDigitsAfter_Billions_LessThanBillion()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(998877333, 9);
            Assert.Equal("", digits);
            Assert.Equal(998877333, remainder);
        }

        [Fact]
        public void GetDigitsAfter_Trillions_GreaterThanTrillion()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(5679456333111, 12);
            Assert.Equal("5", digits);
            Assert.Equal(679456333111, remainder);
        }

        [Fact]
        public void GetDigitsAfter_Trillions_LessThanTrillion()
        {
            (var digits, var remainder) = Pretty.GetDigitsAfter(998877333111, 12);
            Assert.Equal("", digits);
            Assert.Equal(998877333111, remainder);
        }





        [Fact]
        public void PrettifyAfterDigits_Millions_GreaterThanMillion()
        {
            var result = Pretty.PrettifyAfterDigits(5679456, 6);
            Assert.Equal("5.6", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Millions_EqualToMillion()
        {
            var result = Pretty.PrettifyAfterDigits(5000000, 6);
            Assert.Equal("5", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Millions_LessThanMillion()
        {
            var result = Pretty.PrettifyAfterDigits(998877, 6);
            Assert.Equal("", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Billions_GreaterThanBillion()
        {
            var result = Pretty.PrettifyAfterDigits(5679456777, 9);
            Assert.Equal("5.6", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Billions_EqualToBillion()
        {
            var result = Pretty.PrettifyAfterDigits(5000000000, 9);
            Assert.Equal("5", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Billions_LessThanBillion()
        {
            var result = Pretty.PrettifyAfterDigits(998877999, 9);
            Assert.Equal("", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Trillions_GreaterThanTrillion()
        {
            var result = Pretty.PrettifyAfterDigits(5679456777666, 12);
            Assert.Equal("5.6", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Trillions_EqualToTrillion()
        {
            var result = Pretty.PrettifyAfterDigits(5000000000000, 12);
            Assert.Equal("5", result);
        }

        [Fact]
        public void PrettifyAfterDigits_Trillions_LessThanTrillion()
        {
            var result = Pretty.PrettifyAfterDigits(998877999111, 12);
            Assert.Equal("", result);
        }









        [Fact]
        public void PrettifyMillions()
        {
            var result = Pretty.PrettifyMillion(6789567);
            Assert.Equal("6.7M", result);
        }

        [Fact]
        public void PrettifyBillions()
        {
            var result = Pretty.PrettifyBillion(3566789567);
            Assert.Equal("3.5B", result);
        }

        [Fact]
        public void PrettifyTrillions()
        {
            var result = Pretty.PrettifyTrillion(7998877999111);
            Assert.Equal("7.9T", result);
        }

        [Fact]
        public void Prettify_1()
        {
            var result = Pretty.Prettify(7998877999111);
            Assert.Equal("7.9T", result);
        }

        [Fact]
        public void Prettify_2()
        {
            var result = Pretty.Prettify(3566789567);
            Assert.Equal("3.5B", result);
        }

        [Fact]
        public void Prettify_3()
        {
            var result = Pretty.Prettify(2789456);
            Assert.Equal("2.7M", result);
        }
    }
}
