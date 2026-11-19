using System;
using System.Globalization;
using System.Linq;

namespace RFSNCS.Memory;

public class Addr
{
	public static string Make(byte[] buffer)
	{
		string text = "";
		for (int i = 0; i < buffer.Length; i++)
		{
			text = ((Convert.ToInt16(buffer[i]) >= 10) ? (ToHex(buffer[i]) + text) : ("0" + ToHex(buffer[i]) + text));
		}
		return text;
	}

	public static string ToHex(int Decimal)
	{
		return Decimal.ToString("X");
	}

	public static int ToDec(string Hex)
	{
		return int.Parse(Hex, NumberStyles.HexNumber);
	}

	public static byte[] StringToByteArray(string hex)
	{
		return (from x in Enumerable.Range(0, hex.Length)
			where x % 2 == 0
			select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
	}
}
