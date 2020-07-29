using System;

namespace ChessEngine
{
	public class Bishop : Piece
	{
		public Bishop(Colour inColour, Square inSquare) : base(inColour, inSquare)
		{
			Name = 'B';
			Value = 3;
		}
		public override void Move(Square Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
