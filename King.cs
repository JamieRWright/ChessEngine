using System;

namespace ChessEngine
{
	public class King : Piece
	{
		public King(Colour inColour) : base(inColour)
		{
			Name = 'K';
			Value = default;
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
