using System;

namespace ChessEngine
{
	public class Knight : Piece
	{
		public Knight(Colour inColour, string inSquare) : base(inColour, inSquare)
		{
			Names = 'N';
			Value = 3;
		}
		public override void Move(string Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
