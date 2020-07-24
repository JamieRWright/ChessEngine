using System;

namespace ChessEngine
{
    public class Board
    {
        //An array of tuples which defines the board, (Key, Value) = (SquareName, PieceOnSquare)
        private enum letters { A = 0, B, C, D, E, F, G, H}
        private Tuple<string, Piece>[,] _currentBoard;
        public Board()
        {
            _currentBoard = new Tuple<string, Piece>[8, 8];
            setupBoard(ref _currentBoard);
        }

        private void setupBoard(ref Tuple<string, Piece>[,]  inBoard)
        {
            char currentLetter;
            string squareName = "";
            for(int x = 0; x<8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    currentLetter = (char)(65 + x);
                    squareName = string.Concat(currentLetter, y + 1);
                    switch (y)
                    {
                        case 0:
                            backRow(Colour.White, 0, ref inBoard);
                            break;
                        case 1:
                            inBoard[x, y] = Tuple.Create<string, Piece>(squareName, new Pawn(Colour.White));
                            break;
                        case 6:
                            inBoard[x, y] = Tuple.Create<string, Piece>(squareName, new Pawn(Colour.Black));
                            break;
                        case 7:
                            backRow(Colour.Black, 7, ref inBoard);
                            break;
                        default:
                            inBoard[x, y] = Tuple.Create<string, Piece>(squareName, null);
                            break;
                    }
                }
            }
        }
        private void backRow(Colour inColour, int y, ref Tuple<string, Piece>[,] inBoard)
        {
            inBoard[0, y] = Tuple.Create<string, Piece>(string.Concat("A", y + 1), new Rook(inColour));
            inBoard[1, y] = Tuple.Create<string, Piece>(string.Concat("B", y + 1), new Knight(inColour));
            inBoard[2, y] = Tuple.Create<string, Piece>(string.Concat("C", y + 1), new Bishop(inColour));
            inBoard[3, y] = Tuple.Create<string, Piece>(string.Concat("D", y + 1), new Queen(inColour));
            inBoard[4, y] = Tuple.Create<string, Piece>(string.Concat("E", y + 1), new King(inColour));
            inBoard[5, y] = Tuple.Create<string, Piece>(string.Concat("F", y + 1), new Bishop(inColour));
            inBoard[6, y] = Tuple.Create<string, Piece>(string.Concat("G", y + 1), new Knight(inColour));
            inBoard[7, y] = Tuple.Create<string, Piece>(string.Concat("H", y + 1), new Rook(inColour));
        }
        public bool isSquareEmpty(string inSquareName)
        {
            if (getSquare(inSquareName) == "")
                return true;
            else
                return false;
        }        
        public string getSquare(string inSquareName)
        {
            int letter = inSquareName[0] % 65;
            int number = int.Parse(inSquareName[1].ToString()) - 1;//Minus 1 since C# indexes arrays from 0
            Piece outPiece = _currentBoard[letter, number].Item2;
            if (outPiece == null)
                return "";
            return outPiece.ToString();
        }
        public Tuple<string, Piece>[,] getBoard
        { get { return _currentBoard;} }
    }
}