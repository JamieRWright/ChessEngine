﻿using System;
using System.Drawing;

namespace ChessEngine
{
    public class Board
    {
        //An array of tuples which defines the board, (Key, Value) = (SquareName, PieceOnSquare)
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
                    Square square = new Square(currentLetter, y + 1);
                    switch (y)
                    {
                        case 0:
                            backRow(Colour.White, 0, ref inBoard);
                            break;
                        case 1:
                            inBoard[x, y] = Tuple.Create<string, Piece>(squareName, new Pawn(Colour.White, square));
                            break;
                        case 6:
                            inBoard[x, y] = Tuple.Create<string, Piece>(squareName, new Pawn(Colour.Black, square));
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
            //Ew
            inBoard[0, y] = Tuple.Create<string, Piece>(string.Concat("A", y + 1), new Rook(inColour, new Square('A', y + 1)));
            inBoard[1, y] = Tuple.Create<string, Piece>(string.Concat("B", y + 1), new Knight(inColour, new Square('B', y + 1)));
            inBoard[2, y] = Tuple.Create<string, Piece>(string.Concat("C", y + 1), new Bishop(inColour, new Square('C', y + 1)));
            inBoard[3, y] = Tuple.Create<string, Piece>(string.Concat("D", y + 1), new Queen(inColour, new Square('D', y + 1)));
            inBoard[4, y] = Tuple.Create<string, Piece>(string.Concat("E", y + 1), new King(inColour, new Square('E', y + 1)));
            inBoard[5, y] = Tuple.Create<string, Piece>(string.Concat("F", y + 1), new Bishop(inColour, new Square('F', y + 1)));
            inBoard[6, y] = Tuple.Create<string, Piece>(string.Concat("G", y + 1), new Knight(inColour, new Square('G', y + 1)));
            inBoard[7, y] = Tuple.Create<string, Piece>(string.Concat("H", y + 1), new Rook(inColour, new Square('H', y + 1)));
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
        public void updatePosition(string move)
        {
        }
        public Tuple<string, Piece>[,] getBoard
        { get { return _currentBoard;} }
        public void drawBoard()
        {
            for (int col = 7; col >= 0; col--)
            {
                for (int row = 0; row < 8; row++)
                    Console.Write(String.Format("{0}\t", _currentBoard[row, col].Item2));
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}