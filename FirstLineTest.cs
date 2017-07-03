using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    [TestFixture]
    public class FirstLineTest
    {
        [Test]
        public void Get_first_line()
        {
            string expected = "88 bottles of beer on the wall, 88 bottles of beer.\n";
            int numberOfBottles = 88;

            string line = new FirstLine(numberOfBottles).Text;

            Assert.AreEqual(expected, line);
        }

    }
}

