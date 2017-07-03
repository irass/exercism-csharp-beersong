using System;
using System.Text;

namespace BeerSong
{
    public class Line : ILine
    {
        public int NumberOfBottles { get; private set; }
        public string Text { get; protected set; }

        public Line(int numberOfBottles)
        {
            NumberOfBottles = numberOfBottles;
        }

        protected virtual string FirstSection()
        {
            throw new NotImplementedException();
        }

        protected virtual string SecondSection()
        {
            throw new NotImplementedException();
        }

        protected string PluralEnding { get { return NumberOfBottles == 1 ? "" : "s"; } }

        protected string StringNumberOfBottlesOnTheWall(bool capitalise = false)
        {
            if (NumberOfBottles == 0)
                if (capitalise)
                    return "No more";
                else
                    return "no more";
            else
                return NumberOfBottles.ToString();
        }

    }
        
}