using System;
using System.Text.RegularExpressions;

public class Notation
{
	public Notation()
	{
	}
	public bool isValid(string inMove)
    {
		Regex notation = new Regex("(K|Q|B|N|R)?[a-h][1-8]");

	}
}
