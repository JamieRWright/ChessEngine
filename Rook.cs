using System;

namespace ChessEngine
{
	public class Rook : Piece
	{
		public Rook(Colour inColour) : base(inColour)
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
