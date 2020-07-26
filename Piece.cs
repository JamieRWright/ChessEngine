using System;

namespace ChessEngine
{
	public enum Colour { White = 0, Black = 1 }
	abstract public class Piece
	{
		private readonly Colour _colour;
		private int _value;
		private string _square;
		private char _name;

		public Piece(Colour inColour, string inSquare)
		{
			_colour = inColour;
			_square = inSquare;
		}

		//something to do with bit boards and dbs
		public abstract void Move(string Square, ref Board inBoard);
		
		public override string ToString()
		{
			string col = "";
			if (_colour == Colour.White)
				col = "W";
			else
				col = "B";
			return string.Concat(col, Name[0]);
		}
		public string Name
		{
			get
			{
				if (this == null)
					return "";
				else
					return this.GetType().Name;
			}
		}
		public Colour getColour
		{
			get { return _colour; }
		}
		public string Square
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
			get { return _square[0]; }
		}
		public int getRank
		{
			get { return int.Parse(_square[1].ToString()); }
		}
		public char Names
		{
			set { _name = value;}
			get { return _name; }
		}

	}
}