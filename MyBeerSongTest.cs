using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerSong
{
    [TestFixture]
    public class MyBeerSongTest
    {
        [Test]
        public void Get_next_verse()
        {
            string expected1 = "99 bottles of beer on the wall, 99 bottles of beer.\n" +
                "Take one down and pass it around, 98 bottles of beer on the wall.\n" +
                "";
            string expected2 = "98 bottles of beer on the wall, 98 bottles of beer.\n" +
                "Take one down and pass it around, 97 bottles of beer on the wall.\n" +
                "";

            MyBeerSong song = new MyBeerSong();
            var verse1 = song.NextVerse();
            var verse2 = song.NextVerse();

            Assert.AreEqual(expected1, verse1);
            Assert.AreEqual(expected2, verse2);
        }


        [Test]
        public void Negative_initial_number_of_bottles_throws_exception()
        {
            Assert.Throws<ArgumentException>(() => new MyBeerSong(-1));
        }

    }
}

