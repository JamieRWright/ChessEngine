using System;

namespace ChessEngine
{
	public class Rook : Piece
	{
		public Rook(Colour inColour, string inSquare) : base(inColour, inSquare)
		{
			Names = 'R';
		}
		public override void Move(string Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}
