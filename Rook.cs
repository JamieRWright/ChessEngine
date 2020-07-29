using System;

namespace ChessEngine
{
	public class Rook : Piece
	{
		public Rook(Colour inColour, Square inSquare) : base(inColour, inSquare)
		{
			Name = 'R';
			Value = 5;
		}
		public override void Move(Square Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
