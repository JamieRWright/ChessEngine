using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessEngine
{
    public class Square
    {
        public enum Letters { A=0,B,C,D,E,F,G,H }
        private int _rank;
        private Letters _file;
        public Square(char inFile, int inRank)
        {
            _file = (Letters) (inFile%65);
            _rank = inRank;
        }
        public Square(int inFile, int inRank)
        {
            _file = (Letters) inFile;
            _rank = inRank;
        }
        public int Rank { get { return _rank; } }
        public Letters File { get { return _file; } }
    }
}
