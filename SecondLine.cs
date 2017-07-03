using System;
using System.Text;

namespace BeerSong
{
    public class SecondLine : Line
    {
        private readonly int initialNumberOfBottlesOnTheWall;

        public SecondLine(int numberOfBottles, int initialNumberOfBottles) : base(numberOfBottles)
        {
            this.initialNumberOfBottlesOnTheWall = initialNumberOfBottles;
            Text = FirstSection() + SecondSection();
        }

        public static string Line(int numberOfBottles, int initialNumberOfBottles) => new SecondLine(numberOfBottles, initialNumberOfBottles).Text;

        protected override string FirstSection()
        {
            if (NumberOfBottles == 0)
                return $"Take it down and pass it around, ";

            else if (NumberOfBottles == initialNumberOfBottlesOnTheWall)
                return $"Go to the store and buy some more, ";

            return $"Take one down and pass it around, ";
        }

        protected override string SecondSection()
        {
            string numberOfBottles = StringNumberOfBottlesOnTheWall();
            return $"{numberOfBottles} bottle{PluralEnding} of beer on the wall.\n";
        }

    }
        
}