using System;

namespace ChessEngine
{
	public class Bishop : Piece
	{
		public Bishop(Colour inColour) : base(inColour)
		{
			Name = 'B';
			Value = 3;
		}
		public override void Move(Square Square)
		{
			throw new NotImplementedException();
		}
	}
}
