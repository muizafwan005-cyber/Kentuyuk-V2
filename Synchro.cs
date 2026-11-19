using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class Synchro : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class9
	{
		internal bool method_0(GClass6 gclass6_0)
		{
			return !gclass6_0.Boolean_0;
		}
	}

	private GClass4 gclass4_0;

	private List<GClass6> list_0 = new List<GClass6>();

	private GClass6 gclass6_0;

	private int int_0 = 7;

	private IContainer icontainer_0;

	private Button button5;

	private Button button1;

	private Label label14;

	private Label label13;

	private CheckBox checkBox33;

	private CheckBox checkBox32;

	private TextBox textBox9;

	private TextBox textBox8;

	private Label label7;

	private Label label6;

	private CheckBox checkBox30;

	private CheckBox checkBox29;

	private CheckBox checkBox28;

	private CheckBox checkBox27;

	private CheckBox checkBox21;

	private CheckBox checkBox13;

	private CheckBox checkBox18;

	private CheckBox checkBox7;

	private CheckBox checkBox6;

	private CheckBox checkBox1;

	private Panel panel1;

	private Panel panel4;

	private Label label4;

	private CheckBox checkBox10;

	private Label label3;

	private Label label2;

	private Label label1;

	private PictureBox pictureBox1;

	private Timer timer_0;

	private Timer timer_1;

	private Panel panel5;

	private Label label5;

	private void Synchro_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			GClass1.ReleaseCapture();
			GClass1.SendMessage(method_8(), 161, 2, 0);
		}
	}

	public Synchro(GClass4 gclass4_1)
	{
		InitializeComponent();
		gclass4_0 = gclass4_1;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Region = Region.FromHrgn(GClass1.CreateRoundRectRgn(0, 0, ((Control)this).Width, ((Control)this).Height, 20, 20));
		((Control)label1).Text = gclass4_0.String_0;
		((Control)label2).Text = "DelB x Synchronize";
		((Control)label3).Text = gclass4_0.String_1;
		((Control)label1).Location = new Point(((Control)this).Width - 20 - ((Control)label1).Width, 375);
		((Control)label2).Location = new Point(((Control)this).Width - 20 - ((Control)label2).Width, 397);
		((Control)label3).Location = new Point(((Control)this).Width - 20 - ((Control)label3).Width, 417);
		((Control)panel1).Visible = false;
		((Control)panel4).Visible = false;
		((Control)panel5).Visible = true;
		((Control)panel5).Location = new Point(110, 168);
		timer_0.Start();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure want to exit?", "DelB - Exit", (MessageBoxButtons)3, (MessageBoxIcon)48) == 6)
		{
			Application.Exit();
		}
	}

	private void button1_MouseEnter(object sender, EventArgs e)
	{
		((Control)button1).BackgroundImage = (Image)(object)Class10.Bitmap_5;
	}

	private void button1_MouseLeave(object sender, EventArgs e)
	{
		((Control)button1).BackgroundImage = (Image)(object)Class10.Bitmap_4;
	}

	private void button5_Click(object sender, EventArgs e)
	{
		((Form)this).WindowState = (FormWindowState)1;
	}

	private void button5_MouseEnter(object sender, EventArgs e)
	{
		((Control)button5).BackgroundImage = (Image)(object)Class10.Bitmap_13;
	}

	private void button5_MouseLeave(object sender, EventArgs e)
	{
		((Control)button5).BackgroundImage = (Image)(object)Class10.Bitmap_12;
	}

	private void method_0()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		bool flag = false;
		double num = 0.0;
		int num2 = 10;
		int num3 = 0;
		foreach (GClass6 item in list_0)
		{
			if (item.Boolean_1)
			{
				continue;
			}
			if (item.CheckBox_0 == null)
			{
				item.CheckBox_0 = new CheckBox();
				item.CheckBox_0.Appearance = (Appearance)1;
				((Control)item.CheckBox_0).AutoSize = true;
				((Control)item.CheckBox_0).BackColor = Color.Transparent;
				((Control)item.CheckBox_0).ForeColor = Color.White;
				((Control)item.CheckBox_0).BackgroundImageLayout = (ImageLayout)0;
				((ButtonBase)item.CheckBox_0).FlatAppearance.BorderSize = 1;
				((ButtonBase)item.CheckBox_0).FlatAppearance.CheckedBackColor = Color.Gray;
				((ButtonBase)item.CheckBox_0).FlatAppearance.MouseDownBackColor = Color.Transparent;
				((ButtonBase)item.CheckBox_0).FlatAppearance.MouseOverBackColor = Color.Gray;
				((ButtonBase)item.CheckBox_0).FlatStyle = (FlatStyle)0;
				((Control)item.CheckBox_0).Name = "cbAva" + item.Process_0.Id;
				((Control)item.CheckBox_0).TabIndex = 9;
				((Control)item.CheckBox_0).Text = item.GClass3_0.String_0;
				((ButtonBase)item.CheckBox_0).TextAlign = (ContentAlignment)32;
				((ButtonBase)item.CheckBox_0).UseVisualStyleBackColor = false;
				item.CheckBox_0.CheckedChanged += method_1;
			}
			if (item.GClass3_0.String_0 != "")
			{
				((Control)item.CheckBox_0).Text = item.GClass3_0.String_0;
				((Control)panel4).Controls.Add((Control)(object)item.CheckBox_0);
				num += (double)((Control)item.CheckBox_0).Width;
				num3++;
				if (!item.Timer_0.Enabled)
				{
					item.Timer_0.Start();
				}
				if (!item.Timer_1.Enabled)
				{
					item.Timer_1.Start();
				}
				if (!item.Timer_2.Enabled && item.Boolean_27)
				{
					item.Timer_2.Start();
				}
				if (!item.Timer_3.Enabled && (item.Boolean_19 || item.Boolean_20))
				{
					item.Timer_3.Start();
				}
			}
			if (gclass6_0 != null && item.Process_0.Id == gclass6_0.Process_0.Id && gclass6_0.GClass3_0.String_0 != "")
			{
				flag = true;
				gclass6_0.CheckBox_0.Checked = true;
			}
		}
		num += (double)(num2 * (num3 - 1));
		int num4 = (int)Math.Round((double)((Control)panel4).Width / 2.0 - num / 2.0);
		foreach (GClass6 item2 in list_0)
		{
			if (item2.Boolean_1)
			{
				continue;
			}
			((Control)item2.CheckBox_0).Location = new Point(num4, 12);
			((Control)item2.CheckBox_0).Visible = true;
			((Control)item2.CheckBox_0).Enabled = true;
			if (flag)
			{
				if (gclass6_0.Process_0.Id != item2.Process_0.Id)
				{
					item2.CheckBox_0.Checked = false;
				}
			}
			else
			{
				item2.CheckBox_0.Checked = true;
				flag = true;
			}
			if (item2.CheckBox_0.Checked)
			{
				method_3(item2);
				method_2(item2);
			}
			num4 += ((Control)item2.CheckBox_0).Width + num2;
		}
	}

	public void method_1(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		CheckBox val = (CheckBox)sender;
		if (!val.Checked)
		{
			return;
		}
		int num = Convert.ToInt32(((Control)val).Name.Replace("cbAva", ""));
		foreach (GClass6 item in list_0)
		{
			if (item.Process_0.Id != num)
			{
				item.CheckBox_0.Checked = false;
				continue;
			}
			gclass6_0 = item;
			method_3(item);
			method_2(item);
		}
	}

	public void method_2(GClass6 gclass6_1)
	{
		if (gclass6_1.GClass3_0.Int32_1 != 0 && gclass6_1.GClass3_0.Int32_1 != 1)
		{
			if (gclass6_1.GClass3_0.Int32_1 != 2 && gclass6_1.GClass3_0.Int32_1 != 3)
			{
				((Control)checkBox32).Text = "TAB Target Bellato";
				((Control)checkBox33).Text = "TAB Target Cora";
			}
			else
			{
				((Control)checkBox32).Text = "TAB Target Accretia";
				((Control)checkBox33).Text = "TAB Target Bellato";
			}
		}
		else
		{
			((Control)checkBox32).Text = "TAB Target Accretia";
			((Control)checkBox33).Text = "TAB Target Cora";
		}
		if (gclass6_1.Boolean_2)
		{
			checkBox1.Checked = true;
		}
		else
		{
			checkBox1.Checked = false;
		}
		if (gclass6_1.Boolean_7)
		{
			checkBox6.Checked = true;
		}
		else
		{
			checkBox6.Checked = false;
		}
		if (gclass6_1.Boolean_8)
		{
			checkBox7.Checked = true;
		}
		else
		{
			checkBox7.Checked = false;
		}
		if (gclass6_1.Boolean_11)
		{
			checkBox10.Checked = true;
		}
		else
		{
			checkBox10.Checked = false;
		}
		if (gclass6_1.Boolean_14)
		{
			checkBox13.Checked = true;
		}
		else
		{
			checkBox13.Checked = false;
		}
		if (!gclass6_1.Boolean_19)
		{
			checkBox18.Checked = false;
		}
		else
		{
			checkBox18.Checked = true;
		}
		if (gclass6_1.Boolean_22)
		{
			checkBox21.Checked = true;
		}
		else
		{
			checkBox21.Checked = false;
		}
		if (gclass6_1.Boolean_25)
		{
			checkBox27.Checked = true;
		}
		else
		{
			checkBox27.Checked = false;
		}
		if (!gclass6_1.Boolean_26)
		{
			checkBox28.Checked = false;
		}
		else
		{
			checkBox28.Checked = true;
		}
		if (!gclass6_1.Boolean_27)
		{
			checkBox29.Checked = false;
		}
		else
		{
			checkBox29.Checked = true;
		}
		if (!gclass6_1.Boolean_28)
		{
			checkBox30.Checked = false;
		}
		else
		{
			checkBox30.Checked = true;
		}
		if (gclass6_1.Boolean_30)
		{
			checkBox32.Checked = true;
		}
		else
		{
			checkBox32.Checked = false;
		}
		if (gclass6_1.Boolean_31)
		{
			checkBox33.Checked = true;
		}
		else
		{
			checkBox33.Checked = false;
		}
		((Control)textBox8).Text = gclass6_1.Int32_5.ToString();
		((Control)textBox9).Text = gclass6_1.String_2.ToString();
		((Control)label13).Text = "Character Found: " + gclass6_1.Int32_6;
		((Control)label14).Text = "Tab Status: " + gclass6_1.String_3.ToString();
	}

	public void method_3(GClass6 gclass6_1)
	{
		((Control)label4).Text = string.Format("[{0}] {1} - {2} [{3}]", new object[4]
		{
			gclass6_1.GClass3_0.Int32_0,
			gclass6_1.GClass3_0.String_1,
			gclass6_1.GClass3_0.String_0,
			gclass6_1.GClass3_0.String_2
		});
		((Control)label4).Location = new Point(((Control)panel4).Width / 2 - ((Control)label4).Width / 2, 54);
	}

	private void method_4()
	{
		foreach (GClass6 item in list_0)
		{
			item.Boolean_0 = false;
		}
		Process[] processesByName = Process.GetProcessesByName("rF_oNlInE.bin");
		foreach (Process process in processesByName)
		{
			if (!process.ProcessName.ToLower().Contains("rf_online"))
			{
				continue;
			}
			bool flag = false;
			foreach (GClass6 item2 in list_0)
			{
				if (!item2.Boolean_1 && item2.Process_0.Id == process.Id)
				{
					flag = true;
					item2.Boolean_0 = true;
					item2.method_1();
					break;
				}
			}
			if (!flag)
			{
				GClass6 gClass = new GClass6(process);
				if (!gClass.Boolean_1)
				{
					gClass.method_1();
					gClass.Boolean_0 = true;
					method_5(gClass);
				}
				list_0.Add(gClass);
			}
		}
		foreach (GClass6 item3 in list_0)
		{
			if (item3.GClass3_0.String_0 == "" || !item3.Boolean_0)
			{
				method_6(item3);
			}
		}
		method_0();
		if (list_0.Count <= 0)
		{
			((Control)panel1).Visible = false;
			((Control)panel4).Visible = false;
			timer_1.Stop();
		}
		else
		{
			((Control)panel1).Visible = int_0 == 7;
			((Control)panel4).Visible = true;
			timer_1.Start();
		}
	}

	private void method_5(GClass6 gclass6_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		gclass6_1.Timer_0 = new Timer();
		gclass6_1.Timer_0.Interval = 10;
		gclass6_1.Timer_0.Tick += gclass6_1.method_4;
		gclass6_1.Timer_0.Start();
		gclass6_1.Timer_1 = new Timer();
		gclass6_1.Timer_1.Interval = 100;
		gclass6_1.Timer_1.Tick += gclass6_1.method_5;
		gclass6_1.Timer_2 = new Timer();
		gclass6_1.Timer_2.Interval = 100;
		gclass6_1.Timer_2.Tick += gclass6_1.method_6;
		gclass6_1.Timer_3 = new Timer();
		gclass6_1.Timer_3.Interval = 500;
		gclass6_1.Timer_3.Tick += gclass6_1.method_7;
	}

	private void method_6(GClass6 gclass6_1)
	{
		((Control)panel4).Controls.Remove((Control)(object)gclass6_1.CheckBox_0);
		gclass6_1.Timer_0.Stop();
		gclass6_1.Timer_1.Stop();
		gclass6_1.Timer_2.Stop();
		gclass6_1.Timer_3.Stop();
	}

	private void method_7(CheckBox checkBox_0)
	{
		if (checkBox_0.Checked)
		{
			((ButtonBase)checkBox_0).Image = (Image)(object)Class10.Bitmap_9;
		}
		else
		{
			((ButtonBase)checkBox_0).Image = (Image)(object)Class10.Bitmap_14;
		}
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		method_7((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_2 = true;
		}
		else
		{
			gclass6_0.Boolean_2 = false;
		}
		gclass6_0.method_12((CheckBox)sender);
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_7 = false;
			gclass6_0.Boolean_23 = false;
		}
		else
		{
			gclass6_0.Boolean_7 = true;
			gclass6_0.Boolean_23 = true;
		}
		gclass6_0.method_27();
	}

	private void checkBox7_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_8 = true;
		}
		else
		{
			gclass6_0.Boolean_8 = false;
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_11 = false;
		}
		else
		{
			gclass6_0.Boolean_11 = true;
		}
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_14 = true;
		}
		else
		{
			gclass6_0.Boolean_14 = false;
		}
		gclass6_0.method_16();
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			if (gclass6_0.Int32_0 == 0)
			{
				gclass6_0.Int32_0 = 410;
			}
			gclass6_0.Timer_3.Interval = gclass6_0.Int32_0;
			gclass6_0.Timer_3.Start();
			gclass6_0.Boolean_21 = true;
			gclass6_0.Boolean_19 = true;
		}
		else
		{
			gclass6_0.Timer_3.Stop();
			gclass6_0.Boolean_21 = false;
			gclass6_0.Boolean_19 = false;
		}
		gclass6_0.method_14();
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_22 = false;
		}
		else
		{
			gclass6_0.Boolean_22 = true;
		}
		gclass6_0.method_17();
	}

	private void checkBox27_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_25 = true;
		}
		else
		{
			gclass6_0.Boolean_25 = false;
		}
	}

	private void checkBox28_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_26 = false;
		}
		else
		{
			gclass6_0.Boolean_26 = true;
		}
	}

	private void checkBox29_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_27 = false;
			checkBox27.Checked = false;
			checkBox28.Checked = false;
			((Control)checkBox27).Enabled = false;
			((Control)checkBox28).Enabled = false;
			checkBox32.Checked = false;
			checkBox33.Checked = false;
			((Control)checkBox32).Enabled = false;
			((Control)checkBox33).Enabled = false;
			((Control)textBox8).Enabled = false;
			((Control)textBox9).Enabled = false;
		}
		else
		{
			gclass6_0.Boolean_27 = true;
			((Control)checkBox27).Enabled = true;
			((Control)checkBox28).Enabled = true;
			((Control)checkBox32).Enabled = true;
			((Control)checkBox33).Enabled = true;
			((Control)textBox8).Enabled = true;
			((Control)textBox9).Enabled = true;
		}
		gclass6_0.method_20();
	}

	private void checkBox30_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_28 = true;
		}
		else
		{
			gclass6_0.Boolean_28 = false;
		}
		gclass6_0.method_26();
	}

	private void checkBox32_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		string string_ = ((Control)(CheckBox)sender).Text.Replace("TAB Target ", "");
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.method_21(string_);
			gclass6_0.Boolean_30 = true;
		}
		else
		{
			gclass6_0.method_21(string_, "remove");
			gclass6_0.Boolean_30 = false;
		}
	}

	private void checkBox33_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		method_7((CheckBox)sender);
		string string_ = ((Control)(CheckBox)sender).Text.Replace("TAB Target ", "");
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.method_21(string_, "remove");
			gclass6_0.Boolean_31 = false;
		}
		else
		{
			gclass6_0.method_21(string_);
			gclass6_0.Boolean_31 = true;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_4();
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (gclass6_0 == null)
		{
			return;
		}
		try
		{
			gclass6_0.Int32_5 = int.Parse(((Control)textBox8).Text);
		}
		catch (Exception)
		{
			gclass6_0.Int32_5 = 200;
		}
		gclass6_0.String_2 = ((Control)textBox9).Text;
		if (checkBox18.Checked)
		{
			if ((GClass1.GetAsyncKeyState((Keys)122) & 0x8000) == 32768)
			{
				checkBox18.Checked = false;
				while (GClass1.GetAsyncKeyState((Keys)122) != 0)
				{
				}
			}
		}
		else if ((GClass1.GetAsyncKeyState((Keys)123) & 0x8000) == 32768)
		{
			checkBox18.Checked = true;
			while (GClass1.GetAsyncKeyState((Keys)123) != 0)
			{
			}
		}
	}

	private void label5_Click(object sender, EventArgs e)
	{
		((Control)label5).Cursor = Cursors.WaitCursor;
		method_4();
		((Control)label5).Cursor = Cursors.Hand;
	}

	protected override void Dispose(bool disposing)
	{
	    if (disposing && icontainer_0 != null)
	    {
	        icontainer_0.Dispose();
	    }
	    base.Dispose(disposing);
	}
	private IntPtr method_8()
	{
		return ((Control)this).Handle;
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Expected Obj, but got Unknown
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected Obj, but got Unknown
		//IL_16c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cb: Expected Obj, but got Unknown
		//IL_186c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Expected Obj, but got Unknown
		//IL_1903: Unknown result type (might be due to invalid IL or missing references)
		//IL_190d: Expected Obj, but got Unknown
		//IL_19aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b4: Expected Obj, but got Unknown
		//IL_1a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Expected Obj, but got Unknown
		//IL_1b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba8: Expected Obj, but got Unknown
		//IL_1d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d31: Expected Obj, but got Unknown
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(Synchro));
		button5 = new Button();
		button1 = new Button();
		label14 = new Label();
		label13 = new Label();
		checkBox33 = new CheckBox();
		checkBox32 = new CheckBox();
		textBox9 = new TextBox();
		textBox8 = new TextBox();
		label7 = new Label();
		label6 = new Label();
		checkBox30 = new CheckBox();
		checkBox29 = new CheckBox();
		checkBox28 = new CheckBox();
		checkBox27 = new CheckBox();
		checkBox21 = new CheckBox();
		checkBox13 = new CheckBox();
		checkBox18 = new CheckBox();
		checkBox7 = new CheckBox();
		checkBox6 = new CheckBox();
		checkBox1 = new CheckBox();
		panel1 = new Panel();
		panel4 = new Panel();
		label4 = new Label();
		checkBox10 = new CheckBox();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		panel5 = new Panel();
		label5 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel5).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)button5).BackColor = Color.Transparent;
		((Control)button5).Cursor = Cursors.Hand;
		((ButtonBase)button5).FlatAppearance.BorderSize = 0;
		((ButtonBase)button5).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)button5).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Location = new Point(734, 12);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(20, 20);
		((Control)button5).TabIndex = 122;
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button5).MouseEnter += button5_MouseEnter;
		((Control)button5).MouseLeave += button5_MouseLeave;
		((Control)button1).BackColor = Color.Transparent;
		((Control)button1).Cursor = Cursors.Hand;
		((ButtonBase)button1).FlatAppearance.BorderSize = 0;
		((ButtonBase)button1).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)button1).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Location = new Point(768, 12);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(20, 20);
		((Control)button1).TabIndex = 121;
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button1).MouseEnter += button1_MouseEnter;
		((Control)button1).MouseLeave += button1_MouseLeave;
		((Control)label14).AutoSize = true;
		((Control)label14).BackColor = Color.Transparent;
		((Control)label14).Location = new Point(292, 284);
		((Control)label14).Name = "label14";
		((Control)label14).Size = new Size(105, 13);
		((Control)label14).TabIndex = 140;
		((Control)label14).Text = "Tab Status: Running";
		((Control)label13).AutoSize = true;
		((Control)label13).BackColor = Color.Transparent;
		((Control)label13).Location = new Point(162, 284);
		((Control)label13).Name = "label13";
		((Control)label13).Size = new Size(116, 13);
		((Control)label13).TabIndex = 139;
		((Control)label13).Text = "Character Found: 1000";
		checkBox33.Appearance = (Appearance)1;
		((Control)checkBox33).AutoSize = true;
		((Control)checkBox33).BackColor = Color.Transparent;
		((Control)checkBox33).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox33).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox33).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox33).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox33).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox33).FlatStyle = (FlatStyle)0;
		((Control)checkBox33).Location = new Point(159, 251);
		((Control)checkBox33).Name = "checkBox33";
		((Control)checkBox33).Size = new Size(107, 23);
		((Control)checkBox33).TabIndex = 138;
		((Control)checkBox33).Text = "TAB Target Cora";
		((ButtonBase)checkBox33).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox33).UseVisualStyleBackColor = false;
		checkBox33.CheckedChanged += checkBox33_CheckedChanged;
		checkBox32.Appearance = (Appearance)1;
		((Control)checkBox32).AutoSize = true;
		((Control)checkBox32).BackColor = Color.Transparent;
		((Control)checkBox32).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox32).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox32).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox32).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox32).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox32).FlatStyle = (FlatStyle)0;
		((Control)checkBox32).Location = new Point(159, 222);
		((Control)checkBox32).Name = "checkBox32";
		((Control)checkBox32).Size = new Size(124, 23);
		((Control)checkBox32).TabIndex = 137;
		((Control)checkBox32).Text = "TAB Target Accretia";
		((ButtonBase)checkBox32).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox32).UseVisualStyleBackColor = false;
		checkBox32.CheckedChanged += checkBox32_CheckedChanged;
		((Control)textBox9).BackColor = Color.Black;
		((Control)textBox9).ForeColor = Color.White;
		((Control)textBox9).Location = new Point(459, 195);
		((Control)textBox9).Name = "textBox9";
		((Control)textBox9).Size = new Size(74, 20);
		((Control)textBox9).TabIndex = 136;
		textBox9.TextAlign = (HorizontalAlignment)2;
		((Control)textBox8).BackColor = Color.Black;
		((Control)textBox8).ForeColor = Color.White;
		((Control)textBox8).Location = new Point(330, 195);
		((Control)textBox8).Name = "textBox8";
		((Control)textBox8).Size = new Size(36, 20);
		((Control)textBox8).TabIndex = 135;
		((Control)textBox8).Text = "200";
		textBox8.TextAlign = (HorizontalAlignment)2;
		((Control)label7).AutoSize = true;
		((Control)label7).BackColor = Color.Transparent;
		((Control)label7).Location = new Point(385, 199);
		((Control)label7).Name = "label7";
		((Control)label7).Size = new Size(68, 13);
		((Control)label7).TabIndex = 134;
		((Control)label7).Text = "Lock Target:";
		((Control)label6).AutoSize = true;
		((Control)label6).BackColor = Color.Transparent;
		((Control)label6).Location = new Point(276, 199);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(52, 13);
		((Control)label6).TabIndex = 133;
		((Control)label6).Text = "Distance:";
		checkBox30.Appearance = (Appearance)1;
		((Control)checkBox30).AutoSize = true;
		((Control)checkBox30).BackColor = Color.Transparent;
		((Control)checkBox30).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox30).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox30).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox30).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox30).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox30).FlatStyle = (FlatStyle)0;
		((Control)checkBox30).Location = new Point(428, 251);
		((Control)checkBox30).Name = "checkBox30";
		((Control)checkBox30).Size = new Size(143, 23);
		((Control)checkBox30).TabIndex = 132;
		((Control)checkBox30).Text = "Auto Target CB [ BETA ]";
		((ButtonBase)checkBox30).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox30).UseVisualStyleBackColor = false;
		checkBox30.CheckedChanged += checkBox30_CheckedChanged;
		checkBox29.Appearance = (Appearance)1;
		((Control)checkBox29).AutoSize = true;
		((Control)checkBox29).BackColor = Color.Transparent;
		((Control)checkBox29).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox29).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox29).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox29).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox29).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox29).FlatStyle = (FlatStyle)0;
		((Control)checkBox29).Location = new Point(159, 194);
		((Control)checkBox29).Name = "checkBox29";
		((Control)checkBox29).Size = new Size(115, 23);
		((Control)checkBox29).TabIndex = 131;
		((Control)checkBox29).Text = "Auto TAB Target | ";
		((ButtonBase)checkBox29).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox29).UseVisualStyleBackColor = false;
		checkBox29.CheckedChanged += checkBox29_CheckedChanged;
		checkBox28.Appearance = (Appearance)1;
		((Control)checkBox28).AutoSize = true;
		((Control)checkBox28).BackColor = Color.Transparent;
		((Control)checkBox28).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox28).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox28).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox28).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox28).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox28).FlatStyle = (FlatStyle)0;
		((Control)checkBox28).Location = new Point(295, 251);
		((Control)checkBox28).Name = "checkBox28";
		((Control)checkBox28).Size = new Size(109, 23);
		((Control)checkBox28).TabIndex = 130;
		((Control)checkBox28).Text = "TAB Target Guild";
		((ButtonBase)checkBox28).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox28).UseVisualStyleBackColor = false;
		checkBox28.CheckedChanged += checkBox28_CheckedChanged;
		checkBox27.Appearance = (Appearance)1;
		((Control)checkBox27).AutoSize = true;
		((Control)checkBox27).BackColor = Color.Transparent;
		((Control)checkBox27).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox27).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox27).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox27).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox27).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox27).FlatStyle = (FlatStyle)0;
		((Control)checkBox27).Location = new Point(295, 222);
		((Control)checkBox27).Name = "checkBox27";
		((Control)checkBox27).Size = new Size(109, 23);
		((Control)checkBox27).TabIndex = 129;
		((Control)checkBox27).Text = "TAB Target Party";
		((ButtonBase)checkBox27).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox27).UseVisualStyleBackColor = false;
		checkBox27.CheckedChanged += checkBox27_CheckedChanged;
		checkBox21.Appearance = (Appearance)1;
		((Control)checkBox21).AutoSize = true;
		((Control)checkBox21).BackColor = Color.Transparent;
		((Control)checkBox21).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox21).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox21).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox21).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox21).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox21).FlatStyle = (FlatStyle)0;
		((Control)checkBox21).Location = new Point(295, 76);
		((Control)checkBox21).Name = "checkBox21";
		((Control)checkBox21).Size = new Size(101, 23);
		((Control)checkBox21).TabIndex = 128;
		((Control)checkBox21).Text = "ALT + Tab Run";
		((ButtonBase)checkBox21).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox21).UseVisualStyleBackColor = false;
		checkBox21.CheckedChanged += checkBox21_CheckedChanged;
		checkBox13.Appearance = (Appearance)1;
		((Control)checkBox13).AutoSize = true;
		((Control)checkBox13).BackColor = Color.Transparent;
		((Control)checkBox13).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox13).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox13).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox13).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox13).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox13).FlatStyle = (FlatStyle)0;
		((Control)checkBox13).Location = new Point(295, 47);
		((Control)checkBox13).Name = "checkBox13";
		((Control)checkBox13).Size = new Size(108, 23);
		((Control)checkBox13).TabIndex = 126;
		((Control)checkBox13).Text = "Skill After Revive";
		((ButtonBase)checkBox13).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox13).UseVisualStyleBackColor = false;
		checkBox13.CheckedChanged += checkBox13_CheckedChanged;
		checkBox18.Appearance = (Appearance)1;
		((Control)checkBox18).AutoSize = true;
		((Control)checkBox18).BackColor = Color.Transparent;
		((Control)checkBox18).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox18).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox18).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox18).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox18).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox18).FlatStyle = (FlatStyle)0;
		((Control)checkBox18).Location = new Point(428, 18);
		((Control)checkBox18).Name = "checkBox18";
		((Control)checkBox18).Size = new Size(96, 23);
		((Control)checkBox18).TabIndex = 127;
		((Control)checkBox18).Text = "Auto Fast Loot";
		((ButtonBase)checkBox18).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox18).UseVisualStyleBackColor = false;
		checkBox18.CheckedChanged += checkBox18_CheckedChanged;
		checkBox7.Appearance = (Appearance)1;
		((Control)checkBox7).AutoSize = true;
		((Control)checkBox7).BackColor = Color.Transparent;
		((Control)checkBox7).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox7).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox7).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox7).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox7).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox7).FlatStyle = (FlatStyle)0;
		((Control)checkBox7).Location = new Point(159, 76);
		((Control)checkBox7).Name = "checkBox7";
		((Control)checkBox7).Size = new Size(71, 23);
		((Control)checkBox7).TabIndex = 125;
		((Control)checkBox7).Text = "Anti Blind";
		((ButtonBase)checkBox7).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox7).UseVisualStyleBackColor = false;
		checkBox7.CheckedChanged += checkBox7_CheckedChanged;
		checkBox6.Appearance = (Appearance)1;
		((Control)checkBox6).AutoSize = true;
		((Control)checkBox6).BackColor = Color.Transparent;
		((Control)checkBox6).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox6).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox6).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox6).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox6).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox6).FlatStyle = (FlatStyle)0;
		((Control)checkBox6).Location = new Point(159, 47);
		((Control)checkBox6).Name = "checkBox6";
		((Control)checkBox6).Size = new Size(70, 23);
		((Control)checkBox6).TabIndex = 124;
		((Control)checkBox6).Text = "Anti Stun";
		((ButtonBase)checkBox6).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox6).UseVisualStyleBackColor = false;
		checkBox6.CheckedChanged += checkBox6_CheckedChanged;
		checkBox1.Appearance = (Appearance)1;
		((Control)checkBox1).AutoSize = true;
		((Control)checkBox1).BackColor = Color.Transparent;
		((Control)checkBox1).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox1).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox1).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox1).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox1).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox1).FlatStyle = (FlatStyle)0;
		((Control)checkBox1).Location = new Point(159, 18);
		((Control)checkBox1).Name = "checkBox1";
		((Control)checkBox1).Size = new Size(75, 23);
		((Control)checkBox1).TabIndex = 123;
		((Control)checkBox1).Text = "Eagle Eye";
		((ButtonBase)checkBox1).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox1).UseVisualStyleBackColor = false;
		checkBox1.CheckedChanged += checkBox1_CheckedChanged;
		((Control)panel1).BackColor = Color.Transparent;
		((Control)panel1).Controls.Add((Control)(object)checkBox10);
		((Control)panel1).Controls.Add((Control)(object)label14);
		((Control)panel1).Controls.Add((Control)(object)checkBox7);
		((Control)panel1).Controls.Add((Control)(object)label13);
		((Control)panel1).Controls.Add((Control)(object)checkBox1);
		((Control)panel1).Controls.Add((Control)(object)checkBox33);
		((Control)panel1).Controls.Add((Control)(object)checkBox6);
		((Control)panel1).Controls.Add((Control)(object)checkBox32);
		((Control)panel1).Controls.Add((Control)(object)checkBox18);
		((Control)panel1).Controls.Add((Control)(object)textBox9);
		((Control)panel1).Controls.Add((Control)(object)checkBox13);
		((Control)panel1).Controls.Add((Control)(object)textBox8);
		((Control)panel1).Controls.Add((Control)(object)checkBox21);
		((Control)panel1).Controls.Add((Control)(object)label7);
		((Control)panel1).Controls.Add((Control)(object)checkBox27);
		((Control)panel1).Controls.Add((Control)(object)label6);
		((Control)panel1).Controls.Add((Control)(object)checkBox28);
		((Control)panel1).Controls.Add((Control)(object)checkBox30);
		((Control)panel1).Controls.Add((Control)(object)checkBox29);
		((Control)panel1).Location = new Point(50, 100);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(700, 320);
		((Control)panel1).TabIndex = 141;
		((Control)panel1).MouseDown += Synchro_MouseDown;
		((Control)panel4).BackColor = Color.Transparent;
		((Control)panel4).Controls.Add((Control)(object)label4);
		((Control)panel4).Location = new Point(110, 15);
		((Control)panel4).Name = "panel4";
		((Control)panel4).Size = new Size(580, 77);
		((Control)panel4).TabIndex = 142;
		((Control)panel4).MouseDown += Synchro_MouseDown;
		((Control)label4).AutoSize = true;
		((Control)label4).BackColor = Color.Transparent;
		((Control)label4).Cursor = Cursors.Default;
		((Control)label4).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label4).Location = new Point(53, 54);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(229, 16);
		((Control)label4).TabIndex = 115;
		((Control)label4).Text = "[66] Bellato - nickname - Ranger";
		checkBox10.Appearance = (Appearance)1;
		((Control)checkBox10).AutoSize = true;
		((Control)checkBox10).BackColor = Color.Transparent;
		((Control)checkBox10).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox10).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox10).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox10).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox10).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox10).FlatStyle = (FlatStyle)0;
		((Control)checkBox10).Location = new Point(295, 18);
		((Control)checkBox10).Name = "checkBox10";
		((Control)checkBox10).Size = new Size(79, 23);
		((Control)checkBox10).TabIndex = 143;
		((Control)checkBox10).Text = "Auto Purse";
		((ButtonBase)checkBox10).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox10).UseVisualStyleBackColor = false;
		checkBox10.CheckedChanged += checkBox10_CheckedChanged;
		((Control)label3).AutoSize = true;
		((Control)label3).BackColor = Color.Transparent;
		((Control)label3).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label3).Location = new Point(731, 417);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(92, 13);
		((Control)label3).TabIndex = 146;
		((Control)label3).Text = "28 days remaining";
		((Control)label2).AutoSize = true;
		((Control)label2).BackColor = Color.Transparent;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(731, 397);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(31, 13);
		((Control)label2).TabIndex = 145;
		((Control)label2).Text = "VVIP";
		((Control)label1).AutoSize = true;
		((Control)label1).BackColor = Color.Transparent;
		((Control)label1).Cursor = Cursors.Default;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(731, 376);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(73, 16);
		((Control)label1).TabIndex = 144;
		((Control)label1).Text = "nickname";
		((Control)pictureBox1).BackColor = Color.Transparent;
		((Control)pictureBox1).BackgroundImageLayout = (ImageLayout)3;
		((Control)pictureBox1).Cursor = Cursors.Hand;
		((Control)pictureBox1).Location = new Point(9, 366);
		((Control)pictureBox1).Margin = new Padding(0);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(75, 75);
		pictureBox1.TabIndex = 143;
		pictureBox1.TabStop = false;
		timer_0.Interval = 5000;
		timer_0.Tick += timer_0_Tick;
		timer_1.Tick += timer_1_Tick;
		((Control)panel5).BackColor = Color.Transparent;
		((Control)panel5).Controls.Add((Control)(object)label5);
		((Control)panel5).Location = new Point(110, 188);
		((Control)panel5).Name = "panel5";
		((Control)panel5).Size = new Size(580, 75);
		((Control)panel5).TabIndex = 147;
		((Control)panel5).MouseDown += Synchro_MouseDown;
		((Control)label5).AutoSize = true;
		((Control)label5).Cursor = Cursors.Hand;
		((Control)label5).Font = new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label5).ForeColor = Color.Gray;
		((Control)label5).Location = new Point(21, 25);
		((Control)label5).Name = "label5";
		((Control)label5).Size = new Size(538, 25);
		((Control)label5).TabIndex = 0;
		((Control)label5).Text = "There is no RFs detected. Click here to scan now.";
		((Control)label5).Click += label5_Click;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		((Form)this).ClientSize = new Size(800, 450);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)pictureBox1);
		((Control)this).Controls.Add((Control)(object)panel4);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)panel1);
		((Control)this).Controls.Add((Control)(object)panel5);
		((Control)this).ForeColor = Color.White;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Synchro";
		((Control)this).Text = "Synchro";
		((Control)this).MouseDown += Synchro_MouseDown;
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel5).ResumeLayout(false);
		((Control)panel5).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
