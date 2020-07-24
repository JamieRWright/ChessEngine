using System;
using ChessEngine;

namespace ChessEngine
{
	public class Play
	{
		static void Main(string[] args)
		{
			Board gameBoard = new Board();
			drawBoard(gameBoard);
		}
		static void drawBoard(Board inBoard)
		{
			for (int col = 7; col >= 0; col--)
			{
				for (int row = 0; row < 8; row++)
					Console.Write(String.Format("{0}\t", inBoard.getBoard[row, col].Item2));
				Console.WriteLine();
			}
			Console.Read();
		}
    }
}
