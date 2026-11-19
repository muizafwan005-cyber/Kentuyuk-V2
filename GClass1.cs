using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class GClass1
{
	public struct GStruct0
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public long long_4;

		public long long_5;

		public long long_6;
	}

	public const int int_0 = 4096;

	public const int int_1 = 16384;

	public const int int_2 = 16384;

	public const int int_3 = 524288;

	public const int int_4 = 256;

	public const int int_5 = 64;

	public const uint uint_0 = 2035711u;

	public const int int_6 = 161;

	public const int int_7 = 256;

	public const int int_8 = 2;

	public const int int_9 = 32768;

	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, uint uint_1, out uint uint_2);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_1, uint uint_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GStruct0 gstruct0_0, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint uint_1, bool bool_0, uint uint_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, int int_10, uint uint_1, uint uint_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, int int_10, long long_0);

	[DllImport("kernel32.dll")]
	private static extern long GetLastError();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool SetWindowText(IntPtr intptr_0, ref string string_0);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, int int_10, int int_11, int int_12);

	[DllImport("user32.dll")]
	public static extern int GetAsyncKeyState(Keys keys_0);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	[DllImport("Gdi32.dll")]
	public static extern IntPtr CreateRoundRectRgn(int int_10, int int_11, int int_12, int int_13, int int_14, int int_15);

	public static int smethod_0(byte[] byte_0, byte[] byte_1)
	{
		for (int i = 0; i != byte_0.Length; i++)
		{
			int num = 0;
			for (int j = i; j < byte_0.Length && byte_0[j] == byte_1[num]; j++)
			{
				if (num == byte_1.Length - 1)
				{
					return i;
				}
				num++;
			}
		}
		return -1;
	}

	public static List<IntPtr> smethod_1(int int_10, object object_0, long long_0 = 0L, long long_1 = 4294967295L, string string_0 = "object")
	{
		List<IntPtr> list = new List<IntPtr>();
		byte[] array;
		if (string_0 == "strBytes")
		{
			string text = object_0.ToString().Replace(" ", "");
			if (text.Length % 2 != 0)
			{
				return list;
			}
			array = new byte[text.Length / 2];
			for (int i = 0; i < text.Length; i += 2)
			{
				array[i / 2] = (byte)Convert.ToInt32("0x" + text.Substring(i, 2), 16);
			}
		}
		else
		{
			array = smethod_3(object_0);
		}
		long num = long_0;
		while (num < long_1)
		{
			GStruct0 gstruct0_ = default;
			if (VirtualQueryEx(smethod_4(int_10), new IntPtr(num), out gstruct0_, (uint)Marshal.SizeOf(typeof(GStruct0))) == 0)
			{
				break;
			}
			if ((ulong)(gstruct0_.long_4 & 0x1000L) > 0uL && (gstruct0_.long_5 & 0x100L) != 256L)
			{
				byte[] array2 = new byte[gstruct0_.long_3];
				uint uint_ = 0u;
				if (ReadProcessMemory(smethod_4(int_10), new IntPtr(gstruct0_.long_0), array2, (uint)array2.Length, out uint_))
				{
					int num2 = smethod_0(array2, array);
					if (num2 != -1)
					{
						list.Add(new IntPtr(gstruct0_.long_0 + num2));
					}
				}
			}
			num = gstruct0_.long_0 + gstruct0_.long_3;
		}
		return list;
	}

	public static IntPtr smethod_2(int int_10, long long_0, long long_1, string string_0)
	{
		IntPtr intptr_ = OpenProcess(2035711u, bool_0: false, (uint)int_10);
		string[] array = string_0.Split(new char[1] { ' ' });
		int num = 0;
		int num2 = 65532;
		for (long num3 = long_0; num3 < long_1; num3 += num2)
		{
			byte[] array2 = smethod_8(intptr_, new IntPtr(num3), num2);
			for (long num4 = 0L; num4 < array2.Length; num4++)
			{
				num = ((array[num] == "XX") ? (num + 1) : ((array2[(int)(IntPtr)num4] == Convert.ToByte("0x" + array[num], 16)) ? (num + 1) : 0));
				if (num >= array.Length)
				{
					return new IntPtr(num3 + num4 - array.Length + 1L);
				}
			}
		}
		return IntPtr.Zero;
	}

	public static byte[] smethod_3(object object_0)
	{
		return object_0.GetType().ToString() switch
		{
			"System.String" => Encoding.UTF8.GetBytes(object_0.ToString()), 
			"System.Double" => BitConverter.GetBytes(Convert.ToDouble(object_0)), 
			"System.Int32" => BitConverter.GetBytes(Convert.ToInt32(object_0)), 
			"System.Single" => BitConverter.GetBytes(Convert.ToSingle(object_0)), 
			"System.Int64" => BitConverter.GetBytes(Convert.ToInt64(object_0)), 
			_ => (byte[])object_0, 
		};
	}

	public static IntPtr smethod_4(int int_10)
	{
		return OpenProcess(2035711u, bool_0: false, (uint)int_10);
	}

	public static int smethod_5(string string_0)
	{
		return Process.GetProcessesByName(string_0).FirstOrDefault().Id;
	}

	public static IntPtr smethod_6(IntPtr intptr_0, int int_10)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, int_10, 4096u, 64u);
	}

	public static IntPtr smethod_7(IntPtr intptr_0, IntPtr intptr_1, int int_10)
	{
		VirtualAllocEx(intptr_0, intptr_1, int_10, 16384u, 64u);
		VirtualFreeEx(intptr_0, intptr_1, int_10, 524288L);
		return VirtualFreeEx(intptr_0, intptr_1, int_10, 16384L);
	}

	public static byte[] smethod_8(IntPtr intptr_0, IntPtr intptr_1, int int_10 = 4)
	{
		byte[] array = new byte[int_10];
		uint uint_ = 0u;
		ReadProcessMemory(intptr_0, intptr_1, array, (uint)int_10, out uint_);
		return array;
	}

	public static void smethod_9(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0)
	{
		WriteProcessMemory(intptr_0, intptr_1, byte_0, (uint)byte_0.Length, 0u);
	}

	public static IntPtr smethod_10(IntPtr intptr_0, IntPtr intptr_1, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intPtr = intptr_1;
		for (int i = 0; i < int_11; i++)
		{
			intPtr = new IntPtr(BitConverter.ToInt32(smethod_8(intptr_0, intPtr), 0) + int_10[i]);
		}
		return intPtr;
	}

	public static long smethod_11(IntPtr intptr_0, IntPtr intptr_1, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		return BitConverter.ToInt32(smethod_8(intptr_0, intptr_2), 0);
	}

	public static int smethod_12(IntPtr intptr_0, IntPtr intptr_1, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		return BitConverter.ToInt32(smethod_8(intptr_0, intptr_2), 0);
	}

	public static float smethod_13(IntPtr intptr_0, IntPtr intptr_1, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		return BitConverter.ToSingle(smethod_8(intptr_0, intptr_2), 0);
	}

	public static string smethod_14(IntPtr intptr_0, IntPtr intptr_1, int[] int_10 = null, int int_11 = 0, int int_12 = 4)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		return Encoding.UTF8.GetString(smethod_8(intptr_0, intptr_2, int_12)).TrimEnd(new char[1]);
	}

	public static byte smethod_15(IntPtr intptr_0, IntPtr intptr_1, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		return smethod_8(intptr_0, intptr_2, 1)[0];
	}

	public static void smethod_16(IntPtr intptr_0, IntPtr intptr_1, int int_10, int[] int_11 = null, int int_12 = 0)
	{
		int_11 = int_11 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_11, int_12);
		smethod_9(intptr_0, intptr_2, BitConverter.GetBytes(int_10));
	}

	public static void smethod_17(IntPtr intptr_0, IntPtr intptr_1, float float_0, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		smethod_9(intptr_0, intptr_2, BitConverter.GetBytes(float_0));
	}

	public static void WriteWithPointer(IntPtr intptr_0, IntPtr intptr_1, byte[] bValue_To_Write, int[] int_10 = null, int int_11 = 0)
	{
		int_10 = int_10 ?? new int[0];
		IntPtr intptr_2 = smethod_10(intptr_0, intptr_1, int_10, int_11);
		smethod_9(intptr_0, intptr_2, bValue_To_Write);
	}

	public static void smethod_18(IntPtr intptr_0, IntPtr intptr_1, string string_0)
	{
		string_0 = string_0.Replace(" ", "");
		int num = 0;
		int num2 = 0;
		byte[] array = new byte[string_0.Length / 2];
		for (int i = 0; (double)i < Math.Round((double)string_0.Length / 2.0); i++)
		{
			array[num] = Convert.ToByte("0x" + string_0.Substring(num2, 2), 16);
			num++;
			num2 += 2;
		}
		smethod_9(intptr_0, intptr_1, array);
	}

	public static string smethod_19(IntPtr intptr_0)
	{
		string text = "";
		string text2 = intptr_0.ToString("X4").PadLeft(8, '0');
		for (int i = 1; i <= text2.Length / 2; i++)
		{
			text += text2.Substring(text2.Length - i * 2, 2);
		}
		return text.Substring(0, 8);
	}

	public static void smethod_20(IntPtr intptr_0, int int_10, int int_11 = 256)
	{
		SendMessage(intptr_0, 6, 1, 0);
		SendMessage(intptr_0, int_11, int_10, 0);
	}

	public static void smethod_21(IntPtr intptr_0, int int_10)
	{
		string string_ = int_10.ToString();
		SetWindowText(intptr_0, ref string_);
	}

	public static string[] smethod_22(string string_0)
	{
		string string_1 = "";
		try
		{
			string_1 = File.ReadAllText(".delb_profile_" + string_0);
		}
		catch (Exception)
		{
		}
		return GClass0.smethod_5(string_1).Split(new char[1] { '\n' });
	}

	public static void smethod_23(string string_0, List<string> list_0, string string_1)
	{
		using StreamWriter streamWriter = File.CreateText(".delb_profile_" + string_1);
		string text = string_1 + "|99|" + string_0;
		for (int i = 0; i < Enumerable.Count(list_0); i++)
		{
			text = text + "\n" + string_1 + "|" + i + "|" + list_0[i];
		}
		streamWriter.WriteLine(GClass0.smethod_4(text));
	}
}
