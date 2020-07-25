using System;

namespace ChessEngine
{
	public class Bishop : Piece
	{
		public Bishop(Colour inColour, string inSquare) : base(inColour, inSquare)
		{
			Names = 'B';
		}
		public override void Move(string Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
