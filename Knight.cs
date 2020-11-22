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

		public override void Move(Square Square)
		{
			throw new NotImplementedException();
		}
		public override ulong pieceBitboard()
		{
			throw new NotImplementedException();
		}
	}
}
