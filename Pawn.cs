using System;

namespace ChessEngine
{
	public class Pawn : Piece
	{
		private bool _doublePush;
		private string _startSquare, _currentSquare;
		public Pawn(Colour inColour, string inSquare) : base(inColour, inSquare)
		{
			_doublePush = true;
			_startSquare = inSquare;
			Square = inSquare;
			Names = default;
		}
		public bool hasDoublePushed
		{
			get { return _doublePush; }
		}
        public override void Move(string inSquare, ref Board inBoard)
        {
            int nextRank = int.Parse(inSquare[1].ToString());
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

