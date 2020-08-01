using System;
using System.Drawing;

namespace ChessEngine
{
    public static class Board
    {
        //An array of tuples which defines the board, (Key, Value) = (SquareName, PieceOnSquare)
        public static Square[,] BoardState = SetupBoard();

        public static Square[,] getBoard
        { get { return BoardState; } }

        public static bool isSquareEmpty(string inSquareName)
        {
            if (getPiece(inSquareName) == "")
                return true;
            else
                return false;
        }        
        public static string getPiece(string inSquareName)
        {
            int letter = inSquareName[0] % 65;
            int number = int.Parse(inSquareName[1].ToString()) - 1;//Minus 1 since C# indexes arrays from 0
            Piece outPiece = BoardState[letter, number].Piece;
            if (outPiece == null)
                return "";
            return outPiece.ToString();
        }

        public static Square getSquare(string inSquareName)
        {
            int letter = inSquareName[0] % 65;
            int number = int.Parse(inSquareName[1].ToString()) - 1;//Minus 1 since C# indexes arrays from 0
            return BoardState[letter, number];
        }
        public static void updatePosition(string move)
        {
        }
        public static void drawBoard()
        {
            for (int col = 7; col >= 0; col--)
            {
                for (int row = 0; row < 8; row++)
                    Console.Write(String.Format("{0}\t", BoardState[row, col].Piece));
                Console.WriteLine();
            }
            Console.Read();
        }
        private static Square[,] SetupBoard()
        {
            Square[,] inBoard = new Square[8, 8];
            char currentLetter;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    currentLetter = (char)(65 + x);
                    Square square = new Square(currentLetter, y + 1);
                    switch (y)
                    {
                        case 0:
                            backRank(Colour.White, 0, ref inBoard);
                            break;
                        case 1:
                            square.Piece = new Pawn(Colour.White);
                            inBoard[x, y] = square;
                            break;
                        case 6:
                            square.Piece = new Pawn(Colour.Black);
                            inBoard[x, y] = square;
                            break;
                        case 7:
                            backRank(Colour.Black, 7, ref inBoard);
                            break;
                        default:
                            inBoard[x, y] = square;
                            break;
                    }
                }
            }
            return inBoard;
        }
        private static void backRank(Colour inColour, int y, ref Square[,] inBoard)
        {
            //Ew
            inBoard[0, y] = new Square('A', y + 1, new Rook(inColour));
            inBoard[1, y] = new Square('B', y + 1, new Knight(inColour));
            inBoard[2, y] = new Square('C', y + 1, new Bishop(inColour));
            inBoard[3, y] = new Square('D', y + 1, new Queen(inColour));
            inBoard[4, y] = new Square('E', y + 1, new King(inColour));
            inBoard[5, y] = new Square('F', y + 1, new Bishop(inColour));
            inBoard[6, y] = new Square('G', y + 1, new Knight(inColour));
            inBoard[7, y] = new Square('H', y + 1, new Rook(inColour));
        }
    }
}