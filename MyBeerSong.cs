using System;
using System.Text;

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
            numberOfBottlesOnTheWall = GetNextNumberOfBottles();
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

        string GetFirstLine()
        {
            return GetFirstLineFirstSection() + GetFirstLineSecondSection();
        }

        string GetFirstLineFirstSection()
        {
            string numberOfBottles = GetStringNumberOfBottlesOnTheWall(numberOfBottlesOnTheWall, true);
            return $"{numberOfBottles} bottle{GetPluralEnding(numberOfBottlesOnTheWall)} of beer on the wall,";
        }

        string GetFirstLineSecondSection()
        {
            string numberOfBottles = GetStringNumberOfBottlesOnTheWall(numberOfBottlesOnTheWall);
            return $" {numberOfBottles} bottle{GetPluralEnding(numberOfBottlesOnTheWall)} of beer.\n";
        }

        string GetSecondLine()
        {
            return GetSecondLineFirstSection() + GetSecondLineSecondSection();
        }

        string GetSecondLineFirstSection()
        {
            if (NextNumberOfBottles == 0)
                return $"Take it down and pass it around, ";

            else if (NextNumberOfBottles == 99)
                return $"Go to the store and buy some more, ";

            return $"Take one down and pass it around, ";
        }

        string GetSecondLineSecondSection()
        {
            string numberOfBottles = GetStringNumberOfBottlesOnTheWall(NextNumberOfBottles);
            return $"{numberOfBottles} bottle{GetPluralEnding(NextNumberOfBottles)} of beer on the wall.\n";
        }

        static string GetPluralEnding(int numberOfBottles) => numberOfBottles == 1 ? "" : "s";

        static string GetStringNumberOfBottlesOnTheWall(int numberOfBottles, bool capitalise = false)
        {
            if (numberOfBottles == 0)
                if (capitalise)
                    return "No more";
                else
                    return "no more";
            else
                return numberOfBottles.ToString();
        }

        int GetNextNumberOfBottles() => numberOfBottlesOnTheWall > 0 ? numberOfBottlesOnTheWall - 1 : 99;

        int NextNumberOfBottles { get { return GetNextNumberOfBottles(); } }

    }
}