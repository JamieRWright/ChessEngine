using System;

namespace ChessEngine
{
	public class Queen : Piece
	{

        public Queen(Colour inColour) : base(inColour)
        {
			Name = 'Q';
			Value = 9;
		}

        public override void Move(Square Square, ref Board inBoard)
		{
			throw new NotImplementedException();
		}
	}
}