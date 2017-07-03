using System;
using System.Text;

namespace BeerSong
{
    public interface ILine
    {
        int NumberOfBottles { get; }
        string Text { get; }

    }
        
}