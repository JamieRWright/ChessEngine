using System;
using ChessEngine;
using System.Text.RegularExpressions;

namespace ChessEngine
{
	public class Play
	{
		static void Main(string[] args)
		{
			Regex notation = new Regex("(K|Q|B|N|R)?[a-h]?[1-8]?(x)?[a-h][1-8]");
			Console.WriteLine(notation.IsMatch("Rdf8"));
			//Board gameBoard = new Board();
			//drawBoard(gameBoard);
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
