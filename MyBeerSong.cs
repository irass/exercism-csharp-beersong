using System;
using System.Text;

namespace BeerSong
{
    public class MyBeerSong
    {
        readonly int initialNumberOfBottlesOnTheWall;
        int numberOfBottlesOnTheWall;

        public MyBeerSong(int numberOfBottlesOnTheWall = 99, int initialNumberOfBottlesOnTheWall = 99)
        {
            if (numberOfBottlesOnTheWall < 0)
                throw new ArgumentException("Intial number of bottles cannot be negative", "numberOfBottlesOnTheWall");

            this.initialNumberOfBottlesOnTheWall = initialNumberOfBottlesOnTheWall;
            this.numberOfBottlesOnTheWall = numberOfBottlesOnTheWall;
        }

        public string NextVerse()
        {
            string verse = FirstLine.Line(numberOfBottlesOnTheWall) + SecondLine.Line(NextNumberOfBottles, initialNumberOfBottlesOnTheWall) + "";
            numberOfBottlesOnTheWall = NextNumberOfBottles;
            return verse;
        }

        public static string Verse(int numberOfBottles)
        {
            MyBeerSong song = new MyBeerSong(numberOfBottles);
            return song.NextVerse();
        }

        public static string Verses(int begin, int end)
        {
            StringBuilder result = new StringBuilder();
            int numberOfVerses = begin - end;
            MyBeerSong song = new MyBeerSong(begin);

            for (int i = 0; i < numberOfVerses; i++)
            {
                result.Append(song.NextVerse());
                result.Append("\n");
            }
            result.Append(song.NextVerse());

            return result.ToString();
        }

        int NextNumberOfBottles { get { return numberOfBottlesOnTheWall > 0 ? numberOfBottlesOnTheWall - 1 : initialNumberOfBottlesOnTheWall; } }

    }
}