using PROG2400A1NathanSaccon.Models;
using System;
using Xunit;

namespace PROG2400UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void DecToBinary_0_0()
        {
            Assert.Equal("0", InputData.D2B(0));
        }

        [Fact]
        public void DecToBinary_4_100()
        {
            Assert.Equal("100", InputData.D2B(4));
        }

        [Fact]
        public void DecToBinary_21_10101()
        {
            Assert.Equal("10101", InputData.D2B(21));
        }

        [Fact]
        public void DecToBinary_54_110110()
        {
            Assert.Equal("110110", InputData.D2B(54));
        }

        [Fact]
        public void DecToBinary_87_1010111()
        {
            Assert.Equal("1010111", InputData.D2B(87));
        }

        [Fact]
        public void BinaryToDec_0_0()
        {
            Assert.Equal("0", InputData.B2D("0"));
        }

        [Fact]
        public void BinaryToDec_100_4()
        {
            Assert.Equal("4", InputData.B2D("100"));
        }

        [Fact]
        public void BinaryToDec_10101_21()
        {
            Assert.Equal("21", InputData.B2D("10101"));
        }

        [Fact]
        public void BinaryToDec_110110_54()
        {
            Assert.Equal("54", InputData.B2D("110110"));
        }

        [Fact]
        public void BinaryToDec_1010111_87()
        {
            Assert.Equal("87", InputData.B2D("1010111"));
        }

    }
}
