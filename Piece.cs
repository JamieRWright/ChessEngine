﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessEngine
{
	public enum Colour { White = 0, Black = 1 }
	abstract public class Piece
	{
		private Colour _colour;
		private int _value;
		private Square _square;
		private char _name;
		private ulong _currentPosition;
		private Bitmap _picture;
		private string _root;

		public Piece(Colour inColour, Square inSquare)
		{
			_root = @"C:\\Users\\piano\\Documents\\ChessEngine\\pictures\\";
			_colour = inColour;
			_square = inSquare;
			_currentPosition = generatePositionBitboard(inSquare);
			if (inColour == Colour.Black)
				Picture = new Bitmap(FileName);
			else
				Picture = new Bitmap(FileName);
			Picture.MakeTransparent(Color.White);
		}
		public Piece(Colour inColour)
		{
			_root = @"C:\\Users\\piano\\Documents\\ChessEngine\\pictures\\";
			_colour = inColour;
			if (inColour == Colour.Black)
				Picture = new Bitmap(FileName);
			else
				Picture = new Bitmap(FileName);
			Picture.MakeTransparent(Color.White);
		}

		//something to do with bit boards and dbs
		public abstract void Move(Square Square);
		public abstract ulong pieceBitboard();
		public override string ToString()
		{
			string col = "";
			if (_colour == Colour.White)
				col = "W";
			else
				col = "B";
			return string.Concat(col, Name);
		}

		public string FileName
		{
			get
			{
				if (this == null)
					return "";
				else
					return string.Concat(_root, this.Colour, this.GetType().Name,".jpg");
			}
		}
		public Colour Colour
		{
			get { return _colour; }
			set { _colour = value; }
		}
		public Square Square
		{
			get { return _square; }
			set { _square = value; }
		}
		public int Value 
		{
			get {return _value;}
			set {_value = value; }
		}
		public char getFile
		{
			get { return  _square.File.ToString()[0]; }
		}
		public int getRank
		{
			get { return _square.Rank; }
		}
		public char Name
		{
			set { _name = value;}
			get { return _name; }
		}
		public Bitmap Picture
		{
			set { _picture = value; }
			get { return _picture; }
		}
		public ulong generatePositionBitboard(Square inSquare)
		{
			ulong output = 0;
			int index = (8*inSquare.Rank)+(int)inSquare.File;
			output = (ulong) Math.Pow(2, index);
			return output;
		}
		public static ulong makeBitboard(Square inSquare)
		{
			ulong output = 0;
			int index = (8 * (inSquare.Rank-1)) + (int)inSquare.File;
			output = (ulong)Math.Pow(2, index);
			return output;
		}
		public static ulong makeBitboard(string thisstring)
		{
			Square square = null;
			//makeBitboard();
			return 0;
		}
		public static string ulongToBinary(ulong value)
		{
			string output = "0";
			if (value == 0)
				return output;
			System.Text.StringBuilder b = new System.Text.StringBuilder();
			while (value != 0)
			{
				b.Insert(0, ((value & 1) == 1) ? '1' : '0');
				value >>= 1;
			}
			return b.ToString();
		}
	}
}