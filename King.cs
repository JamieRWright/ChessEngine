using System;

namespace ChessEngine
{
	public class King : Piece
	{
		public King(Colour inColour, string inSquare) : base(inColour, inSquare)
		{
			Names = 'K';
			Value = default;
		}
		public override void Move(string Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
