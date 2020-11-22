using System;

namespace ChessEngine
{
	public class Rook : Piece
	{
		public Rook(Colour inColour) : base(inColour)
		{
			Name = 'R';
			Value = 5;
		}
		public Rook(Colour inColour, Square inSquare) : base(inColour, inSquare)
		{
			Name = 'R';
			Value = 5;
		}
		public override ulong pieceBitboard()
		{
			ulong output = 0;
			for (int toggle = 1; toggle <= 2; toggle++)
			{
				for (int rankFile=1; rankFile <=8; rankFile++)
				{
					if (toggle == 1 && rankFile!=getRank)
					{
						output = output + Square.makeBitboard(getFile, rankFile);
					}
					else
					{
						Square.Letters file = (Square.Letters)(rankFile - 1);
						if (file.ToString()[0] != getFile)
							output = output + Square.makeBitboard(file.ToString()[0], getRank);
					}
				}
			}
			return output;
		}
		public override void Move(Square Square)
		{
			throw new NotImplementedException();
		}
	}
}
