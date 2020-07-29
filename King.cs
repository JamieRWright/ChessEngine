using System;

namespace ChessEngine
{
	public class King : Piece
	{
		public King(Colour inColour, Square inSquare) : base(inColour, inSquare)
		{
			Name = 'K';
			Value = default;
		}

		public override void Move(Square Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
