using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass6
{
	public long MaxAddress = Convert.ToInt32("0xffffffff", 16);

	private GClass5 gclass5_0;

	[CompilerGenerated]
	private Process process_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private IntPtr intptr_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private GClass3 gclass3_0;

	[CompilerGenerated]
	private CheckBox checkBox_0;

	[CompilerGenerated]
	private Timer timer_0;

	[CompilerGenerated]
	private Timer timer_1;

	[CompilerGenerated]
	private Timer timer_2;

	[CompilerGenerated]
	private Timer timer_3;

	[CompilerGenerated]
	private Timer timer_4;

	[CompilerGenerated]
	private BackgroundWorker backgroundWorker_0;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private bool bool_7;

	[CompilerGenerated]
	private bool bool_8;

	[CompilerGenerated]
	private bool bool_9;

	[CompilerGenerated]
	private bool bool_10;

	[CompilerGenerated]
	private bool bool_11;

	[CompilerGenerated]
	private bool bool_12;

	[CompilerGenerated]
	private bool bool_13;

	[CompilerGenerated]
	private bool bool_14;

	[CompilerGenerated]
	private bool bool_15;

	[CompilerGenerated]
	private bool bool_16;

	[CompilerGenerated]
	private bool bool_17;

	[CompilerGenerated]
	private bool bool_18;

	[CompilerGenerated]
	private bool bool_19;

	[CompilerGenerated]
	private bool bool_20;

	[CompilerGenerated]
	private bool bool_21;

	[CompilerGenerated]
	private bool bool_22;

	[CompilerGenerated]
	private bool bool_23;

	[CompilerGenerated]
	private bool bool_24;

	[CompilerGenerated]
	private bool bool_25;

	[CompilerGenerated]
	private bool bool_26;

	[CompilerGenerated]
	private bool bool_27;

	[CompilerGenerated]
	private bool bool_28;

	[CompilerGenerated]
	private bool bool_29;

	[CompilerGenerated]
	private bool bool_30;

	[CompilerGenerated]
	private bool bool_31;

	[CompilerGenerated]
	private bool bool_32;

	[CompilerGenerated]
	private bool bool_33;

	[CompilerGenerated]
	private bool bool_34;

	[CompilerGenerated]
	private bool bool_35;

	[CompilerGenerated]
	private bool bool_36;

	[CompilerGenerated]
	private bool bool_37;

	[CompilerGenerated]
	private bool bool_38;

	[CompilerGenerated]
	private bool bool_39;

	[CompilerGenerated]
	private bool bool_40;

	[CompilerGenerated]
	private bool bool_41;

	[CompilerGenerated]
	private bool bool_42;

	[CompilerGenerated]
	private bool bool_43;

	[CompilerGenerated]
	private bool bool_44;

	[CompilerGenerated]
	private float float_0;

	[CompilerGenerated]
	private float float_1;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private List<int> list_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private int int_5;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private int int_6;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private int int_7;

	[CompilerGenerated]
	private float float_2;

	[CompilerGenerated]
	private float float_3;

	[CompilerGenerated]
	private float float_4;

	[CompilerGenerated]
	private List<Label> list_1;

	[CompilerGenerated]
	private List<string> list_2;

	private IntPtr intptr_1 = IntPtr.Zero;

	private IntPtr intptr_2 = IntPtr.Zero;

	private IntPtr intptr_3 = IntPtr.Zero;

	private IntPtr intptr_4 = IntPtr.Zero;

	private IntPtr intptr_5 = IntPtr.Zero;

	private IntPtr intptr_6 = IntPtr.Zero;

	private IntPtr intptr_7 = IntPtr.Zero;

	private IntPtr intptr_8 = IntPtr.Zero;

	private IntPtr intptr_9 = IntPtr.Zero;

	private IntPtr intptr_10 = IntPtr.Zero;

	private IntPtr intptr_11 = IntPtr.Zero;

	private IntPtr intptr_12 = new IntPtr(5996128);

	private IntPtr intptr_13 = IntPtr.Zero;

	private IntPtr intptr_14 = new IntPtr(4409472);

	private IntPtr intptr_15 = IntPtr.Zero;

	private IntPtr intptr_16 = IntPtr.Zero;

	private IntPtr intptr_17 = IntPtr.Zero;

	private IntPtr intptr_18 = IntPtr.Zero;

	private IntPtr intptr_19 = IntPtr.Zero;

	private IntPtr intptr_20 = IntPtr.Zero;

	private IntPtr intptr_21 = IntPtr.Zero;

	private IntPtr eagleEyeAdvAddrTemp = IntPtr.Zero;

	private IntPtr intptr_22 = IntPtr.Zero;

	private IntPtr intptr_23 = IntPtr.Zero;

	private bool bool_45;

	private int int_8;

	private int int_9 = -1;

	private double double_0 = 99999999.0;

	private GClass3 gclass3_1 = new GClass3();

	private int int_10;

	private IntPtr extendViewAddressTemp = IntPtr.Zero;

	private string restoreExtendViewAddress = string.Empty;

	public string string_4 = "";

	public string string_5 = "";

	public string string_6 = "";

	private bool bool_49;

	public Process Process_0 { get; set; }

	public bool Boolean_0 { get; set; }

	public IntPtr IntPtr_0 { get; set; }

	public IntPtr BaseAddress { get; set; }

	public bool Boolean_1 { get; set; }

	public GClass3 GClass3_0 { get; set; }

	public CheckBox CheckBox_0 { get; set; }

	public Timer Timer_0 { get; set; }

	public Timer CommonTimer { get; set; }

	public Timer Timer_1 { get; set; }

	public Timer Timer_2 { get; set; }

	public Timer Timer_3 { get; set; }

	public Timer Timer_4 { get; set; }

	public BackgroundWorker BackgroundWorker_0 { get; set; }

	public bool Boolean_2 { get; set; }

	public bool Boolean_3 { get; set; }

	public bool Boolean_4 { get; set; }

	public bool IsExtremeASPD { get; set; }

	public bool Boolean_5 { get; set; }

	public bool Boolean_6 { get; set; }

	public bool Boolean_7 { get; set; }

	public bool Boolean_8 { get; set; }

	public bool Boolean_9 { get; set; }

	public bool Boolean_10 { get; set; }

	public bool Boolean_11 { get; set; }

	public bool Boolean_12 { get; set; }

	public bool Boolean_13 { get; set; }

	public bool Boolean_14 { get; set; }

	public bool Boolean_15 { get; set; }

	public bool Boolean_16 { get; set; }

	public bool Boolean_17 { get; set; }

	public bool Boolean_18 { get; set; }

	public bool Boolean_19 { get; set; }

	public bool Boolean_20 { get; set; }

	public bool Boolean_21 { get; set; }

	public bool Boolean_22 { get; set; }

	public bool Boolean_23 { get; set; }

	public bool Boolean_24 { get; set; }

	public bool Boolean_25 { get; set; }

	public bool Boolean_26 { get; set; }

	public bool Boolean_27 { get; set; }

	public bool Boolean_28 { get; set; }

	public bool Boolean_29 { get; set; }

	public bool Boolean_30 { get; set; }

	public bool Boolean_31 { get; set; }

	public bool Boolean_32 { get; set; }

	public bool Boolean_33 { get; set; }

	public bool Boolean_34 { get; set; }

	public bool Boolean_35 { get; set; }

	public bool Boolean_36 { get; set; }

	public bool Boolean_37 { get; set; }

	public bool Boolean_38 { get; set; }

	public bool Boolean_39 { get; set; }

	public bool Boolean_40 { get; set; }

	public bool Boolean_41 { get; set; }

	public bool Boolean_42 { get; set; }

	public bool Boolean_43 { get; set; }

	public bool Boolean_44 { get; set; }

	public float Single_0 { get; set; }

	public float Single_1 { get; set; }

	public int Int32_0 { get; set; } = 410;

	public int Int32_1 { get; set; }

	public int Int32_2 { get; set; }

	public int Int32_3 { get; set; }

	public int Int32_4 { get; set; }

	public List<int> List_0 { get; set; } = new List<int>();

	public string String_0 { get; set; }

	public string String_1 { get; set; }

	public int Int32_5 { get; set; } = 2000;

	public string String_2 { get; set; } = "";

	public int Int32_6 { get; set; }

	public string String_3 { get; set; } = "Off";

	public int Int32_7 { get; set; } = 200;

	public float Single_2 { get; set; }

	public float Single_3 { get; set; }

	public float Single_4 { get; set; }

	public bool IsAutoTabMonster { get; set; }

	public List<Label> List_1 { get; set; } = new List<Label>();

	public List<string> List_2 { get; set; } = new List<string>();

	public GClass6(Process process_1)
	{
		Process_0 = process_1;
		try
		{
			IntPtr_0 = GClass1.smethod_4(Process_0.Id);
			BaseAddress = GClass1.smethod_4(Process_0.Id);
			if (IntPtr_0 == IntPtr.Zero)
			{
				Boolean_1 = true;
			}
		}
		catch (Exception)
		{
			Boolean_1 = true;
		}
		gclass5_0 = new GClass5();
		GClass3_0 = new GClass3();
		method_0();
		method_1();
	}

	public void method_0()
	{
		gclass5_0.IntPtr_0 = new IntPtr(Convert.ToInt32("0x0238cfbc", 16));
		gclass5_0.IntPtr_1 = new IntPtr(Convert.ToInt32("0x44288f", 16));
		gclass5_0.IntPtr_2 = new IntPtr(Convert.ToInt32("0xa42f0c", 16));
		gclass5_0.IntPtr_3 = new IntPtr(Convert.ToInt32("0x41a1ce", 16));
		gclass5_0.IntPtr_4 = new IntPtr(Convert.ToInt32("0x5403ef", 16));
		gclass5_0.IntPtr_5 = new IntPtr(Convert.ToInt32("0x99440c", 16));
		gclass5_0.IntPtr_6 = new IntPtr(Convert.ToInt32("0x46668d", 16));
		gclass5_0.IntPtr_7 = new IntPtr(Convert.ToInt32("0x43fcb0", 16));
		gclass5_0.IntPtr_8 = new IntPtr(Convert.ToInt32("0x438350", 16));
		gclass5_0.IntPtr_9 = new IntPtr(Convert.ToInt32("0x454949", 16));
		gclass5_0.IntPtr_10 = new IntPtr(Convert.ToInt32("0x400000", 16));
		gclass5_0.IntPtr_11 = new IntPtr(Convert.ToInt32("0xF41214", 16));
		gclass5_0.IntPtr_12 = new IntPtr(Convert.ToInt32("0x238cfc8", 16));
		gclass5_0.IntPtr_13 = new IntPtr(Convert.ToInt32("0x238cfcc", 16));
		gclass5_0.IntPtr_14 = new IntPtr(Convert.ToInt32("0x238cfe8", 16));
		gclass5_0.IntPtr_15 = new IntPtr(Convert.ToInt32("0x238cfd8", 16));
		gclass5_0.IntPtr_16 = new IntPtr(Convert.ToInt32("0x238cfdc", 16));
		gclass5_0.IntPtr_17 = new IntPtr(Convert.ToInt32("0x5f0770", 16));
		gclass5_0.IntPtr_18 = new IntPtr(Convert.ToInt32("0x233b5dc", 16));
		gclass5_0.IntPtr_19 = new IntPtr(Convert.ToInt32("0x52284d", 16));
		gclass5_0.IntPtr_20 = new IntPtr(Convert.ToInt32("0x23db098", 16));
		gclass5_0.IntPtr_21 = new IntPtr(Convert.ToInt32("0x40fcde", 16));
		gclass5_0.IntPtr_28 = new IntPtr(Convert.ToInt32("0x369feeb", 16));
		gclass5_0.IntPtr_29 = new IntPtr(Convert.ToInt32("0x369fe50", 16));
		gclass5_0.IntPtr_30 = new IntPtr(Convert.ToInt32("0x418d76", 16));
		gclass5_0.IntPtr_32 = new IntPtr(Convert.ToInt32("0x40ff07", 16));
		gclass5_0.IntPtr_32 = new IntPtr(Convert.ToInt32("0x40ff07", 16));
		gclass5_0.eagleEyeAdvAddr = new IntPtr(Convert.ToInt32("0x004F80BC", 16));
		gclass5_0.IntPtr_31 = new IntPtr(5996125);
		gclass5_0.IntPtr_33 = new IntPtr(4540544);
		gclass5_0.BaseAddress = new IntPtr(Convert.ToInt32("0x01F8CFBC", 16));
		gclass5_0.IntPtr_34 = new IntPtr(Convert.ToInt32("0x0041015F", 16));
		gclass5_0.ButtonDelayAddress = new IntPtr(Convert.ToInt32("0x00528851", 16));
		gclass5_0.ButtonDelayAddress2 = new IntPtr(Convert.ToInt32("0x005288F0", 16));
		gclass5_0.extendViewAddress = new IntPtr(Convert.ToInt32("0x00A49D24", 16));
		gclass5_0.extendViewAddress2 = new IntPtr(Convert.ToInt32("0x004F99A2", 16));
		gclass5_0.IntPtr_35 = new IntPtr(4551722);
		gclass5_0.IntPtr_36 = new IntPtr(4216951);
		gclass5_0.IntPtr_37 = new IntPtr(5210300);
		gclass5_0.IntPtr_38 = new IntPtr(4422165);
		gclass5_0.IntPtr_39 = new IntPtr(4422101);
		gclass5_0.IntPtr_40 = new IntPtr(4435363);
		gclass5_0.ExtremeASPDAddrPointer = Convert.ToInt32("0x253", 16);
		gclass5_0.Int32_0 = Convert.ToInt32("0x10", 16);
		gclass5_0.Int32_1 = Convert.ToInt32("0x4024", 16);
		gclass5_0.Int32_2 = Convert.ToInt32("0x94", 16);
		gclass5_0.Int32_3 = Convert.ToInt32("0x5e8", 16);
		gclass5_0.Int32_4 = Convert.ToInt32("0x4020", 16);
		gclass5_0.Int32_5 = Convert.ToInt32("0x0", 16);
		gclass5_0.Int32_6 = Convert.ToInt32("0x5fc", 16);
		gclass5_0.Int32_7 = Convert.ToInt32("0x600", 16);
		gclass5_0.Int32_8 = Convert.ToInt32("0x5f9", 16);
		gclass5_0.Int32_9 = Convert.ToInt32("0x60a", 16);
		gclass5_0.Int32_10 = Convert.ToInt32("0x5fa", 16);
		gclass5_0.Int32_11 = Convert.ToInt32("0x40d8", 16);
		gclass5_0.Int32_12 = Convert.ToInt32("0x3d52", 16);
		gclass5_0.Int32_13 = Convert.ToInt32("0x550", 16);
		gclass5_0.Int32_14 = Convert.ToInt32("0x560", 16);
		gclass5_0.Int32_15 = Convert.ToInt32("0x554", 16);
		gclass5_0.Int32_16 = Convert.ToInt32("0x564", 16);
		gclass5_0.Int32_17 = Convert.ToInt32("0x568", 16);
		gclass5_0.Int32_18 = Convert.ToInt32("0x55c", 16);
		gclass5_0.Int32_19 = Convert.ToInt32("0x250", 16);
		gclass5_0.Int32_20 = Convert.ToInt32("0x254", 16);
		gclass5_0.Int32_21 = Convert.ToInt32("0x3ec7e3", 16) * -1;
		gclass5_0.Int32_22 = Convert.ToInt32(22788);
		gclass5_0.Int32_23 = Convert.ToInt32("0x38", 16);
		gclass5_0.Int32_24 = Convert.ToInt32("0x50", 16);
		gclass5_0.Int32_25 = Convert.ToInt32("0x54", 16);
		gclass5_0.Int32_26 = Convert.ToInt32("0x58", 16);
		gclass5_0.Int32_27 = Convert.ToInt32("0x48", 16);
		gclass5_0.Int32_28 = Convert.ToInt32("0x0", 16);
		gclass5_0.Int32_29 = Convert.ToInt32("0x8", 16);
		gclass5_0.Int32_30 = Convert.ToInt32("0x10", 16);
		gclass5_0.Int32_31 = Convert.ToInt32("0x18", 16);
		gclass5_0.Int32_32 = Convert.ToInt32("0x20", 16);
		gclass5_0.Int32_33 = Convert.ToInt32("0x28", 16);
		gclass5_0.Int32_34 = Convert.ToInt32("0x30", 16);
		gclass5_0.Int32_35 = Convert.ToInt32("0x38", 16);
		gclass5_0.Int32_36 = Convert.ToInt32("0x40", 16);
		gclass5_0.Int32_37 = Convert.ToInt32("0x48", 16);
		gclass5_0.Int32_38 = Convert.ToInt32("0x253", 16);
		gclass5_0.Int32_39 = Convert.ToInt32("0x80", 16);
		gclass5_0.Int32_40 = Convert.ToInt32("0x33c", 16);
		gclass5_0.Int32_41 = Convert.ToInt32("0x76", 16);
		gclass5_0.Int32_42 = Convert.ToInt32("0x534", 16);
		gclass5_0.Int32_43 = 789317081;
		gclass5_0.Boolean_0 = false;
		gclass5_0.String_0 = "F3 0F 10 05 0C 2F A4 00";
		gclass5_0.String_1 = "0F B6 8E F9 05 00 00 88 4D CE";
		gclass5_0.String_2 = "41 20 70 6F 77 65 72 66 75 6C 20 73 74 61 62 20 61 74 20 74 68 65 20 74 61 72 67 65 74 27 73 20 76 69 74 61 6C 73 3B 20 6D 75 73 74 20 62 65 20 64 6F 6E 65 20 66 72 6F 6D 20 68 69 64 69 6E 67 2E";
		if (GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_1) == 99910105)
		{
			gclass5_0.Boolean_0 = true;
			gclass5_0.IntPtr_0 = new IntPtr(Convert.ToInt32("0x027bb9a0", 16));
			gclass5_0.IntPtr_2 = new IntPtr(Convert.ToInt32("0xa9a8dc", 16));
			gclass5_0.IntPtr_20 = new IntPtr(Convert.ToInt32("0x28a0130", 16));
			gclass5_0.IntPtr_3 = new IntPtr(Convert.ToInt32("0x41d8fd", 16));
			gclass5_0.IntPtr_33 = new IntPtr(4602515);
			gclass5_0.IntPtr_38 = new IntPtr(4470984);
			gclass5_0.IntPtr_39 = new IntPtr(4470920);
			gclass5_0.IntPtr_40 = new IntPtr(4485384);
			gclass5_0.Int32_1 = 16452;
			gclass5_0.Int32_2 = Convert.ToInt32("0x94", 16);
			gclass5_0.Int32_3 = Convert.ToInt32("0x5f4", 16);
			gclass5_0.Int32_4 = Convert.ToInt32("0x4040", 16);
			gclass5_0.Int32_6 = Convert.ToInt32("0x608", 16);
			gclass5_0.Int32_7 = Convert.ToInt32("0x60c", 16);
			gclass5_0.Int32_8 = Convert.ToInt32("0x605", 16);
			gclass5_0.Int32_9 = Convert.ToInt32("0x616", 16);
			gclass5_0.Int32_10 = Convert.ToInt32("0x606", 16);
			gclass5_0.Int32_11 = Convert.ToInt32("0x40f8", 16);
			gclass5_0.Int32_12 = Convert.ToInt32("0x3f00", 16);
			gclass5_0.Int32_13 = Convert.ToInt32("0x55c", 16);
			gclass5_0.Int32_14 = Convert.ToInt32("0x56c", 16);
			gclass5_0.Int32_15 = Convert.ToInt32("0x560", 16);
			gclass5_0.Int32_16 = Convert.ToInt32("0x570", 16);
			gclass5_0.Int32_17 = Convert.ToInt32("0x574", 16);
			gclass5_0.Int32_18 = Convert.ToInt32("0x568", 16);
			gclass5_0.Int32_43 = -1461975591;
		}
		if (intptr_23 == IntPtr.Zero)
		{
			intptr_23 = GClass1.smethod_6(IntPtr_0, 4095);
		}
		if (intptr_22 == IntPtr.Zero)
		{
			intptr_22 = GClass1.smethod_6(IntPtr_0, 4095);
		}
	}

	public void method_1()
	{
		GetCurrentUserInfo(GClass3_0, gclass5_0.IntPtr_0);
	}

	public void GetCurrentUserInfo(GClass3 gclass3_2, IntPtr intptr_24)
	{
		gclass3_2.String_0 = GClass1.smethod_14(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_0 }, 1, 32);
		gclass3_2.Int32_0 = GClass1.smethod_15(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_1 }, 1);
		gclass3_2.Int32_1 = GClass1.smethod_15(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_4 }, 1);
		gclass3_2.String_1 = "Accretia";
		gclass3_2.String_2 = "M";
		if (gclass3_2.Int32_1 == 0)
		{
			gclass3_2.String_1 = "Bellato";
			gclass3_2.String_2 = "M";
		}
		if (gclass3_2.Int32_1 == 1)
		{
			gclass3_2.String_1 = "Bellato";
			gclass3_2.String_2 = "F";
		}
		if (gclass3_2.Int32_1 == 2)
		{
			gclass3_2.String_1 = "Cora";
			gclass3_2.String_2 = "M";
		}
		if (gclass3_2.Int32_1 == 3)
		{
			gclass3_2.String_1 = "Cora";
			gclass3_2.String_2 = "F";
		}
		gclass3_2.Single_2 = GClass1.smethod_13(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_24 }, 1);
		gclass3_2.Single_3 = GClass1.smethod_13(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_25 }, 1);
		gclass3_2.Single_4 = GClass1.smethod_13(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_26 }, 1);
		gclass3_2.Int32_6 = GClass1.smethod_15(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_38 }, 1);
		gclass3_2.Int32_7 = GClass1.smethod_15(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_41 }, 1);
		gclass3_2.Int64_1 = GClass1.smethod_12(IntPtr_0, intptr_24, new int[1], 1);
		gclass3_2.Int32_8 = GClass1.smethod_15(IntPtr_0, intptr_24, new int[1] { gclass5_0.Int32_42 }, 1);
	}

	public double GenerateRangeTarget(GClass3 gclass3_2, GClass3 gclass3_3)
	{
		double num = gclass3_3.Single_2 - gclass3_2.Single_2;
		double num2 = gclass3_3.Single_3 - gclass3_2.Single_3;
		double num3 = gclass3_3.Single_4 - gclass3_2.Single_4;
		if (Boolean_35 && Boolean_24)
		{
			num = gclass3_3.Single_2 - Single_2;
			num2 = gclass3_3.Single_3 - Single_3;
			num3 = gclass3_3.Single_4 - Single_4;
		}
		return Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}

	public void method_4(object sender, EventArgs e)
	{
		if (intptr_8 != IntPtr.Zero)
		{
			GClass3_0.Single_0 = (float)Math.Round(GClass1.smethod_13(IntPtr_0, intptr_8), 2);
		}
		else
		{
			GClass3_0.Single_0 = (float)Math.Round(GClass1.smethod_13(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_2 }, 1), 2);
		}
		GClass3_0.Single_1 = (float)Math.Round(GClass1.smethod_13(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_3 }, 1), 2);
		GClass3_0.Int64_0 = GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_4);
		GClass3_0.Int32_2 = GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_13 }, 1);
		GClass3_0.Int32_3 = GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_15 }, 1);
		GClass3_0.Int32_4 = GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_18 }, 1);
		GClass3_0.Int32_5 = GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_17 }, 1);
		GClass3_0.Single_2 = GClass1.smethod_13(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_24 }, 1);
		GClass3_0.Single_3 = GClass1.smethod_13(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_25 }, 1);
		GClass3_0.Single_4 = GClass1.smethod_13(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_26 }, 1);
		if (Boolean_3)
		{
			if (!gclass5_0.Boolean_0 && !bool_45)
			{
				bool_45 = true;
				GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_7, "558BEC51894DFC8B");
				GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_8, "558BEC51894DFC8B");
			}
			GClass1.smethod_17(IntPtr_0, gclass5_0.IntPtr_0, Single_0, new int[1] { gclass5_0.Int32_2 }, 1);
		}
		if (Boolean_10)
		{
			GClass1.smethod_17(IntPtr_0, gclass5_0.IntPtr_0, Single_1, new int[1] { gclass5_0.Int32_3 }, 1);
		}
		if (Boolean_11)
		{
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_11), "01");
		}
		if (Boolean_41 && (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_22 }, 1) > 0L || GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_22 + 4 }, 1) > 0L))
		{
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_22), "0000000000000000");
		}
		if (Boolean_7)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, 0, new int[1] { gclass5_0.Int32_6 }, 1);
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, 0, new int[1] { gclass5_0.Int32_7 }, 1);
		}
		if (Boolean_8 && GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_9 }, 1) > 0)
		{
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_9), "00");
		}
		if (Boolean_9)
		{
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_9), "01");
		}
		else if (!Boolean_8 && GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_9 }, 1) > 0)
		{
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_9), "00");
		}
		if (Boolean_4)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, 268435457, new int[1] { gclass5_0.Int32_19 }, 1);
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, 268435457, new int[1] { gclass5_0.Int32_20 }, 1);
		}
		if (Boolean_15)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, Int32_1, new int[1] { gclass5_0.Int32_13 }, 1);
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, Int32_1, new int[1] { gclass5_0.Int32_14 }, 1);
		}
		if (Boolean_16)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, Int32_2, new int[1] { gclass5_0.Int32_15 }, 1);
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, Int32_2, new int[1] { gclass5_0.Int32_16 }, 1);
		}
		if (Boolean_17)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, Int32_3, new int[1] { gclass5_0.Int32_18 }, 1);
		}
		if (Boolean_18)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_0, Int32_4, new int[1] { gclass5_0.Int32_17 }, 1);
		}
		if (IsExtremeASPD && IntPtr_0 != IntPtr.Zero)
		{
			byte[] bytes = BitConverter.GetBytes((short)16);
			GClass1.WriteWithPointer(IntPtr_0, gclass5_0.IntPtr_0, bytes, new int[1] { Convert.ToInt32("0x253", 16) }, 1);
		}
	}

	public void method_5(object sender, EventArgs e)
	{
	}

	public void method_6(object sender, EventArgs e)
	{
		if ((GClass1.GetAsyncKeyState((Keys)9) & 0x8000) != 32768)
		{
			return;
		}
		Timer_2.Stop();
		String_3 = "Scanning";
		int_8 = 0;
		int_9 = -1;
		double_0 = 99999999.0;
		gclass3_1 = new GClass3();
		GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_12) + int_8));
		while (gclass3_1.Int64_1 > 5L)
		{
			if (gclass3_1.Int64_1 == 10756052L && gclass3_1.Int32_6 != 80)
			{
				bool flag = false;
				if (String_2 == "")
				{
					flag = true;
				}
				else
				{
					try
					{
						if (string.Equals(gclass3_1.String_0, String_2, StringComparison.CurrentCultureIgnoreCase))
						{
							flag = true;
						}
					}
					catch (Exception)
					{
					}
				}
				if (flag)
				{
					flag = false;
					double num = GenerateRangeTarget(GClass3_0, gclass3_1);
					if (!(num >= double_0))
					{
						if (List_0.Contains(gclass3_1.Int32_1))
						{
							flag = true;
						}
						if (num > (double)Int32_5)
						{
							flag = false;
						}
						if (gclass3_1.Int32_7 != 0)
						{
							flag = false;
						}
						if (flag && !string.IsNullOrEmpty(String_2) && string.Equals(gclass3_1.String_0, String_2, StringComparison.CurrentCultureIgnoreCase))
						{
							flag = true;
							double_0 = num;
							int_9 = int_8;
						}
						else
						{
							if ((Boolean_25 || Boolean_26) && string.IsNullOrEmpty(String_2))
							{
								flag = false;
								if (Boolean_25 && gclass3_1.Int32_8 == 18)
								{
									flag = true;
								}
								if (Boolean_26 && gclass3_1.Int32_8 == 19)
								{
									flag = true;
								}
								if (Boolean_25 && gclass3_1.Int32_8 == 20)
								{
									flag = true;
								}
							}
							if (flag)
							{
								double_0 = num;
								int_9 = int_8;
							}
						}
					}
				}
			}
			int_8 += 4;
			if (int_8 / 4 > Int32_6)
			{
				Int32_6 = int_8 / 4;
			}
			gclass3_1 = new GClass3();
			GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_12) + int_8));
		}
		if (int_9 > -1)
		{
			if (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_18, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2) != 1L)
			{
				int_10 = 0;
			}
			else
			{
				GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_18, 0, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2);
				int_10 = 1;
			}
			string text = "00000000" + GClass1.smethod_19(new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_12, new int[2] { int_9, 8 }, 2)));
			GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { gclass5_0.Int32_27 }, 1) + gclass5_0.Int32_36), text);
			GClass1.smethod_20(Process_0.MainWindowHandle, 57);
			int num2 = 0;
			while (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[2] { gclass5_0.Int32_27, gclass5_0.Int32_36 }, 2) != GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { 4 }, 1) && num2 <= 999)
			{
				num2++;
			}
			GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { gclass5_0.Int32_27 }, 1) + gclass5_0.Int32_36), "FFFFFFFFFFFFFFFF");
			if (int_10 == 1)
			{
				GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_18, 1, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2);
			}
		}
		Timer_2.Start();
		String_3 = "Waiting";
	}

	public void method_7(object sender, EventArgs e)
	{
		GClass1.smethod_20(Process_0.MainWindowHandle, 88);
	}

	public void LoadBot(object sender, EventArgs e)
	{
		Timer_4.Stop();
		if (int_9 > -1)
		{
			gclass3_1 = new GClass3();
			GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15) + int_9));
			string_4 = gclass3_1.Int32_6.ToString();
			string_5 = gclass3_1.Int32_7.ToString();
			string_6 = gclass3_1.Int32_8.ToString();
			if (GClass1.smethod_15(IntPtr_0, gclass5_0.IntPtr_11, new int[1], 1) == byte.MaxValue || gclass3_1.Int32_8 == 160 || gclass3_1.Int32_8 == 176 || gclass3_1.Int32_6 == 80)
			{
				int_9 = -1;
			}
			else
			{
				if (Boolean_36)
				{
					GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11) + gclass5_0.Int32_23), "0000000001000000");
				}
				if (Boolean_44 && !bool_49)
				{
					GClass1.smethod_20(Process_0.MainWindowHandle, 188);
					bool_49 = true;
				}
			}
		}
		else
		{
			int_8 = 0;
			int_9 = -1;
			double_0 = 99999999.0;
			bool_49 = false;
			gclass3_1 = new GClass3();
			GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15) + int_8));
			while (gclass3_1.Int64_1 > 5L)
			{
				if (gclass3_1.Int64_1 == 10768572L && gclass3_1.Int32_6 != 80)
				{
					bool flag = false;
					if (List_1.Count > 0)
					{
						try
						{
							foreach (string item in List_2)
							{
								if (gclass3_1.String_0.Substring(0, item.Length).Equals(item))
								{
									flag = true;
									break;
								}
							}
						}
						catch (Exception)
						{
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						flag = true;
						double num = GenerateRangeTarget(GClass3_0, gclass3_1);
						if (!(num >= double_0))
						{
							if (num > (double)Int32_5)
							{
								flag = false;
							}
							if (gclass3_1.Int32_7 != 0)
							{
								flag = false;
							}
							if (flag)
							{
								double_0 = num;
								int_9 = int_8;
							}
						}
					}
				}
				int_8 += 4;
				if (int_8 / 4 > Int32_6)
				{
					Int32_6 = int_8 / 4;
				}
				gclass3_1 = new GClass3();
				GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15) + int_8));
			}
			if (int_9 > -1)
			{
				if (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_18, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2) == 1L)
				{
					GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_18, 0, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2);
					int_10 = 1;
				}
				else
				{
					int_10 = 0;
				}
				string text = "01000000" + GClass1.smethod_19(new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15, new int[2] { int_9, 8 }, 2)));
				GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { gclass5_0.Int32_27 }, 1) + gclass5_0.Int32_36), text);
				GClass1.smethod_20(Process_0.MainWindowHandle, 57);
				int num2 = 0;
				while (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[2] { gclass5_0.Int32_27, gclass5_0.Int32_36 }, 2) != GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { 4 }, 1) && num2 <= 999)
				{
					num2++;
				}
				GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { gclass5_0.Int32_27 }, 1) + gclass5_0.Int32_36), "FFFFFFFFFFFFFFFF");
				if (int_10 == 1)
				{
					GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_18, 1, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2);
				}
			}
		}
		Timer_4.Start();
	}

	public void LoadAutoTabMonster()
	{
		if (IsAutoTabMonster)
		{
			if (intptr_10 == IntPtr.Zero)
			{
				intptr_10 = GClass1.smethod_6(IntPtr_0, 16);
				GClass1.smethod_18(string_0: "558BECE9" + GClass1.smethod_19(((long)intptr_10 >= (long)gclass5_0.IntPtr_17) ? new IntPtr(MaxAddress - (long)intptr_10 + (long)gclass5_0.IntPtr_17 + 312L) : new IntPtr((long)gclass5_0.IntPtr_17 - (long)intptr_10 + 311L)), intptr_0: IntPtr_0, intptr_1: intptr_10);
			}
			if (intptr_10 != IntPtr.Zero)
			{
				GClass1.smethod_18(string_0: "E9" + GClass1.smethod_19(((long)intptr_10 < (long)gclass5_0.IntPtr_17) ? new IntPtr(MaxAddress - (long)gclass5_0.IntPtr_17 - (long)intptr_10 - 4L) : new IntPtr((long)intptr_10 - (long)gclass5_0.IntPtr_17 - 5L)), intptr_0: IntPtr_0, intptr_1: gclass5_0.IntPtr_17);
			}
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_17, "558BEC83EC14");
			int_9 = -1;
		}
	}

	public void TabMonster()
	{
		int_8 = 0;
		int_9 = -1;
		double_0 = 99999999.0;
		Int32_5 = ((Int32_5 == 0) ? 2000 : Int32_5);
		gclass3_1 = new GClass3();
		GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15) + int_8));
		while (gclass3_1.Int64_1 > 5L)
		{
			if (gclass3_1.Int64_1 == 10768572L && gclass3_1.Int32_6 != 80)
			{
				bool flag = true;
				double num = GenerateRangeTarget(GClass3_0, gclass3_1);
				if (!(num >= double_0))
				{
					if (num > 2000.0)
					{
						flag = false;
					}
					if (gclass3_1.Int32_7 != 0)
					{
						flag = false;
					}
					if (flag)
					{
						double_0 = num;
						int_9 = int_8;
					}
				}
			}
			int_8 += 4;
			if (int_8 / 4 > Int32_6)
			{
				Int32_6 = int_8 / 4;
			}
			gclass3_1 = new GClass3();
			GetCurrentUserInfo(gclass3_1, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15) + int_8));
		}
		if (int_9 > -1)
		{
			if (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_18, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2) == 1L)
			{
				GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_18, 0, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2);
				int_10 = 1;
			}
			else
			{
				int_10 = 0;
			}
			string text = "01000000" + GClass1.smethod_19(new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_15, new int[2] { int_9, 8 }, 2)));
			GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { gclass5_0.Int32_27 }, 1) + gclass5_0.Int32_36), text);
			GClass1.smethod_20(Process_0.MainWindowHandle, 57);
			int num2 = 0;
			while (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[2] { gclass5_0.Int32_27, gclass5_0.Int32_36 }, 2) != GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { 4 }, 1) && num2 <= 999)
			{
				num2++;
			}
			GClass1.smethod_18(IntPtr_0, new IntPtr(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_11, new int[1] { gclass5_0.Int32_27 }, 1) + gclass5_0.Int32_36), "FFFFFFFFFFFFFFFF");
			if (int_10 == 1)
			{
				GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_18, 1, new int[2] { gclass5_0.Int32_39, gclass5_0.Int32_40 }, 2);
			}
		}
	}

	public void LoadExtendView(bool isActivated)
	{
		if (isActivated)
		{
			if (extendViewAddressTemp == IntPtr.Zero)
			{
				byte[] array = GClass1.smethod_8(BaseAddress, gclass5_0.extendViewAddress, 16);
				restoreExtendViewAddress = BitConverter.ToString(array).Replace("-", string.Empty);
				extendViewAddressTemp = GClass1.smethod_6(BaseAddress, 128);
				string text = $"D9 05 {GClass1.smethod_19(extendViewAddressTemp + 11)} ";
				GClass1.smethod_18(string_0: ((long)extendViewAddressTemp >= (long)gclass5_0.extendViewAddress2) ? (text + $"E9 {GClass1.smethod_19(new IntPtr((long)gclass5_0.extendViewAddress2 - (long)extendViewAddressTemp - 5L))} 00 00 7A 44") : (text + $"e9 {GClass1.smethod_19(new IntPtr(MaxAddress - (long)extendViewAddressTemp + (long)gclass5_0.extendViewAddress2 - 4L))} 00 00 7A 44"), intptr_0: BaseAddress, intptr_1: extendViewAddressTemp);
				GClass1.smethod_18(BaseAddress, gclass5_0.extendViewAddress, "55 55 FF 42 55 55 FF 42 55 55 FF 42 55 55 FF 42");
			}
			if (extendViewAddressTemp != IntPtr.Zero)
			{
				if ((long)extendViewAddressTemp < (long)gclass5_0.extendViewAddress2)
				{
					GClass1.smethod_18(BaseAddress, gclass5_0.extendViewAddress2, "e9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)gclass5_0.extendViewAddress2 + (long)extendViewAddressTemp - 4L)) + "90");
				}
				else
				{
					GClass1.smethod_18(BaseAddress, gclass5_0.extendViewAddress2, "e9" + GClass1.smethod_19(new IntPtr((long)extendViewAddressTemp - (long)gclass5_0.extendViewAddress2 - 5L)) + "90");
				}
			}
		}
		else
		{
			GClass1.smethod_18(BaseAddress, gclass5_0.extendViewAddress, restoreExtendViewAddress);
			GClass1.smethod_18(BaseAddress, gclass5_0.extendViewAddress2, "D9 81 1C 0E 00 00");
		}
	}

	public void method_9(IntPtr intptr_24)
	{
		if (intptr_24 != IntPtr.Zero)
		{
			gclass5_0.IntPtr_23 = intptr_24 - 15;
			gclass5_0.IntPtr_24 = gclass5_0.IntPtr_23 + 47040;
			gclass5_0.IntPtr_22 = gclass5_0.IntPtr_23 + 94080;
			gclass5_0.IntPtr_25 = gclass5_0.IntPtr_23 - 39 + 132160;
			gclass5_0.IntPtr_26 = gclass5_0.IntPtr_23 - 39 + 141120;
			gclass5_0.IntPtr_27 = gclass5_0.IntPtr_23 - 39 + 224936480;
		}
	}

	public void method_10()
	{
		List<IntPtr> list = GClass1.smethod_1(Process_0.Id, gclass5_0.String_2, Convert.ToInt32("0x22147C50", 16), Convert.ToInt32("0x22157C50", 16), "strBytes");
		if (list.Count > 0)
		{
			method_9(list[0]);
		}
		if (gclass5_0.IntPtr_23 == IntPtr.Zero)
		{
			list = GClass1.smethod_1(Process_0.Id, gclass5_0.String_2, Convert.ToInt32("0x1F000000", 16), Convert.ToInt32("0x30000000", 16), "strBytes");
			if (list.Count > 0)
			{
				method_9(list[0]);
			}
		}
		if (gclass5_0.IntPtr_23 == IntPtr.Zero)
		{
			list = GClass1.smethod_1(Process_0.Id, gclass5_0.String_2, Convert.ToInt32("0x0F000000", 16), Convert.ToInt32("0x1F000000", 16), "strBytes");
			if (list.Count > 0)
			{
				method_9(list[0]);
			}
		}
	}

	public void method_11(List<CheckBox> list_3)
	{
	}

	public void method_12(CheckBox checkBox_1)
	{
		if (Boolean_2)
		{
			if (intptr_2 == IntPtr.Zero)
			{
				((Control)checkBox_1).Enabled = false;
				((Control)checkBox_1).Text = "Preparing...";
				List<IntPtr> list = GClass1.smethod_1(Process_0.Id, gclass5_0.String_0, Convert.ToInt32("0x3400000", 16), Convert.ToInt32("0x4000000", 16), "strBytes");
				if (list.Count <= 0)
				{
					intptr_2 = gclass5_0.IntPtr_28;
				}
				else
				{
					intptr_2 = list[0];
				}
				if (GClass1.smethod_12(IntPtr_0, intptr_2) == 84938739)
				{
					intptr_3 = GClass1.smethod_6(IntPtr_0, 4);
					GClass1.smethod_17(IntPtr_0, intptr_3, 230f);
					intptr_4 = GClass1.smethod_6(IntPtr_0, 16);
					IntPtr intPtr = intptr_3;
					string text = "F30F1005" + GClass1.smethod_19(intPtr);
					intPtr = (((long)intptr_4 <= (long)intptr_2) ? new IntPtr((long)intptr_2 - (long)intptr_4 - 5L) : new IntPtr(MaxAddress - (long)intptr_4 + (long)intptr_2 - 4L));
					text = text + "E9" + GClass1.smethod_19(intPtr);
					GClass1.smethod_18(IntPtr_0, intptr_4, text);
					intPtr = (((long)intptr_2 < (long)intptr_4) ? new IntPtr(MaxAddress - (long)intptr_2 + (long)intptr_4 - 4L) : new IntPtr((long)intptr_4 - (long)intptr_2 - 5L));
					text = "E9" + GClass1.smethod_19(intPtr);
					text += "909090";
					GClass1.smethod_18(IntPtr_0, intptr_2, text);
				}
				((Control)checkBox_1).Enabled = true;
				((Control)checkBox_1).Text = "Eagle Eye";
			}
			if (intptr_1 == IntPtr.Zero && GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_3) != gclass5_0.Int32_43)
			{
				intptr_1 = GClass1.smethod_6(IntPtr_0, 4);
				GClass1.smethod_17(IntPtr_0, intptr_1, 20000f);
				string text2 = "D905" + GClass1.smethod_19(intptr_1);
				GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_3, text2);
			}
			if (intptr_1 == IntPtr.Zero && gclass5_0.Boolean_0 && GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_3) == gclass5_0.Int32_43)
			{
				intptr_1 = GClass1.smethod_6(IntPtr_0, 4);
				GClass1.smethod_17(IntPtr_0, intptr_1, 20000f);
				string text3 = "D905" + GClass1.smethod_19(intptr_1);
				GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_3, text3);
			}
			if (intptr_1 != IntPtr.Zero)
			{
				GClass1.smethod_17(IntPtr_0, intptr_1, 20000f);
			}
			GClass1.smethod_17(IntPtr_0, gclass5_0.IntPtr_2, 20000f);
			LoadEagleEye();
		}
		else
		{
			if (intptr_1 != IntPtr.Zero)
			{
				GClass1.smethod_17(IntPtr_0, intptr_1, 230f);
			}
			GClass1.smethod_17(IntPtr_0, gclass5_0.IntPtr_2, 230f);
			LoadEagleEye();
		}
	}

	public void method_13(CheckBox checkBox_1)
	{
		if (Boolean_6)
		{
			if (intptr_5 == IntPtr.Zero)
			{
				List<IntPtr> list = GClass1.smethod_1(Process_0.Id, gclass5_0.String_1, Convert.ToInt32("0x3400000", 16), Convert.ToInt32("0x4000000", 16), "strBytes");
				if (list.Count <= 0)
				{
					intptr_5 = gclass5_0.IntPtr_29;
				}
				else
				{
					intptr_5 = list[0];
				}
				if (GClass1.smethod_12(IntPtr_0, intptr_5) == -108087793)
				{
					((Control)checkBox_1).Enabled = false;
					((Control)checkBox_1).Text = "Preparing...";
					intptr_6 = GClass1.smethod_6(IntPtr_0, 1);
					GClass1.smethod_18(IntPtr_0, intptr_6, "00");
					intptr_7 = GClass1.smethod_6(IntPtr_0, 32);
					string text = "0FB60D" + GClass1.smethod_19(intptr_6) + "884DCEA0" + GClass1.smethod_19(intptr_6) + "E9";
					GClass1.smethod_18(string_0: ((long)intptr_5 < (long)intptr_7) ? (text + GClass1.smethod_19(new IntPtr(MaxAddress - (long)intptr_7 + (long)intptr_5 - 3L))) : (text + GClass1.smethod_19(new IntPtr((long)intptr_5 - (long)intptr_7 - 4L))), intptr_0: IntPtr_0, intptr_1: intptr_7);
					GClass1.smethod_18(string_0: ((long)intptr_7 <= (long)intptr_5) ? ("E9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)intptr_5 + (long)intptr_7 - 4L)) + "9090") : ("E9" + GClass1.smethod_19(new IntPtr((long)intptr_7 - (long)intptr_5 - 5L)) + "9090"), intptr_0: IntPtr_0, intptr_1: intptr_5);
					((Control)checkBox_1).Enabled = true;
					((Control)checkBox_1).Text = "Detection";
				}
			}
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_8), "01");
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_10), "01");
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_8), "00");
			GClass1.smethod_18(IntPtr_0, new IntPtr((long)GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_0) + (long)gclass5_0.Int32_10), "00");
		}
	}

	public void method_14()
	{
		if (Boolean_21)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_4, Int32_0);
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_5, "FF");
		}
		GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_5, "74");
	}

	public void method_15()
	{
		if (Boolean_5)
		{
			if (intptr_9 == IntPtr.Zero)
			{
				intptr_9 = GClass1.smethod_6(IntPtr_0, 16);
				GClass1.smethod_18(IntPtr_0, intptr_9, "669CB800000000669D684F494500C390");
			}
			string text = "E9" + GClass1.smethod_19(new IntPtr((long)intptr_9 - 4540750L)) + "90";
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_9, text);
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_9, "8B81B4000000");
		}
	}

	public void method_16()
	{
		if (Boolean_14)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_21, "EB");
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_21, "75");
		}
	}

	public void method_17()
	{
		int num = GClass1.smethod_12(IntPtr_0, gclass5_0.IntPtr_10, new int[1] { gclass5_0.Int32_21 }, 1);
		if (!Boolean_22)
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_10, Convert.ToInt32("0x" + num.ToString("X").PadLeft(8, '0').Substring(0, 6) + "74", 16), new int[1] { gclass5_0.Int32_21 }, 1);
		}
		else
		{
			GClass1.smethod_16(IntPtr_0, gclass5_0.IntPtr_10, Convert.ToInt32("0x" + num.ToString("X").PadLeft(8, '0').Substring(0, 6) + "EB", 16), new int[1] { gclass5_0.Int32_21 }, 1);
		}
	}

	public void method_18()
	{
		if (Boolean_12)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_22, "FF");
			return;
		}
		GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_22, "01");
		GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_23, "01");
		GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_24, "01");
	}

	public void method_19()
	{
		if (Boolean_13)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_25, "00000000000000000000");
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_25, "00000000000000000001");
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_26, "00000000000000000001");
		}
		GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_27, "00000000000000000001");
	}

	public void method_20()
	{
		if (Boolean_27)
		{
			if (intptr_10 == IntPtr.Zero)
			{
				intptr_10 = GClass1.smethod_6(IntPtr_0, 16);
				GClass1.smethod_18(string_0: "558BECE9" + GClass1.smethod_19(((long)intptr_10 >= (long)gclass5_0.IntPtr_17) ? new IntPtr(MaxAddress - (long)intptr_10 + (long)gclass5_0.IntPtr_17 + 312L) : new IntPtr((long)gclass5_0.IntPtr_17 - (long)intptr_10 + 311L)), intptr_0: IntPtr_0, intptr_1: intptr_10);
			}
			if (intptr_10 != IntPtr.Zero)
			{
				GClass1.smethod_18(string_0: "E9" + GClass1.smethod_19(((long)intptr_10 < (long)gclass5_0.IntPtr_17) ? new IntPtr(MaxAddress - (long)gclass5_0.IntPtr_17 - (long)intptr_10 - 4L) : new IntPtr((long)intptr_10 - (long)gclass5_0.IntPtr_17 - 5L)), intptr_0: IntPtr_0, intptr_1: gclass5_0.IntPtr_17);
			}
			Timer_2.Start();
			String_3 = "Waiting";
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_17, "558BEC83EC14");
			Timer_2.Stop();
			String_3 = "Off";
		}
	}

	public void method_21(string string_4, string string_5 = "add")
	{
		if (string_5 == "add")
		{
			if (!(string_4 == "Bellato"))
			{
				if (!(string_4 == "Cora"))
				{
					List_0.Add(4);
					List_0.Add(5);
				}
				else
				{
					List_0.Add(2);
					List_0.Add(3);
				}
			}
			else
			{
				List_0.Add(0);
				List_0.Add(1);
			}
		}
		if (string_5 == "remove")
		{
			if (string_4 == "Bellato")
			{
				List_0.Remove(0);
				List_0.Remove(1);
			}
			else if (string_4 == "Cora")
			{
				List_0.Remove(2);
				List_0.Remove(3);
			}
			else
			{
				List_0.Remove(4);
				List_0.Remove(5);
			}
		}
	}

	public void method_22()
	{
		if (Boolean_20)
		{
			if (GClass1.smethod_15(IntPtr_0, gclass5_0.IntPtr_6) == 232 && GClass1.smethod_15(IntPtr_0, gclass5_0.IntPtr_6 + 1) == 174)
			{
				GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_6, "90909090909090EB07");
				GClass1.smethod_18(BaseAddress, new IntPtr(Convert.ToInt32("0x00529812", 16)), "909090");
				GClass1.smethod_18(BaseAddress, new IntPtr(Convert.ToInt32("0x005298E8", 16)), "909090");
			}
		}
		else if (GClass1.smethod_15(IntPtr_0, gclass5_0.IntPtr_6) == 144 && GClass1.smethod_15(IntPtr_0, gclass5_0.IntPtr_6 + 1) == 144)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_6, "E8AE5FFAFF85C07507");
			GClass1.smethod_18(BaseAddress, new IntPtr(Convert.ToInt32("0x00529812", 16)), "0F B6 C0");
			GClass1.smethod_18(BaseAddress, new IntPtr(Convert.ToInt32("0x005298E8", 16)), "0F B6 D0");
		}
	}

	public void method_23()
	{
		_ = Boolean_3;
	}

	public void method_24()
	{
		if (Boolean_32)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_30, "EB");
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_30, "75");
		}
	}

	public void method_25()
	{
		if (Boolean_33)
		{
			List<IntPtr> list = GClass1.smethod_1(Process_0.Id, "75 05 E9 3B 02 00 00", 5177344L, 7274496L, "strBytes");
			if (list.Count > 0)
			{
				intptr_11 = list[0];
				GClass1.smethod_18(IntPtr_0, intptr_11, "90 90");
			}
			if (GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_31) == -1960294263L)
			{
				GClass1.smethod_18(IntPtr_0, intptr_22, "01");
				GClass1.smethod_18(IntPtr_0, intptr_22 + 4, "536B696C6C57696E646F77");
				GClass1.smethod_18(IntPtr_0, intptr_22 + 16, GClass1.smethod_19(new IntPtr(5996130)));
				GClass1.smethod_18(IntPtr_0, intptr_22 + 32, GClass1.smethod_19(intptr_22 + 4));
				intptr_12 = GClass1.smethod_6(IntPtr_0, 256);
				string text = $"669c803d{GClass1.smethod_19(intptr_22)}01";
				text += $"752f52518b15{GClass1.smethod_19(intptr_22 + 32)}8B0A394814595a751e83fb01";
				text += "7502eb17817d04456c5b00";
				text += "750e669dc64028008be5ff25";
				text += $"{GClass1.smethod_19(intptr_22 + 16)}669d";
				text += $"8948288be5ff25{GClass1.smethod_19(intptr_22 + 16)}";
				GClass1.smethod_18(IntPtr_0, intptr_12, text);
				if ((long)intptr_12 > (long)gclass5_0.IntPtr_31)
				{
					GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_31, "E9" + GClass1.smethod_19(new IntPtr((long)intptr_12 - (long)gclass5_0.IntPtr_31 - 5L)));
				}
				else
				{
					GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_31, "E9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)gclass5_0.IntPtr_31 + (long)intptr_12 - 4L)));
				}
			}
			if (intptr_22 != IntPtr.Zero)
			{
				GClass1.smethod_18(IntPtr_0, intptr_22, "01");
			}
		}
		else
		{
			if (intptr_11 != IntPtr.Zero)
			{
				GClass1.smethod_18(IntPtr_0, intptr_11, "75 05");
			}
			if (intptr_22 != IntPtr.Zero)
			{
				GClass1.smethod_18(IntPtr_0, intptr_22, "00");
			}
		}
	}

	public void method_26()
	{
		if (Boolean_28)
		{
			if (intptr_15 == IntPtr.Zero)
			{
				intptr_16 = GClass1.smethod_6(IntPtr_0, 1);
				GClass1.smethod_18(IntPtr_0, intptr_16, "01");
				GClass1.smethod_18(IntPtr_0, intptr_16 + 16, GClass1.smethod_19(new IntPtr(5261440)));
				GClass1.smethod_18(IntPtr_0, intptr_16 + 32, GClass1.smethod_19(new IntPtr(4409478)));
				intptr_15 = GClass1.smethod_6(IntPtr_0, 256);
				string text = $"669c803d{GClass1.smethod_19(intptr_16)}01";
				text += "753380b8d003000001";
				text += "752a6683b87602000000";
				text += $"7420528b15{GClass1.smethod_19(gclass5_0.IntPtr_11)}";
				text += $"833aff5a7513608d008b0d{GClass1.smethod_19(gclass5_0.IntPtr_11)}";
				text += $"6a0050ff15{GClass1.smethod_19(intptr_16 + 16)}";
				text += $"61669dd9585c8b55fcff25{GClass1.smethod_19(intptr_16 + 32)}";
				GClass1.smethod_18(IntPtr_0, intptr_15, text);
				if ((long)intptr_15 > (long)intptr_14)
				{
					GClass1.smethod_18(IntPtr_0, intptr_14, "E9" + GClass1.smethod_19(new IntPtr((long)intptr_15 - (long)intptr_14 - 5L)));
				}
				else
				{
					GClass1.smethod_18(IntPtr_0, intptr_14, "E9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)intptr_14 + (long)intptr_15 - 4L)));
				}
			}
			if (intptr_16 != IntPtr.Zero)
			{
				GClass1.smethod_18(IntPtr_0, intptr_16, "01");
			}
		}
		else if (intptr_16 != IntPtr.Zero)
		{
			GClass1.smethod_18(IntPtr_0, intptr_16, "00");
		}
	}

	public void method_27()
	{
		if (Boolean_23)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_38, "EB");
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_39, "EB");
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_40, "EB");
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_38, "74");
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_39, "74");
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_40, "74");
		}
	}

	public void method_28()
	{
		if (!Boolean_34)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_33, "D980E4000000");
			return;
		}
		if (intptr_17 == IntPtr.Zero)
		{
			GClass1.smethod_17(IntPtr_0, intptr_22 + 48, 20000f);
			GClass1.smethod_18(IntPtr_0, intptr_22 + 52, GClass1.smethod_19(gclass5_0.IntPtr_33 + 6));
			intptr_17 = GClass1.smethod_6(IntPtr_0, 256);
			string text = $"669cd905{GClass1.smethod_19(intptr_22 + 48)}";
			text += $"669dff25{GClass1.smethod_19(intptr_22 + 52)}";
			GClass1.smethod_18(IntPtr_0, intptr_17, text);
		}
		if ((long)intptr_17 > (long)gclass5_0.IntPtr_33)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_33, "E9" + GClass1.smethod_19(new IntPtr((long)intptr_17 - (long)gclass5_0.IntPtr_33 - 5L)) + "90");
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_33, "E9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)gclass5_0.IntPtr_33 + (long)intptr_17 - 4L)) + "90");
		}
	}

	public void method_29()
	{
		if (Boolean_24)
		{
			int_9 = -1;
			Timer_4.Start();
		}
		else
		{
			Timer_4.Stop();
			int_9 = -1;
		}
	}

	public void method_30()
	{
		if (Boolean_35)
		{
			Single_2 = GClass3_0.Single_2;
			Single_3 = GClass3_0.Single_3;
			Single_4 = GClass3_0.Single_4;
		}
	}

	public void LoadSkillAllWeapon()
	{
		if (Boolean_13)
		{
			if (intptr_18 == IntPtr.Zero)
			{
				intptr_18 = GClass1.smethod_6(IntPtr_0, 256);
				string text = $"0fbe15{GClass1.smethod_19(intptr_18 + 32)}";
				GClass1.smethod_18(string_0: ((long)intptr_18 >= (long)gclass5_0.IntPtr_34) ? (text + $"e9{GClass1.smethod_19(new IntPtr((long)gclass5_0.IntPtr_34 - (long)intptr_18 - 5L))}") : (text + $"e9{GClass1.smethod_19(new IntPtr(MaxAddress - (long)intptr_18 + (long)gclass5_0.IntPtr_34 - 4L))}"), intptr_0: IntPtr_0, intptr_1: intptr_18);
			}
			if (intptr_18 != IntPtr.Zero)
			{
				if ((long)intptr_18 < (long)gclass5_0.IntPtr_34)
				{
					GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_34, "e9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)gclass5_0.IntPtr_34 + (long)intptr_18 - 4L)));
				}
				else
				{
					GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_34, "e9" + GClass1.smethod_19(new IntPtr((long)intptr_18 - (long)gclass5_0.IntPtr_34 - 5L)));
				}
			}
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_34, "0FBE91D6010000");
		}
	}

	public void method_32()
	{
		if (Boolean_37)
		{
			if (intptr_19 == IntPtr.Zero)
			{
				intptr_19 = GClass1.smethod_6(IntPtr_0, 256);
				string text = $"0fb615{GClass1.smethod_19(intptr_19 + 32)}";
				GClass1.smethod_18(string_0: ((long)intptr_19 >= (long)gclass5_0.IntPtr_35) ? (text + $"e9{GClass1.smethod_19(new IntPtr((long)gclass5_0.IntPtr_35 - (long)intptr_19 - 5L))}") : (text + $"e9{GClass1.smethod_19(new IntPtr(MaxAddress - (long)intptr_19 + (long)gclass5_0.IntPtr_35 - 4L))}"), intptr_0: IntPtr_0, intptr_1: intptr_19);
			}
			if (intptr_19 != IntPtr.Zero)
			{
				if ((long)intptr_19 < (long)gclass5_0.IntPtr_35)
				{
					GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_35, "e9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)gclass5_0.IntPtr_35 + (long)intptr_19 - 4L)));
				}
				else
				{
					GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_35, "e9" + GClass1.smethod_19(new IntPtr((long)intptr_19 - (long)gclass5_0.IntPtr_35 - 5L)));
				}
			}
		}
		else
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_35, "0FB690CC010000");
		}
	}

	public void method_33()
	{
		if (Boolean_38)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_36, "EB28");
		}
		if (Boolean_39)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_36, "9090");
		}
		if (!Boolean_39 && !Boolean_38)
		{
			GClass1.smethod_18(IntPtr_0, gclass5_0.IntPtr_36, "7228");
		}
	}

	public void method_34()
	{
		if (Boolean_40)
		{
			if (intptr_20 == IntPtr.Zero)
			{
				List<IntPtr> list = GClass1.smethod_1(Process_0.Id, "74 1A 68 1E 02 00 00 B9 68 DE 33 02 E8 91", 5177344L, 8442222L, "strBytes");
				if (list.Count <= 0)
				{
					list = GClass1.smethod_1(Process_0.Id, "EB 1A 68 1E 02 00 00 B9 68 DE 33 02 E8 91", 5177344L, 8442222L, "strBytes");
					if (list.Count > 0)
					{
						intptr_20 = list[0];
					}
				}
				else
				{
					intptr_20 = list[0];
				}
			}
			if (intptr_20 != IntPtr.Zero)
			{
				GClass1.smethod_18(IntPtr_0, intptr_20, "EB");
			}
		}
		else if (intptr_20 != IntPtr.Zero)
		{
			GClass1.smethod_18(IntPtr_0, intptr_20, "74");
		}
	}

	public void LoadButtonDelay(string delayHex)
	{
		GClass1.smethod_18(IntPtr_0, gclass5_0.ButtonDelayAddress, delayHex);
		GClass1.smethod_18(IntPtr_0, gclass5_0.ButtonDelayAddress2, delayHex);
	}

	public void LoadEagleEye()
	{
		if (Boolean_2)
		{
			if (intptr_21 == IntPtr.Zero)
			{
				intptr_21 = GClass1.smethod_6(BaseAddress, 128);
				string text = $"0fbe05{GClass1.smethod_19(intptr_21 + 12)}";
				GClass1.smethod_18(string_0: ((long)intptr_21 >= (long)gclass5_0.eagleEyeAdvAddr) ? (text + $"E9 {GClass1.smethod_19(new IntPtr((long)gclass5_0.eagleEyeAdvAddr - (long)intptr_21 - 5L))}") : (text + $"E9 {GClass1.smethod_19(new IntPtr(MaxAddress - (long)intptr_21 + (long)gclass5_0.eagleEyeAdvAddr - 4L))}"), intptr_0: BaseAddress, intptr_1: intptr_21);
			}
			if (intptr_21 != IntPtr.Zero)
			{
				if ((long)intptr_21 < (long)gclass5_0.eagleEyeAdvAddr)
				{
					GClass1.smethod_18(BaseAddress, gclass5_0.eagleEyeAdvAddr, "e9" + GClass1.smethod_19(new IntPtr(MaxAddress - (long)gclass5_0.eagleEyeAdvAddr + (long)intptr_21 - 4L)) + "6690");
				}
				else
				{
					GClass1.smethod_18(BaseAddress, gclass5_0.eagleEyeAdvAddr, "e9" + GClass1.smethod_19(new IntPtr((long)intptr_21 - (long)gclass5_0.eagleEyeAdvAddr - 5L)) + "6690");
				}
			}
		}
		else
		{
			GClass1.smethod_18(BaseAddress, gclass5_0.eagleEyeAdvAddr, "0FBE80AC000000");
		}
	}

	public void method_36()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_22 }, 1).ToString("X"));
		MessageBox.Show(GClass1.smethod_11(IntPtr_0, gclass5_0.IntPtr_0, new int[1] { gclass5_0.Int32_22 + 4 }, 1).ToString("X"));
	}

	public void method_37(GClass4 gclass4_0, bool bool_46 = true)
	{
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = (Boolean_2 ? "1" : "0") + (Boolean_3 ? "1" : "0") + (Boolean_4 ? "1" : "0") + (Boolean_5 ? "1" : "0") + (Boolean_6 ? "1" : "0") + (Boolean_7 ? "1" : "0") + (Boolean_8 ? "1" : "0") + (Boolean_9 ? "1" : "0") + (Boolean_10 ? "1" : "0") + (Boolean_11 ? "1" : "0") + (Boolean_12 ? "1" : "0") + (Boolean_13 ? "1" : "0") + (Boolean_14 ? "1" : "0") + (Boolean_15 ? "1" : "0") + (Boolean_16 ? "1" : "0") + (Boolean_17 ? "1" : "0") + (Boolean_18 ? "1" : "0") + (Boolean_19 ? "1" : "0") + (Boolean_20 ? "1" : "0") + (Boolean_21 ? "1" : "0") + (Boolean_22 ? "1" : "0") + (Boolean_23 ? "1" : "0") + (Boolean_24 ? "1" : "0") + (Boolean_25 ? "1" : "0") + (Boolean_26 ? "1" : "0") + (Boolean_27 ? "1" : "0") + (Boolean_28 ? "1" : "0") + (Boolean_29 ? "1" : "0") + (Boolean_30 ? "1" : "0") + (Boolean_31 ? "1" : "0") + (Boolean_32 ? "1" : "0") + (Boolean_33 ? "1" : "0") + (Boolean_34 ? "1" : "0") + (Boolean_35 ? "1" : "0") + (Boolean_36 ? "1" : "0") + (Boolean_37 ? "1" : "0") + (Boolean_38 ? "1" : "0") + (Boolean_39 ? "1" : "0") + (Boolean_40 ? "1" : "0") + (Boolean_41 ? "1" : "0");
			List<string> list = new List<string>
			{
				Single_0.ToString(),
				Single_1.ToString(),
				Int32_0.ToString(),
				Int32_1.ToString(),
				Int32_2.ToString(),
				Int32_3.ToString(),
				Int32_4.ToString(),
				String_2.ToString(),
				Int32_5.ToString()
			};
			GClass1.smethod_23(text, list, gclass4_0.String_0);
			if (bool_46)
			{
				MessageBox.Show("gratz, save profile success! you can load it anytime...");
			}
		}
		catch (Exception)
		{
			if (bool_46)
			{
				MessageBox.Show("sorry, save profile failed!");
			}
		}
	}

	public void method_38(GClass4 gclass4_0)
	{
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = GClass1.smethod_22(gclass4_0.String_0);
			string text = "";
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.Length <= 1)
				{
					continue;
				}
				string[] array3 = text2.Split(new char[1] { '|' });
				if (!(array3[0] != gclass4_0.String_0))
				{
					if (array3[1] == "99")
					{
						text = array3[2];
					}
					if (array3[1] == "0" && gclass4_0.Int32_0 >= 10)
					{
						Single_0 = float.Parse(array3[2]);
					}
					if (array3[1] == "1" && gclass4_0.Int32_0 >= 10)
					{
						Single_1 = float.Parse(array3[2]);
					}
					if (array3[1] == "2" && gclass4_0.Int32_0 >= 10)
					{
						Int32_0 = int.Parse(array3[2]);
					}
					if (array3[1] == "3" && gclass4_0.Int32_0 >= 10)
					{
						Int32_1 = int.Parse(array3[2]);
					}
					if (array3[1] == "4" && gclass4_0.Int32_0 >= 10)
					{
						Int32_2 = int.Parse(array3[2]);
					}
					if (array3[1] == "5" && gclass4_0.Int32_0 >= 10)
					{
						Int32_3 = int.Parse(array3[2]);
					}
					if (array3[1] == "6" && gclass4_0.Int32_0 >= 10)
					{
						Int32_4 = int.Parse(array3[2]);
					}
					if (array3[1] == "7" && gclass4_0.Int32_0 >= 99)
					{
						String_2 = array3[2];
					}
					if (array3[1] == "8" && gclass4_0.Int32_0 >= 99)
					{
						Int32_5 = int.Parse(array3[2]);
					}
				}
			}
			for (int j = 0; j < text.Length; j++)
			{
				Boolean_2 = (text.Substring(j, 1) == "1" && j == 0 && gclass4_0.Int32_0 >= 0) || Boolean_2;
				Boolean_3 = (text.Substring(j, 1) == "1" && j == 1 && gclass4_0.Int32_0 >= 10) || Boolean_3;
				Boolean_4 = (text.Substring(j, 1) == "1" && j == 2 && gclass4_0.Int32_0 >= 125) || Boolean_4;
				Boolean_5 = (text.Substring(j, 1) == "1" && j == 3 && gclass4_0.Int32_0 >= 10) || Boolean_5;
				Boolean_6 = (text.Substring(j, 1) == "1" && j == 4 && gclass4_0.Int32_0 >= 10) || Boolean_6;
				Boolean_7 = (text.Substring(j, 1) == "1" && j == 5 && gclass4_0.Int32_0 >= 10) || Boolean_7;
				Boolean_8 = (text.Substring(j, 1) == "1" && j == 6 && gclass4_0.Int32_0 >= 10) || Boolean_8;
				Boolean_9 = (text.Substring(j, 1) == "1" && j == 7 && gclass4_0.Int32_0 >= 10) || Boolean_9;
				Boolean_10 = (text.Substring(j, 1) == "1" && j == 8 && gclass4_0.Int32_0 >= 10) || Boolean_10;
				Boolean_11 = (text.Substring(j, 1) == "1" && j == 9 && gclass4_0.Int32_0 >= 10) || Boolean_11;
				Boolean_12 = (text.Substring(j, 1) == "1" && j == 10 && gclass4_0.Int32_0 >= 99) || Boolean_12;
				Boolean_13 = (text.Substring(j, 1) == "1" && j == 11 && gclass4_0.Int32_0 >= 99) || Boolean_13;
				Boolean_14 = (text.Substring(j, 1) == "1" && j == 12 && gclass4_0.Int32_0 >= 99) || Boolean_14;
				Boolean_15 = (text.Substring(j, 1) == "1" && j == 13 && gclass4_0.Int32_0 >= 10) || Boolean_15;
				Boolean_16 = (text.Substring(j, 1) == "1" && j == 14 && gclass4_0.Int32_0 >= 10) || Boolean_16;
				Boolean_17 = (text.Substring(j, 1) == "1" && j == 15 && gclass4_0.Int32_0 >= 10) || Boolean_17;
				Boolean_18 = (text.Substring(j, 1) == "1" && j == 16 && gclass4_0.Int32_0 >= 10) || Boolean_18;
				Boolean_19 = (text.Substring(j, 1) == "1" && j == 17 && gclass4_0.Int32_0 >= 10) || Boolean_19;
				Boolean_20 = (text.Substring(j, 1) == "1" && j == 18 && gclass4_0.Int32_0 >= 150) || Boolean_20;
				Boolean_21 = (text.Substring(j, 1) == "1" && j == 19 && gclass4_0.Int32_0 >= 10) || Boolean_21;
				Boolean_22 = (text.Substring(j, 1) == "1" && j == 20 && gclass4_0.Int32_0 >= 99) || Boolean_22;
				Boolean_23 = (text.Substring(j, 1) == "1" && j == 21 && gclass4_0.Int32_0 >= 125) || Boolean_23;
				Boolean_24 = (text.Substring(j, 1) == "1" && j == 22 && gclass4_0.Int32_0 >= 150) || Boolean_24;
				Boolean_25 = (text.Substring(j, 1) == "1" && j == 23 && gclass4_0.Int32_0 >= 99) || Boolean_25;
				Boolean_26 = (text.Substring(j, 1) == "1" && j == 24 && gclass4_0.Int32_0 >= 99) || Boolean_26;
				Boolean_27 = (text.Substring(j, 1) == "1" && j == 25 && gclass4_0.Int32_0 >= 99) || Boolean_27;
				Boolean_28 = (text.Substring(j, 1) == "1" && j == 26 && gclass4_0.Int32_0 >= 99) || Boolean_28;
				Boolean_29 = (text.Substring(j, 1) == "1" && j == 27 && gclass4_0.Int32_0 >= 125) || Boolean_29;
				Boolean_30 = (text.Substring(j, 1) == "1" && j == 28 && gclass4_0.Int32_0 >= 99) || Boolean_30;
				Boolean_31 = (text.Substring(j, 1) == "1" && j == 29 && gclass4_0.Int32_0 >= 99) || Boolean_31;
				Boolean_32 = (text.Substring(j, 1) == "1" && j == 30 && gclass4_0.Int32_0 >= 99) || Boolean_32;
				Boolean_33 = (text.Substring(j, 1) == "1" && j == 31 && gclass4_0.Int32_0 >= 99) || Boolean_33;
				Boolean_34 = (text.Substring(j, 1) == "1" && j == 32 && gclass4_0.Int32_0 >= 10) || Boolean_34;
				Boolean_35 = (text.Substring(j, 1) == "1" && j == 33 && gclass4_0.Int32_0 >= 150) || Boolean_35;
				Boolean_36 = (text.Substring(j, 1) == "1" && j == 34 && gclass4_0.Int32_0 >= 150) || Boolean_36;
				Boolean_37 = (text.Substring(j, 1) == "1" && j == 35 && gclass4_0.Int32_0 >= 99) || Boolean_37;
				Boolean_38 = (text.Substring(j, 1) == "1" && j == 36 && gclass4_0.Int32_0 >= 99) || Boolean_38;
				Boolean_39 = (text.Substring(j, 1) == "1" && j == 37 && gclass4_0.Int32_0 >= 99) || Boolean_39;
				Boolean_40 = (text.Substring(j, 1) == "1" && j == 38 && gclass4_0.Int32_0 >= 99) || Boolean_40;
				Boolean_41 = (text.Substring(j, 1) == "1" && j == 39 && gclass4_0.Int32_0 >= 99) || Boolean_41;
			}
			MessageBox.Show("gratz, load profile success! please check it");
		}
		catch (Exception)
		{
			MessageBox.Show("sorry, load profile failed");
		}
	}
}
