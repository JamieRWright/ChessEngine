 using System;
using System.Drawing;

namespace ChessEngine
{
	public class Pawn : Piece
	{
		private bool _doublePush;
		private Square _currentSquare;
		private int _startRank, _movementDirection;
		public Pawn(Colour inColour) : base(inColour)
		{
			_doublePush = true;
			Colour = inColour;
			Name = default;
			Value = 1;
			if (Colour == Colour.Black)
			{
				_movementDirection = -1;
				_startRank = 7;
			}
			else
			{
				_movementDirection = 1;
				_startRank = 2;
			}
		}
		public bool hasDoublePushed
		{
			get { return !_doublePush; }
		}
		public int Direction
		{
			get { return _movementDirection; }
		}

		//Inputted square will already be validated
		public override ulong pieceBitboard()
        {
			int nextRank = getRank + Direction;
			ulong output = 0;
			output = Square.makeBitboard(getFile, nextRank);
			if (canDoublePush)
			{
				output = output + Square.makeBitboard(getFile, nextRank + 1);
			}
			return output;			
        }

		public override void Move(Square Square)
		{
			
		}
		private bool canDoublePush
		{
			get 
			{
				if ((_startRank-2)%5 != 0)
				{
					_doublePush = false;
				}
				return _doublePush;
			}
		}

		public ulong PawnBitboard(Square inSquare)
		{
			int nextRank = inSquare.Rank + Direction;
			ulong output = 0;
			output = Square.makeBitboard((char)inSquare.File, nextRank);
			if (canDoublePush)
			{
				output = output + Square.makeBitboard(getFile, nextRank + 1);
			}
			return output;
		}
	}
}

