using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.OpenSsl;

public class GClass0
{
	private class Class11
	{
		[CompilerGenerated]
		private Class12 class12_0;

		[JsonProperty("arta")]
		public Class12 Class12_0 { get; set; }
	}

	private class Class12
	{
		[CompilerGenerated]
		private Class14 class14_0;

		[CompilerGenerated]
		private Class13 class13_0;

		[JsonProperty("results")]
		public Class14 Class14_0 { get; set; }

		[JsonProperty("status")]
		public Class13 Class13_0 { get; set; }
	}

	private class Class13
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_1;

		[JsonProperty("error_code")]
		public int Int32_0 { get; set; }

		[JsonProperty("error_message")]
		public string String_0 { get; set; }

		[JsonProperty("message")]
		public string String_1 { get; set; }

		[JsonProperty("status_code")]
		public int Int32_1 { get; set; }
	}

	private class Class14
	{
		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private Class15 class15_0;

		[JsonProperty("data")]
		public object Object_0 { get; set; }

		[JsonProperty("user")]
		public Class15 Class15_0 { get; set; }
	}

	private class Class15
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private int int_0;

		[JsonProperty("expired_in")]
		public string String_0 { get; set; }

		[JsonProperty("user_expires")]
		public string String_1 { get; set; }

		[JsonProperty("user_level")]
		public int Int32_0 { get; set; }
	}

	private const string string_0 = "http://34.101.213.73:8111/users/account";

	private const string string_1 = "http://34.101.213.73:8111/users/secret";

	public static GClass4 smethod_0(string string_2)
	{
		GClass4 gClass = new GClass4();
		gClass.Int32_0 = 500;
		gClass.String_0 = "VVIP";
		gClass.String_1 = "1 ABAD";
		string text = "http://34.101.213.73:8111/users/secret";
		gClass.String_0 = text;
		gClass.String_0 = "THE BROTHERS";
		try
		{
			GClass2 gClass2 = new GClass2();
			_ = "?ver=4.4.1&token=6219652918&usern=" + string_2 + "&mac=" + gClass2.method_1();
		}
		catch (Exception)
		{
		}
		return gClass;
	}

	public static string smethod_1(string string_2)
	{
		char[] array = string_2.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	private static List<string> smethod_2(string string_2)
	{
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected Obj, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		try
		{
			string text = "KdB1CFA93vswMEew8nY7LKiZPyhO91lNo7c085b8P2ux2Mm6KlGpXqGrpyeE50c/";
			string text2 = "pNvpaAgvcWeJwpQpkFzdMMok+D2euZ0UhQJAFYmxRcmCfHBYo969x1+iMNoaeL/u";
			string element = "-";
			string[] array = new string[2] { "IE5J", "R0VC" };
			string s = "WUVL";
			string[] array2 = new string[3] { "QVZJ", "UlAg", "QVNS" };
			string s2 = "IEVU";
			string text3 = "/shMeDfscXxEv/fYf3idnZ5d2rciKlinzWpWkfISMhBHw1ECQQDc5W5PwYNnPA6X";
			string string_3 = "v2g63gFie6KJH4LDZlzfI66U8k5gqrp5QaHoOZ2d4E/bdmS0hCBaTEAFE3lwB5Wa";
			string s3 = "WUVL";
			string s4 = "IEVU";
			string[] array3 = new string[4] { "QVZJ", "UlAg", "QVNS", "IERO" };
			string s5 = "RQ==";
			string text4 = "==";
			string text5 = "";
			string[] array4 = array2;
			foreach (string s6 in array4)
			{
				text5 += Encoding.UTF8.GetString(Convert.FromBase64String(s6));
			}
			string text6 = "zzhLrHQbuvu5V/VBWkOB21fVexJVtC1jdBFP/fZPqFl28Iy7pOHbBlt0XQJASo9D";
			string text7 = "9XaGxcT+w/dRiPGGNSe4t2f2ekP6DCLszYglRb7kQ30jQxFzx85HzLH1AlIKKwCw";
			string text8 = "/shMeDfscXxEv/fYf3idnZ5d2rciKlinzWpWkfISMhBHw1ECQQDc5W5PwYNnPA6X";
			string text9 = "";
			string[] array5 = array;
			foreach (string s7 in array5)
			{
				text9 += Encoding.UTF8.GetString(Convert.FromBase64String(s7));
			}
			string text10 = "9XaGxcT+w/dRiPGGNSe4t2f2ekP6DCLszYglRb7kQ30jQxFzx85HzLH1AlIKKwCw";
			string text11 = "C+1ECtjb8w1/F6o1XQJAMCWYzGMs9v5az4Nu74NS9WTcKeRtb4bcobp3kYH/dZ+6";
			string text12 = "H/LDf8PCRTC54E+EvjWAk6nunMHhkmUmr7m3BSIavGa8m5QYBxRIgXJEVwIDAQAB";
			string text13 = "AoGATZYjn3Pnnvgot/Qm41eAIaC+gZfOfKQHxXBnegnj1Hl8BWwyUVwIETLNY9Fb";
			string text14 = "";
			string[] array6 = array3;
			foreach (string s8 in array6)
			{
				text14 += Encoding.UTF8.GetString(Convert.FromBase64String(s8));
			}
			string string_4 = "+qfz/z/xcEJJve5/oK78xhfY+SVgzjURhVvzmimPMLiW+a/PaDQgBKAABIwWCIIM";
			string text15 = "KdB1CFA93vswMEew8nY7LKiZPyhO91lNo7c085b8P2ux2Mm6KlGpXqGrpyeE50c/";
			string text16 = "NrxTICJxyYOMxD3hlID2LFWhEPd9cAk2oq7PDAmHv5oKogroxJwuUyAkkS2TIop0";
			string string_5 = Encoding.UTF8.GetString(Convert.FromBase64String(s)) + Encoding.UTF8.GetString(Convert.FromBase64String(s2)) + text5 + text9;
			string text17 = string.Concat(string.Concat(Enumerable.Repeat(element, 5)), smethod_1(string_5));
			string_5 = "a";
			string string_6 = "Q+DE3A79HxCtktrNXWOpVnassa2TuF6Q8jZRcVXSkB";
			string text18 = "nUgziiorAkEA/O7fgSOwSODoEVw1YRsI0jCM+zLldftCnYRF0DqN8gkQXsqKlXTf";
			text17 = string.Concat(text17, string.Concat(Enumerable.Repeat(element, 5)), "\n");
			text17 = text17 + smethod_1(string_4) + "\n" + text15 + "\n" + text12 + "\n" + text13 + "\n" + text16 + "\n" + text8 + "\n" + smethod_1(string_3) + "\n" + text18 + "\n" + text2 + "\n" + text6 + "\n" + text7 + "\n" + text11 + "\n" + smethod_1(string_6) + text4 + "\n";
			string string_7 = Encoding.UTF8.GetString(Convert.FromBase64String(s3)) + Encoding.UTF8.GetString(Convert.FromBase64String(s4)) + text14 + Encoding.UTF8.GetString(Convert.FromBase64String(s5));
			text17 = string.Concat(new string[5]
			{
				text17,
				"\n",
				string.Concat(Enumerable.Repeat(element, 5)),
				smethod_1(string_7),
				string.Concat(Enumerable.Repeat(element, 5))
			});
			string.Concat(new string[5]
			{
				string.Concat(Enumerable.Repeat(element, 5)),
				smethod_1(string_5),
				text10,
				text3,
				text
			});
			string[] array7 = string_2.Split(new char[1] { '.' });
			AsymmetricCipherKeyPair val;
			using (TextReader textReader = new StringReader(text17))
			{
				val = (AsymmetricCipherKeyPair)new PemReader(textReader).ReadObject();
			}
			text17 = "";
			string text19 = "";
			text17 += "a";
			text19 += "a";
			Pkcs1Encoding val2 = new Pkcs1Encoding((IAsymmetricBlockCipher)new RsaEngine());
			val2.Init(false, (ICipherParameters)(object)val.Private);
			List<string> list = new List<string>();
			string[] array8 = array7;
			for (int l = 0; l < array8.Length; l++)
			{
				byte[] array9 = Convert.FromBase64String(array8[l]);
				list.Add(Encoding.UTF8.GetString(val2.ProcessBlock(array9, 0, array9.Length)));
			}
			return list;
		}
		catch (Exception)
		{
			MessageBox.Show("Error decrypt", "DelB - Auth", (MessageBoxButtons)0, (MessageBoxIcon)16);
			throw;
		}
	}

	private static string smethod_3()
	{
		string text = "KdB1CFA93vswMEew8nY7LKiZPyhO91lNo7c085b8P2ux2Mm6KlGpXqGrpyeE50c/";
		string text2 = "pNvpaAgvcWeJwpQpkFzdMMok+D2euZ0UhQJAFYmxRcmCfHBYo969x1+iMNoaeL/u";
		string element = "-";
		string[] array = new string[2] { "IE5J", "R0VC" };
		string s = "WUVL";
		string[] array2 = new string[3] { "QVZJ", "UlAg", "QVNS" };
		string s2 = "IEVU";
		string text3 = "/shMeDfscXxEv/fYf3idnZ5d2rciKlinzWpWkfISMhBHw1ECQQDc5W5PwYNnPA6X";
		string string_ = "v2g63gFie6KJH4LDZlzfI66U8k5gqrp5QaHoOZ2d4E/bdmS0hCBaTEAFE3lwB5Wa";
		string s3 = "WUVL";
		string s4 = "IEVU";
		string[] array3 = new string[4] { "QVZJ", "UlAg", "QVNS", "IERO" };
		string s5 = "RQ==";
		string text4 = "==";
		string text5 = "";
		string[] array4 = array2;
		foreach (string s6 in array4)
		{
			text5 += Encoding.UTF8.GetString(Convert.FromBase64String(s6));
		}
		string text6 = "zzhLrHQbuvu5V/VBWkOB21fVexJVtC1jdBFP/fZPqFl28Iy7pOHbBlt0XQJASo9D";
		string text7 = "9XaGxcT+w/dRiPGGNSe4t2f2ekP6DCLszYglRb7kQ30jQxFzx85HzLH1AlIKKwCw";
		string text8 = "/shMeDfscXxEv/fYf3idnZ5d2rciKlinzWpWkfISMhBHw1ECQQDc5W5PwYNnPA6X";
		string text9 = "";
		string[] array5 = array;
		foreach (string s7 in array5)
		{
			text9 += Encoding.UTF8.GetString(Convert.FromBase64String(s7));
		}
		string text10 = "9XaGxcT+w/dRiPGGNSe4t2f2ekP6DCLszYglRb7kQ30jQxFzx85HzLH1AlIKKwCw";
		string text11 = "C+1ECtjb8w1/F6o1XQJAMCWYzGMs9v5az4Nu74NS9WTcKeRtb4bcobp3kYH/dZ+6";
		string text12 = "H/LDf8PCRTC54E+EvjWAk6nunMHhkmUmr7m3BSIavGa8m5QYBxRIgXJEVwIDAQAB";
		string text13 = "AoGATZYjn3Pnnvgot/Qm41eAIaC+gZfOfKQHxXBnegnj1Hl8BWwyUVwIETLNY9Fb";
		string text14 = "";
		string[] array6 = array3;
		foreach (string s8 in array6)
		{
			text14 += Encoding.UTF8.GetString(Convert.FromBase64String(s8));
		}
		string string_2 = "+qfz/z/xcEJJve5/oK78xhfY+SVgzjURhVvzmimPMLiW+a/PaDQgBKAABIwWCIIM";
		string text15 = "KdB1CFA93vswMEew8nY7LKiZPyhO91lNo7c085b8P2ux2Mm6KlGpXqGrpyeE50c/";
		string text16 = "NrxTICJxyYOMxD3hlID2LFWhEPd9cAk2oq7PDAmHv5oKogroxJwuUyAkkS2TIop0";
		string string_3 = Encoding.UTF8.GetString(Convert.FromBase64String(s)) + Encoding.UTF8.GetString(Convert.FromBase64String(s2)) + text5 + text9;
		string text17 = string.Concat(string.Concat(Enumerable.Repeat(element, 5)), smethod_1(string_3));
		string_3 = "a";
		string string_4 = "Q+DE3A79HxCtktrNXWOpVnassa2TuF6Q8jZRcVXSkB";
		string text18 = "nUgziiorAkEA/O7fgSOwSODoEVw1YRsI0jCM+zLldftCnYRF0DqN8gkQXsqKlXTf";
		text17 = string.Concat(text17, string.Concat(Enumerable.Repeat(element, 5)), "\n");
		text17 = text17 + smethod_1(string_2) + "\n" + text15 + "\n" + text12 + "\n" + text13 + "\n" + text16 + "\n" + text8 + "\n" + smethod_1(string_) + "\n" + text18 + "\n" + text2 + "\n" + text6 + "\n" + text7 + "\n" + text11 + "\n" + smethod_1(string_4) + text4 + "\n";
		string string_5 = Encoding.UTF8.GetString(Convert.FromBase64String(s3)) + Encoding.UTF8.GetString(Convert.FromBase64String(s4)) + text14 + Encoding.UTF8.GetString(Convert.FromBase64String(s5));
		text17 = string.Concat(new string[5]
		{
			text17,
			"\n",
			string.Concat(Enumerable.Repeat(element, 5)),
			smethod_1(string_5),
			string.Concat(Enumerable.Repeat(element, 5))
		});
		string.Concat(new string[5]
		{
			string.Concat(Enumerable.Repeat(element, 5)),
			smethod_1(string_3),
			text10,
			text3,
			text
		});
		return text17;
	}

	public static string smethod_4(string string_2)
	{
		string text = smethod_3();
		string[] array = string_2.Split(new char[1] { '\n' });
		string text2 = "";
		string[] array2 = array;
		foreach (string string_3 in array2)
		{
			text2 = text2 + Convert.ToBase64String(smethod_6(string_3, Encoding.UTF8.GetBytes(text.Substring(100, 16)), Encoding.UTF8.GetBytes(text.Substring(210, 16)))) + "\n";
		}
		return text2;
	}

	public static string smethod_5(string string_2)
	{
		string text = smethod_3();
		string[] array = string_2.Split(new char[1] { '\n' });
		string text2 = "";
		string[] array2 = array;
		foreach (string text3 in array2)
		{
			if (text3.Length > 1)
			{
				byte[] byte_ = Convert.FromBase64String(text3);
				text2 = text2 + smethod_7(byte_, Encoding.UTF8.GetBytes(text.Substring(100, 16)), Encoding.UTF8.GetBytes(text.Substring(210, 16))) + "\n";
			}
		}
		return text2;
	}

	private static byte[] smethod_6(string string_2, byte[] byte_0, byte[] byte_1)
	{
		if (string_2 == null || string_2.Length <= 0)
		{
			throw new ArgumentNullException("plainText");
		}
		if (byte_0 != null && byte_0.Length != 0)
		{
			if (byte_1 != null && byte_1.Length != 0)
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.Key = byte_0;
					rijndaelManaged.IV = byte_1;
					ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using MemoryStream memoryStream = new MemoryStream();
					using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(string_2);
					}
					return memoryStream.ToArray();
				}
			}
			throw new ArgumentNullException("IV");
		}
		throw new ArgumentNullException("Key");
	}

	private static string smethod_7(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (byte_1 != null && byte_1.Length != 0)
		{
			if (byte_2 != null && byte_2.Length != 0)
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.Key = byte_1;
					rijndaelManaged.IV = byte_2;
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using MemoryStream stream = new MemoryStream(byte_0);
					using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
					using StreamReader streamReader = new StreamReader(stream2);
					return streamReader.ReadToEnd();
				}
			}
			throw new ArgumentNullException("IV");
		}
		throw new ArgumentNullException("Key");
	}
}
