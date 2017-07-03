using System;

namespace BeerSong
{
    public class MyBeerSong
    {
        int numberOfBottlesOnTheWall;

        public MyBeerSong(int numberOfBottlesOnTheWall = 99)
        {
            this.numberOfBottlesOnTheWall = numberOfBottlesOnTheWall;
        }

        public string NextVerse()
        {
            string verse = GetFirstLine() + GetSecondLine() + "";
            numberOfBottlesOnTheWall--;
            return verse;
        }

        public static string Verse(int numberOfBottles)
        {
            MyBeerSong song = new MyBeerSong(numberOfBottles);
            return song.NextVerse();
        }

        public static string Verses(int begin, int end)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        string GetFirstLine()
        {
            return $"{numberOfBottlesOnTheWall} bottle{GetPluralEnding(numberOfBottlesOnTheWall)} of beer on the wall, {numberOfBottlesOnTheWall} bottle{GetPluralEnding(numberOfBottlesOnTheWall)} of beer.\n";
        }

        string GetSecondLine()
        {
            return $"Take one down and pass it around, {numberOfBottlesOnTheWall - 1} bottle{GetPluralEnding(numberOfBottlesOnTheWall - 1)} of beer on the wall.\n";
        }

        static string GetPluralEnding(int numberOfBottles) => numberOfBottles == 1 ? "" : "s";

        

    }
}