using System;
using System.Text;

namespace BeerSong
{
    public class FirstLine : Line
    {
        public FirstLine(int numberOfBottles) : base(numberOfBottles)
        {
            Text = FirstSection() + SecondSection();
        }

        public static string Line(int numberOfBottles) => new FirstLine(numberOfBottles).Text;

        protected override string FirstSection()
        {
            string numberOfBottles = StringNumberOfBottlesOnTheWall(true);
            return $"{numberOfBottles} bottle{PluralEnding} of beer on the wall,";
        }

        protected override string SecondSection()
        {
            string numberOfBottles = StringNumberOfBottlesOnTheWall();
            return $" {numberOfBottles} bottle{PluralEnding} of beer.\n";
        }

    }
        
}