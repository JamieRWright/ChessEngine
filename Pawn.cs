 using System;
using System.Drawing;

namespace ChessEngine
{
	public class Pawn : Piece
	{
		private bool _doublePush;
		private Square _startSquare, _currentSquare;
		public Pawn(Colour inColour, Square inSquare) : base(inColour, inSquare)
		{
			_doublePush = true;
			_startSquare = inSquare;
			Name = default;
			Value = 1;
		}
		public bool hasDoublePushed
		{
			get { return _doublePush; }
		}
        public override void Move(Square inSquare, ref Board inBoard)
        {
            int nextRank = inSquare.Rank;
			int currentRank = getRank;
			int moveLength = Math.Abs(nextRank - currentRank);
			//switch (moveLength)
			//{
			//	case 2:
			//		if(canDoublePush)
			//			Square = inSquare;
			//	case 1:
			//
			//}
			if(canDoublePush && moveLength == 2)
			{
				Square = inSquare;
			}
        }
		private bool canDoublePush
		{
			get 
			{
				if (_startSquare != Square)
				{
					_doublePush = false;
				}
				return _doublePush;
			}
		}

    }
}

