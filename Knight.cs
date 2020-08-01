using System;

namespace ChessEngine
{
	public class Knight : Piece
	{
		public Knight(Colour inColour) : base(inColour)
		{
			Name = 'N';
			Value = 3;
		}

		public override void Move(Square Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
