using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessEngine
{
	public enum Colour { White = 0, Black = 1 }
	abstract public class Piece
	{
		private readonly Colour _colour;
		private int _value;
		private Square _square;
		private char _name;
		private ulong _currentPosition;
		private Bitmap _picture;
		private string _root;

		public Piece(Colour inColour, Square inSquare)
		{
			_root = @"C:\\Users\\piano\\Documents\\ChessEngine\\pictures\\";
			_colour = inColour;
			_square = inSquare;
			_currentPosition = generatePositionBitboard(inSquare);
			if (inColour == Colour.Black)
				Picture = new Bitmap(FileName);
			else
				Picture = new Bitmap(FileName);
			Picture.MakeTransparent(Color.White);
		}

		//something to do with bit boards and dbs
		public abstract void Move(Square Square, ref Board inBoard);
		public override string ToString()
		{
			string col = "";
			if (_colour == Colour.White)
				col = "W";
			else
				col = "B";
			return string.Concat(col, Name);
		}
		public string FileName
		{
			get
			{
				if (this == null)
					return "";
				else
					return string.Concat(_root, this.getColour, this.GetType().Name,".jpg");
			}
		}
		public Colour getColour
		{
			get { return _colour; }
		}
		public Square Square
		{
			get { return _square; }
			set { _square = value; }
		}
		public int Value 
		{
			get {return _value;}
			set {_value = value; }
		}
		public char getFile
		{
			get { return (char) _square.File; }
		}
		public int getRank
		{
			get { return _square.Rank; }
		}
		public char Name
		{
			set { _name = value;}
			get { return _name; }
		}
		public Bitmap Picture
		{
			set { _picture = value; }
			get { return _picture; }
		}
		public ulong generatePositionBitboard(Square inSquare)
		{
			ulong output = 0;
			int index = (8*inSquare.Rank)+(int)inSquare.File;
			output = (ulong) Math.Pow(2, index);
			return output;
		}
		public static ulong generatePositionalBitboard(Square inSquare)
		{
			ulong output = 0;
			int index = (8 * inSquare.Rank) + (int)inSquare.File;
			output = (ulong)Math.Pow(2, index);
			return output;
		}
	}
}