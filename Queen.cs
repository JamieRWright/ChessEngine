using System;

namespace ChessEngine
{
	public class Queen : Piece
	{
		public Queen(Colour inColour, string inSquare) : base(inColour, inSquare)
		{
			Names = 'Q';
			Value = 9;
		}
		public override void Move(string Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}