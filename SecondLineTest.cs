using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    [TestFixture]
    public class SecondLineTest
    {
        [Test]
        public void Get_second_line()
        {
            string expected = "Take one down and pass it around, 87 bottles of beer on the wall.\n";
            int initialNumberOfBottles = 99;
            int numberOfBottles = 87;

            string line = new SecondLine(numberOfBottles, initialNumberOfBottles).Text;

            Assert.AreEqual(expected, line);
        }


    }
}

