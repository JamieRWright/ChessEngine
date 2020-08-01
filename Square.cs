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
        private Piece _piece;
        public Square(char inFile, int inRank, Piece inPiece = null)
        {
            _file = (Letters) (inFile%65);
            _rank = inRank;
            if (inPiece != null)
            {
                _piece = inPiece;
                _piece.Square = this;
            }
        }
        public Square(int inFile, int inRank)
        {
            _file = (Letters) inFile;
            _rank = inRank;
        }
        public int Rank { get { return _rank; } }
        public Letters File { get { return _file; } }

        public Piece Piece { get { return _piece; } set { _piece = value; } }

        public string SquareName { get { return string.Concat(File, Rank); } }

        public ulong generatePositionalBitboard()
        {
            ulong output = 0;
            int index = (8 * (this.Rank - 1)) + (int)this.File;
            output = (ulong)Math.Pow(2, index);
            return output;
        }
        public static ulong makeBitboard(char inFile, int inRank)
        {
            ulong output = 0;
            int file = (inFile % 65);
            int index = (8 * (inRank - 1)) + (int)file;
            output = (ulong)Math.Pow(2, index);
            return output;
        }
    }
}
