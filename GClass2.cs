using System;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

public class GClass2
{
	public static readonly string[] string_0 = new string[4] { "Win32_BaseBoard", "Name", "Manufacturer", "Version" };

	public static readonly string[] string_1 = new string[4] { "Win32_VideoController", "Name", "DeviceID", "DriverVersion" };

	public static readonly string[] string_2 = new string[4] { "Win32_CDROMDrive", "Name", "Manufacturer", "DeviceID" };

	public static readonly string[] string_3;

	public static readonly string[] string_4;

	public static readonly string[] string_5;

	[CompilerGenerated]
	private string string_6;

	public string String_0 { get; set; }

	public string method_0(string string_7)
	{
		char[] array = string_7.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public string method_1()
	{
		string[] value = new string[3]
		{
			method_2(string_0),
			method_2(string_1),
			method_2(string_3)
		};
		String_0 = method_4(string.Join(string.Empty, value));
		return method_0(String_0);
	}

	private string method_2(string[] string_7)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", method_3(string_7));
		checked
		{
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementBaseObject current = enumerator.Current;
							ManagementObject val3 = (ManagementObject)current;
							ManagementObject val4 = val3;
							try
							{
								int num = string_7.Length - 1;
								for (int i = 1; i <= num; i++)
								{
									stringBuilder.Append(RuntimeHelpers.GetObjectValue(((ManagementBaseObject)val3)[string_7[i]]));
								}
							}
							finally
							{
								((IDisposable)val4)?.Dispose();
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return stringBuilder.ToString();
		}
	}

	private string method_3(string[] string_7)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = string.Empty;
		stringBuilder.Append("SELECT ");
		checked
		{
			int num = string_7.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append((i < string_7.Length - 1) ? (string_7[i] + ", ") : (string_7[i] + " "));
				}
				else
				{
					text = string_7[i];
				}
			}
			stringBuilder.Append("FROM " + text);
			return stringBuilder.ToString();
		}
	}

	private string method_4(string string_7)
	{
		using SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		return method_5(sHA1CryptoServiceProvider.ComputeHash(Encoding.Default.GetBytes(string_7)));
	}

	private string method_5(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = checked(byte_0.Count() - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			byte b = byte_0[i];
			int num2 = b & 0xF;
			int num3 = (byte)(b >>> 4) & 0xF;
			if (num3 <= 9)
			{
				stringBuilder.Append(num3.ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				StringBuilder stringBuilder2 = stringBuilder;
				string value = ((char)checked(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
				stringBuilder2.Append(value);
			}
			if (num2 > 9)
			{
				StringBuilder stringBuilder3 = stringBuilder;
				string value2 = ((char)checked(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture);
				stringBuilder3.Append(value2);
			}
			else
			{
				stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
			}
			if (checked(i + 1) != byte_0.Count() && checked(i + 1) % 2 == 0)
			{
				stringBuilder.Append("");
			}
		}
		return stringBuilder.ToString();
	}
}
