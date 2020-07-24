using System;

namespace ChessEngine
{
	public enum Colour { White = 0, Black = 1 }
	abstract public class Piece
	{
		private readonly Colour _colour;
		private int _value;


		public Piece(Colour inColour)
		{
			_colour = inColour;
		}
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
		public Colour GetColour
		{
			get { return _colour; }
		}

	}
}