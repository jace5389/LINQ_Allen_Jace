using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Allen_Jace
{
    internal class Game
    {
        //Public string title
        public string Title { get; }
        //Public string Esrb
        public char Esrb { get; }
        //Public string Genre
        public string Genre { get; }
        //Public Game titleParam, ersbParam, genreParam
        public Game(string titleParam, char ersParam, string genreParam)
        {
            Title = titleParam;
            Esrb = ersParam;
            Genre = genreParam;
        }

    }
}
