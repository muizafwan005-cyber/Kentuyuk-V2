using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using RFSNCS.Memory;
using RFSNCS.Properties;

public class App : Form
{
	private sealed class Class6
	{
		public GClass6 gclass6_0;

		internal void method_0(object sender, DoWorkEventArgs e)
		{
			gclass6_0.method_10();
		}
	}

	[CompilerGenerated]
	private sealed class Class7
	{
		public List<CheckBox> list_0;

		public Class6 class6_0;

		internal void method_0(object sender, RunWorkerCompletedEventArgs e)
		{
			class6_0.gclass6_0.method_11(list_0);
		}
	}

	private int uniqueAutoTabTargetPartyAndGuildHotKeyId;

	private int uniqueAutoTabMonsterHotKeyId;

	private string appVersion;

	private GClass4 gclass4_0;

	private List<GClass6> list_0;

	private GClass6 gclass6_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private IContainer icontainer_0;

	private Button button1;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private Panel panel1;

	private CheckBox checkBox1;

	private CheckBox checkBox12;

	private CheckBox checkBox11;

	private CheckBox checkBox10;

	private CheckBox checkBox9;

	private CheckBox checkBox8;

	private CheckBox checkBox7;

	private CheckBox checkBox6;

	private CheckBox checkBox5;

	private CheckBox checkBox4;

	private CheckBox checkBox3;

	private CheckBox checkBox2;

	private CheckBox checkBox13;

	private GroupBox groupBox1;

	private CheckBox checkBox14;

	private GroupBox groupBox2;

	private RadioButton radioButton1;

	private CheckBox checkBox17;

	private CheckBox checkBox16;

	private CheckBox checkBox15;

	private RadioButton radioButton2;

	private RadioButton radioButton3;

	private Panel panel2;

	private Panel panel3;

	private CheckBox checkBox21;

	private CheckBox checkBox20;

	private CheckBox checkBox19;

	private CheckBox checkBox18;

	private CheckBox checkBox22;

	private PictureBox pictureBox5;

	private PictureBox pictureBox6;

	private PictureBox pictureBox7;

	private PictureBox pictureBox8;

	private CheckBox checkBox23;

	private CheckBox checkBox24;

	private CheckBox checkBox26;

	private CheckBox checkBox25;

	private Timer timer_0;

	private Panel panel4;

	private Label label4;

	private Panel panel5;

	private Label label5;

	private CheckBox checkBox28;

	private CheckBox checkBox27;

	private TextBox tbxASPD;

	private CheckBox checkBox30;

	private CheckBox checkBox29;

	private TextBox textBox2;

	private TextBox textBox3;

	private TextBox textBox7;

	private TextBox textBox6;

	private TextBox textBox5;

	private TextBox textBox4;

	private TextBox textBox8;

	private Label lblLockTarget;

	private Label label6;

	private TextBox textBox9;

	private PictureBox pictureBox9;

	private PictureBox pictureBox10;

	private Panel panel6;

	private GroupBox groupBox3;

	private Button button2;

	private TextBox textBox10;

	private Label label8;

	private Label label11;

	private TextBox textBox12;

	private Label label10;

	private Button button3;

	private TextBox textBox11;

	private Label label9;

	private GroupBox groupBox4;

	private Label label12;

	private CheckBox checkBox31;

	private Button button4;

	private Timer timer_1;

	private CheckBox checkBox33;

	private CheckBox checkBox32;

	private Label label13;

	private Label label14;

	private CheckBox checkBox36;

	private CheckBox checkBox35;

	private CheckBox checkBox34;

	private Button button5;

	private CheckBox checkBox37;

	private Label label15;

	private CheckBox checkBox38;

	private CheckBox checkBox39;

	private CheckBox checkBox40;

	private CheckBox checkBox44;

	private CheckBox checkBox41;

	private Button button6;

	private Button button7;

	private CheckBox checkBox42;

	private IContainer components;

	private CheckBox chkDelayButton;

	private TextBox tbxButtonDelay;

	private CheckBox checkBox43;

	private CheckBox checkBox45;

	private Label lblVersion;

	private CheckBox checkBox46;

	private Process currentProcess { get; set; }

	private void App_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			GClass1.ReleaseCapture();
			GClass1.SendMessage(method_17(), 161, 2, 0);
		}
	}

	public App(GClass4 gclass4_1)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		uniqueAutoTabTargetPartyAndGuildHotKeyId = 1;
		uniqueAutoTabMonsterHotKeyId = 2;
		appVersion = "1.0.3";
		list_0 = new List<GClass6>();
		int_0 = 7;
		int_1 = 7;
		int_2 = 20;
		int_3 = 20;
		int_4 = 18;
		InitializeComponent();
		((Control)lblVersion).Text = $"Version : {appVersion}";
		MemoryAPI.RegisterHotKey(((Control)this).Handle, uniqueAutoTabTargetPartyAndGuildHotKeyId, 1, ((object)(Keys)81/*cast due to constrained. prefix*/).GetHashCode());
		MemoryAPI.RegisterHotKey(((Control)this).Handle, uniqueAutoTabMonsterHotKeyId, 0, ((object)(Keys)9/*cast due to constrained. prefix*/).GetHashCode());
		gclass4_0 = gclass4_1;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Region = Region.FromHrgn(GClass1.CreateRoundRectRgn(0, 0, ((Control)this).Width, ((Control)this).Height, 20, 20));
		method_0();
		((Control)label1).Text = gclass4_0.String_0;
		((Control)label3).Text = gclass4_0.String_1;
		((Control)label1).Location = new Point(165 - ((Control)label1).Width / 2, 387);
		((Control)label2).Location = new Point(165 - ((Control)label2).Width / 2, 407);
		((Control)label3).Location = new Point(165 - ((Control)label3).Width / 2, 422);
		((Control)panel1).Visible = true;
		((Control)panel2).Visible = true;
		((Control)panel3).Visible = true;
		((Control)panel4).Visible = true;
		((Control)panel5).Visible = true;
		((Control)panel6).Visible = true;
		((Control)panel1).Location = new Point(50, 83);
		((Control)panel2).Location = new Point(110, 83);
		((Control)panel3).Location = new Point(110, 83);
		((Control)panel6).Location = new Point(50, 83);
		((Control)panel5).Location = new Point(110, 168);
		((Control)pictureBox5).Visible = true;
		((Control)pictureBox6).Visible = true;
		((Control)pictureBox7).Visible = true;
		((Control)pictureBox9).Visible = true;
		((Control)panel1).BackColor = Color.FromArgb(200, 0, 0, 0);
		((Control)panel2).BackColor = Color.FromArgb(200, 0, 0, 0);
		((Control)panel3).BackColor = Color.FromArgb(200, 0, 0, 0);
		((Control)panel4).BackColor = Color.FromArgb(200, 0, 0, 0);
		((Control)panel5).BackColor = Color.FromArgb(200, 0, 0, 0);
		((Control)panel6).BackColor = Color.FromArgb(200, 0, 0, 0);
		timer_0.Start();
	}

	private void method_0()
	{
		gclass4_0.Int32_0 = 300;
		if (gclass4_0.Int32_0 >= 300)
		{
			((Control)label2).Text = "GOD MODE";
			method_1(new int[1] { 31 });
		}
		else if (gclass4_0.Int32_0 < 200)
		{
			if (gclass4_0.Int32_0 != 150)
			{
				if (gclass4_0.Int32_0 < 125)
				{
					if (gclass4_0.Int32_0 < 100)
					{
						if (gclass4_0.Int32_0 >= 99)
						{
							((Control)label2).Text = "VVIP";
							method_1(new int[7] { 3, 19, 22, 23, 31, 38, 39 });
							((Control)textBox11).Enabled = false;
							((Control)button3).Enabled = false;
						}
						else if (gclass4_0.Int32_0 < 10)
						{
							((Control)label2).Text = "Zero";
							method_1(new int[36]
							{
								2, 3, 4, 5, 6, 7, 8, 9, 10, 11,
								12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
								22, 23, 27, 28, 29, 30, 31, 35, 36, 37,
								38, 39, 40, 41, 42, 44
							});
							((Control)groupBox2).Enabled = false;
							((Control)label13).Visible = false;
							((Control)label14).Visible = false;
							((Control)textBox11).Enabled = false;
							((Control)button3).Enabled = false;
						}
						else
						{
							((Control)label2).Text = "Normal";
							method_1(new int[21]
							{
								3, 4, 11, 12, 13, 19, 22, 23, 27, 28,
								29, 30, 31, 35, 36, 38, 39, 40, 41, 42,
								44
							});
							((Control)groupBox2).Enabled = false;
							((Control)label13).Visible = false;
							((Control)label14).Visible = false;
							((Control)textBox11).Enabled = false;
							((Control)button3).Enabled = false;
						}
					}
					else
					{
						((Control)label2).Text = "VVIP";
						method_1(new int[3] { 3, 22, 31 });
					}
				}
				else
				{
					((Control)label2).Text = "VVIP Brutal";
					method_1(new int[4] { 19, 23, 38, 39 });
					((Control)textBox11).Enabled = false;
					((Control)button3).Enabled = false;
				}
			}
			else
			{
				((Control)label2).Text = "Farm Mode";
				method_1(new int[31]
				{
					2, 3, 4, 5, 6, 7, 8, 9, 10, 11,
					12, 13, 14, 15, 16, 17, 18, 20, 21, 22,
					27, 28, 29, 30, 31, 35, 36, 40, 41, 42,
					44
				});
			}
		}
		else
		{
			((Control)label2).Text = "X HALF";
			method_1(new int[3] { 3, 22, 31 });
		}
		((Control)textBox8).Enabled = false;
		((Control)textBox9).Enabled = false;
		((Control)textBox10).Enabled = false;
		((Control)textBox12).Enabled = false;
		((Control)button2).Enabled = false;
		((Control)checkBox27).Enabled = false;
		((Control)checkBox28).Enabled = false;
		((Control)checkBox32).Enabled = false;
		((Control)checkBox33).Enabled = false;
		((Control)checkBox34).Enabled = false;
		((Control)checkBox11).Enabled = false;
		((Control)checkBox12).Enabled = true;
		((Control)tbxButtonDelay).Visible = false;
	}

	private void method_1(int[] int_5)
	{
		foreach (Panel item in ((IEnumerable)((Control)this).Controls).OfType<Panel>())
		{
			foreach (CheckBox item2 in ((IEnumerable)((Control)item).Controls).OfType<CheckBox>())
			{
				if (int.TryParse(((Control)item2).Name.ToLower().Replace("checkbox", ""), out var result) && Enumerable.Contains(int_5, result))
				{
					((Control)item2).Enabled = false;
				}
				method_13(item2);
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure want to exit?", "KENTUYUK HELPER - Exit", (MessageBoxButtons)3, (MessageBoxIcon)48) == 6)
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

	private void method_2()
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
				item.CheckBox_0.CheckedChanged += method_3;
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
				if (!item.Timer_4.Enabled && item.Boolean_24)
				{
					item.Timer_4.Start();
				}
				if (item.BackgroundWorker_0 == null)
				{
					method_9(item);
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
			if (!item2.Boolean_1)
			{
				((Control)item2.CheckBox_0).Location = new Point(num4, 12);
				((Control)item2.CheckBox_0).Visible = true;
				((Control)item2.CheckBox_0).Enabled = true;
				if (!flag)
				{
					item2.CheckBox_0.Checked = true;
					flag = true;
				}
				else if (gclass6_0.Process_0.Id != item2.Process_0.Id)
				{
					item2.CheckBox_0.Checked = false;
				}
				if (item2.CheckBox_0.Checked)
				{
					method_5(item2);
					method_4(item2);
				}
				num4 += ((Control)item2.CheckBox_0).Width + num2;
			}
		}
	}

	public void method_3(object sender, EventArgs e)
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
			if (item.Process_0.Id == num)
			{
				gclass6_0 = item;
				method_5(item);
				method_4(item);
			}
			else
			{
				item.CheckBox_0.Checked = false;
			}
		}
	}

	public void method_4(GClass6 gclass6_1)
	{
		if (gclass6_1.GClass3_0.Int32_1 == 0 || gclass6_1.GClass3_0.Int32_1 == 1)
		{
			((Control)checkBox32).Text = "TAB Target Accretia";
			((Control)checkBox33).Text = "TAB Target Cora";
		}
		else if (gclass6_1.GClass3_0.Int32_1 == 2 || gclass6_1.GClass3_0.Int32_1 == 3)
		{
			((Control)checkBox32).Text = "TAB Target Accretia";
			((Control)checkBox33).Text = "TAB Target Bellato";
		}
		else
		{
			((Control)checkBox32).Text = "TAB Target Bellato";
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
		if (!gclass6_1.Boolean_3)
		{
			checkBox2.Checked = false;
		}
		else
		{
			checkBox2.Checked = true;
		}
		if (!gclass6_1.Boolean_4)
		{
		}
		if (gclass6_1.Boolean_5)
		{
			checkBox4.Checked = true;
		}
		else
		{
			checkBox4.Checked = false;
		}
		if (!gclass6_1.Boolean_6)
		{
			checkBox5.Checked = false;
		}
		else
		{
			checkBox5.Checked = true;
		}
		if (gclass6_1.Boolean_7)
		{
			checkBox6.Checked = true;
		}
		else
		{
			checkBox6.Checked = false;
		}
		if (!gclass6_1.Boolean_8)
		{
			checkBox7.Checked = false;
		}
		else
		{
			checkBox7.Checked = true;
		}
		if (gclass6_1.Boolean_9)
		{
			checkBox8.Checked = true;
		}
		else
		{
			checkBox8.Checked = false;
		}
		if (gclass6_1.Boolean_10)
		{
			checkBox9.Checked = true;
		}
		else
		{
			checkBox9.Checked = false;
		}
		if (!gclass6_1.Boolean_11)
		{
			checkBox10.Checked = false;
		}
		else
		{
			checkBox10.Checked = true;
		}
		if (gclass6_1.Boolean_12)
		{
			checkBox11.Checked = true;
		}
		else
		{
			checkBox11.Checked = false;
		}
		if (gclass6_1.Boolean_13)
		{
			checkBox12.Checked = true;
		}
		else
		{
			checkBox12.Checked = false;
		}
		if (gclass6_1.Boolean_14)
		{
			checkBox13.Checked = true;
		}
		else
		{
			checkBox13.Checked = false;
		}
		if (!gclass6_1.Boolean_15)
		{
			checkBox14.Checked = false;
		}
		else
		{
			checkBox14.Checked = true;
		}
		if (gclass6_1.Boolean_16)
		{
			checkBox15.Checked = true;
		}
		else
		{
			checkBox15.Checked = false;
		}
		if (gclass6_1.Boolean_17)
		{
			checkBox16.Checked = true;
		}
		else
		{
			checkBox16.Checked = false;
		}
		if (!gclass6_1.Boolean_18)
		{
			checkBox17.Checked = false;
		}
		else
		{
			checkBox17.Checked = true;
		}
		if (gclass6_1.Boolean_19)
		{
			checkBox18.Checked = true;
		}
		else
		{
			checkBox18.Checked = false;
		}
		if (!gclass6_1.Boolean_20)
		{
			checkBox19.Checked = false;
		}
		else
		{
			checkBox19.Checked = true;
		}
		if (!gclass6_1.Boolean_21)
		{
			checkBox20.Checked = false;
		}
		else
		{
			checkBox20.Checked = true;
		}
		if (gclass6_1.Boolean_22)
		{
			checkBox21.Checked = true;
		}
		else
		{
			checkBox21.Checked = false;
		}
		if (gclass6_1.Boolean_23)
		{
			checkBox22.Checked = true;
		}
		else
		{
			checkBox22.Checked = false;
		}
		if (gclass6_1.Boolean_24)
		{
			checkBox23.Checked = true;
		}
		else
		{
			checkBox23.Checked = false;
		}
		if (!gclass6_1.Boolean_25)
		{
			checkBox27.Checked = false;
		}
		else
		{
			checkBox27.Checked = true;
		}
		if (!gclass6_1.Boolean_26)
		{
			checkBox28.Checked = false;
		}
		else
		{
			checkBox28.Checked = true;
		}
		if (gclass6_1.Boolean_27)
		{
			checkBox29.Checked = true;
		}
		else
		{
			checkBox29.Checked = false;
		}
		if (gclass6_1.Boolean_28)
		{
			checkBox30.Checked = true;
		}
		else
		{
			checkBox30.Checked = false;
		}
		if (gclass6_1.Boolean_29)
		{
			checkBox31.Checked = true;
		}
		else
		{
			checkBox31.Checked = false;
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
		if (gclass6_1.Boolean_32)
		{
			checkBox35.Checked = true;
		}
		else
		{
			checkBox35.Checked = false;
		}
		if (!gclass6_1.Boolean_33)
		{
			checkBox36.Checked = false;
		}
		else
		{
			checkBox36.Checked = true;
		}
		if (!gclass6_1.Boolean_34)
		{
			checkBox37.Checked = false;
		}
		else
		{
			checkBox37.Checked = true;
		}
		if (gclass6_1.Boolean_35)
		{
			checkBox38.Checked = true;
		}
		else
		{
			checkBox38.Checked = false;
		}
		if (!gclass6_1.Boolean_36)
		{
			checkBox39.Checked = false;
		}
		else
		{
			checkBox39.Checked = true;
		}
		if (!gclass6_1.Boolean_37)
		{
			checkBox40.Checked = false;
		}
		else
		{
			checkBox40.Checked = true;
		}
		if (!gclass6_1.Boolean_40)
		{
			checkBox41.Checked = false;
		}
		else
		{
			checkBox41.Checked = true;
		}
		if (gclass6_1.Boolean_41)
		{
			checkBox42.Checked = true;
		}
		else
		{
			checkBox42.Checked = false;
		}
		if (gclass6_1.Boolean_38)
		{
			checkBox44.Checked = true;
		}
		if (gclass6_1.Boolean_39)
		{
			((Control)checkBox44).Text = "Revive [ Auto ]";
			checkBox44.Checked = true;
		}
		if (!gclass6_1.Boolean_38 && !gclass6_1.Boolean_39)
		{
			((Control)checkBox44).Text = "Revive [ Normal ]";
			checkBox44.Checked = false;
		}
		((Control)tbxASPD).Text = gclass6_1.Single_0.ToString();
		((Control)textBox2).Text = gclass6_1.Single_1.ToString();
		((Control)textBox3).Text = gclass6_1.Int32_0.ToString();
		((Control)textBox4).Text = gclass6_1.Int32_1.ToString();
		((Control)textBox5).Text = gclass6_1.Int32_2.ToString();
		((Control)textBox6).Text = gclass6_1.Int32_3.ToString();
		((Control)textBox7).Text = gclass6_1.Int32_4.ToString();
		((Control)textBox8).Text = gclass6_1.Int32_5.ToString();
		((Control)textBox9).Text = gclass6_1.String_2.ToString();
		((Control)textBox12).Text = gclass6_1.Int32_7.ToString();
		((Control)label13).Text = "Character Found: " + gclass6_1.Int32_6;
		((Control)label14).Text = "Tab Status: " + gclass6_1.String_3.ToString();
	}

	public void method_5(GClass6 gclass6_1)
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

	private void method_6()
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
					method_7(gClass);
				}
				list_0.Add(gClass);
			}
		}
		foreach (GClass6 item3 in list_0)
		{
			if (item3.GClass3_0.String_0 == "" || !item3.Boolean_0)
			{
				method_8(item3);
			}
		}
		method_2();
		if (list_0.Count > 0)
		{
			((Control)panel5).Visible = false;
			((Control)panel1).Visible = int_0 == 7;
			((Control)panel2).Visible = int_0 == 8;
			((Control)panel3).Visible = int_0 == 9;
			((Control)panel6).Visible = int_0 == 10;
			((Control)panel4).Visible = true;
			timer_1.Start();
		}
		else
		{
			((Control)panel5).Visible = true;
			((Control)panel1).Visible = false;
			((Control)panel2).Visible = false;
			((Control)panel3).Visible = false;
			((Control)panel6).Visible = false;
			((Control)panel4).Visible = false;
			timer_1.Stop();
		}
	}

	private void method_7(GClass6 gclass6_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
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
		gclass6_1.Timer_4 = new Timer();
		gclass6_1.Timer_4.Interval = 100;
		gclass6_1.Timer_4.Tick += gclass6_1.LoadBot;
	}

	private void method_8(GClass6 gclass6_1)
	{
		((Control)panel4).Controls.Remove((Control)(object)gclass6_1.CheckBox_0);
		gclass6_1.Timer_0.Stop();
		gclass6_1.Timer_1.Stop();
		gclass6_1.Timer_2.Stop();
		gclass6_1.Timer_3.Stop();
		gclass6_1.Timer_4.Stop();
	}

	private void method_9(GClass6 gclass6_1)
	{
		Class6 @class = new Class6();
		@class.gclass6_0 = gclass6_1;
		if ((gclass4_0.Int32_0 >= 99 && gclass4_0.Int32_0 <= 125) || gclass4_0.Int32_0 >= 200)
		{
			Class6 class6_0 = @class;
			List<CheckBox> list_0 = new List<CheckBox> { checkBox11, checkBox12 };
			class6_0.gclass6_0.BackgroundWorker_0 = new BackgroundWorker();
			class6_0.gclass6_0.BackgroundWorker_0.DoWork += class6_0.method_0;
			class6_0.gclass6_0.BackgroundWorker_0.RunWorkerCompleted += (object sender, RunWorkerCompletedEventArgs e) =>
			{
				class6_0.gclass6_0.method_11(list_0);
			};
			class6_0.gclass6_0.BackgroundWorker_0.RunWorkerAsync();
		}
	}

	private void method_10(GClass6 gclass6_1)
	{
		((Control)groupBox4).Controls.Clear();
		int_3 = int_2;
		foreach (Label item in gclass6_1.List_1)
		{
			((Control)item).Location = new Point(int_1, int_3);
			((Control)groupBox4).Controls.Add((Control)(object)item);
			int_3 += int_4;
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		Process.Start("explorer.exe", "https://rb.gy/sx81eh");
	}

	private void pictureBox2_MouseHover(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ToolTip().SetToolTip((Control)(object)pictureBox2, "Basic Hacks");
	}

	private void pictureBox3_MouseHover(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ToolTip().SetToolTip((Control)(object)pictureBox3, "Brutal Hacks");
	}

	private void pictureBox4_MouseHover(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ToolTip().SetToolTip((Control)(object)pictureBox4, "Control & Settings");
	}

	private void method_11(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new ToolTip().SetToolTip((Control)(object)pictureBox10, "Tools & Bot");
	}

	private void method_12(int int_5)
	{
		int_0 = int_5;
		if (list_0.Count > 0)
		{
			((Control)panel1).Visible = int_5 == 7;
			((Control)panel2).Visible = int_5 == 8;
			((Control)panel3).Visible = int_5 == 9;
			((Control)panel6).Visible = int_5 == 10;
		}
		((Control)pictureBox5).Visible = int_5 == 7;
		((Control)pictureBox6).Visible = int_5 == 10;
		((Control)pictureBox7).Visible = int_5 == 9;
		((Control)pictureBox9).Visible = int_5 == 8;
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		method_12(7);
	}

	private void pictureBox3_Click(object sender, EventArgs e)
	{
		method_12(10);
	}

	private void pictureBox4_Click(object sender, EventArgs e)
	{
		method_12(9);
	}

	private void pictureBox10_Click(object sender, EventArgs e)
	{
		method_12(8);
	}

	private void method_13(CheckBox checkBox_0)
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
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_2 = true;
		}
		else
		{
			gclass6_0.Boolean_2 = false;
		}
		gclass6_0.LoadEagleEye();
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_3 = false;
			gclass6_0.method_23();
			return;
		}
		((Control)(CheckBox)sender).Enabled = false;
		((Control)tbxASPD).Visible = true;
		if (((Control)tbxASPD).Text == "")
		{
			((Control)tbxASPD).Text = gclass6_0.GClass3_0.Single_0.ToString();
		}
		((Control)tbxASPD).Focus();
	}

	private void checkBox3_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_13((CheckBox)sender);
		gclass6_0.IsExtremeASPD = checkBox3.Checked;
	}

	private void checkBox4_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_5 = true;
		}
		else
		{
			gclass6_0.Boolean_5 = false;
		}
		gclass6_0.method_15();
	}

	private void checkBox5_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_6 = false;
		}
		else
		{
			gclass6_0.Boolean_6 = true;
		}
		gclass6_0.method_13((CheckBox)sender);
	}

	private void checkBox6_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
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
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_8 = true;
			checkBox8.Checked = false;
		}
		else
		{
			gclass6_0.Boolean_8 = false;
		}
	}

	private void checkBox8_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_9 = false;
			return;
		}
		gclass6_0.Boolean_9 = true;
		checkBox7.Checked = false;
	}

	private void checkBox9_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			((Control)(CheckBox)sender).Enabled = false;
			((Control)textBox2).Visible = true;
			if (((Control)textBox2).Text == "")
			{
				((Control)textBox2).Text = gclass6_0.GClass3_0.Single_1.ToString();
			}
			((Control)textBox2).Focus();
		}
		else
		{
			gclass6_0.Boolean_10 = false;
		}
	}

	private void checkBox10_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_11 = false;
		}
		else
		{
			gclass6_0.Boolean_11 = true;
		}
	}

	private void checkBox11_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_12 = false;
		}
		else
		{
			gclass6_0.Boolean_12 = true;
		}
		gclass6_0.method_18();
	}

	private void checkBox12_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_13 = true;
		}
		else
		{
			gclass6_0.Boolean_13 = false;
		}
		gclass6_0.LoadSkillAllWeapon();
	}

	private void checkBox13_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_14 = false;
		}
		else
		{
			gclass6_0.Boolean_14 = true;
		}
		gclass6_0.method_16();
	}

	private void checkBox14_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			((Control)textBox4).Visible = true;
			if (((Control)textBox4).Text == "")
			{
				((Control)textBox4).Text = gclass6_0.GClass3_0.Int32_2.ToString();
			}
			((Control)textBox4).Focus();
			gclass6_0.Boolean_15 = true;
		}
		else
		{
			gclass6_0.Boolean_15 = false;
		}
	}

	private void checkBox15_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			((Control)textBox5).Visible = true;
			if (((Control)textBox5).Text == "")
			{
				((Control)textBox5).Text = gclass6_0.GClass3_0.Int32_3.ToString();
			}
			((Control)textBox5).Focus();
			gclass6_0.Boolean_16 = true;
		}
		else
		{
			gclass6_0.Boolean_16 = false;
		}
	}

	private void checkBox16_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			((Control)textBox6).Visible = true;
			if (((Control)textBox6).Text == "")
			{
				((Control)textBox6).Text = gclass6_0.GClass3_0.Int32_4.ToString();
			}
			((Control)textBox6).Focus();
			gclass6_0.Boolean_17 = true;
		}
		else
		{
			gclass6_0.Boolean_17 = false;
		}
	}

	private void checkBox17_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			((Control)textBox7).Visible = true;
			if (((Control)textBox7).Text == "")
			{
				((Control)textBox7).Text = gclass6_0.GClass3_0.Int32_5.ToString();
			}
			((Control)textBox7).Focus();
			gclass6_0.Boolean_18 = true;
		}
		else
		{
			gclass6_0.Boolean_18 = false;
		}
	}

	private void checkBox18_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Timer_3.Stop();
			if (!checkBox20.Checked)
			{
				gclass6_0.Boolean_21 = false;
			}
			gclass6_0.Boolean_19 = false;
		}
		else
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
		gclass6_0.method_14();
	}

	private void checkBox19_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_20 = true;
			gclass6_0.method_22();
			checkBox18.Checked = true;
		}
		else
		{
			gclass6_0.Boolean_20 = false;
			checkBox18.Checked = false;
			gclass6_0.method_22();
			gclass6_0.Timer_3.Stop();
		}
	}

	private void checkBox20_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			((Control)(CheckBox)sender).Enabled = false;
			((Control)textBox3).Visible = true;
			if (((Control)textBox3).Text == "")
			{
				((Control)textBox3).Text = gclass6_0.GClass3_0.Int64_0.ToString();
			}
			((Control)textBox3).Focus();
		}
		else
		{
			gclass6_0.Boolean_21 = false;
			gclass6_0.method_14();
		}
	}

	private void checkBox21_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_22 = true;
		}
		else
		{
			gclass6_0.Boolean_22 = false;
		}
		gclass6_0.method_17();
	}

	private void checkBox22_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_23 = true;
		}
		else
		{
			gclass6_0.Boolean_23 = false;
		}
		gclass6_0.method_27();
	}

	private void checkBox23_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_24 = true;
			((Control)textBox12).Enabled = true;
		}
		else
		{
			gclass6_0.Boolean_24 = false;
			((Control)textBox12).Enabled = false;
		}
		gclass6_0.method_29();
	}

	private void checkBox24_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			pictureBox2.Image = (Image)(object)Class10.Bitmap_11;
			pictureBox3.Image = (Image)(object)Class10.Bitmap_1;
			pictureBox4.Image = (Image)(object)Class10.Bitmap_16;
			pictureBox10.Image = (Image)(object)Class10.Bitmap_3;
		}
		else
		{
			pictureBox2.Image = (Image)(object)Class10.Bitmap_10;
			pictureBox3.Image = (Image)(object)Class10.Bitmap_8;
			pictureBox4.Image = (Image)(object)Class10.Bitmap_15;
			pictureBox10.Image = (Image)(object)Class10.Bitmap_2;
		}
	}

	private void checkBox25_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			timer_0.Stop();
			((Control)button4).Visible = true;
		}
		else
		{
			timer_0.Start();
			((Control)button4).Visible = false;
		}
	}

	private void checkBox26_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_44 = true;
		}
		else
		{
			gclass6_0.Boolean_44 = false;
		}
	}

	private void checkBox27_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_25 = false;
		}
		else
		{
			gclass6_0.Boolean_25 = true;
		}
	}

	private void checkBox28_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
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
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_27 = true;
			((Control)checkBox27).Enabled = true;
			((Control)checkBox28).Enabled = true;
			((Control)checkBox32).Enabled = true;
			((Control)checkBox33).Enabled = true;
			((Control)textBox8).Enabled = true;
			((Control)textBox9).Enabled = true;
			checkBox45.Checked = false;
		}
		else
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
		gclass6_0.method_20();
	}

	private void checkBox30_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_28 = false;
		}
		else
		{
			gclass6_0.Boolean_28 = true;
		}
		gclass6_0.method_26();
	}

	private void checkBox31_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_13((CheckBox)sender);
	}

	private void checkBox32_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		string string_ = ((Control)(CheckBox)sender).Text.Replace("TAB Target ", "");
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.method_21(string_, "remove");
			gclass6_0.Boolean_30 = false;
		}
		else
		{
			gclass6_0.method_21(string_);
			gclass6_0.Boolean_30 = true;
		}
	}

	private void checkBox33_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
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

	private void checkBox34_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_13((CheckBox)sender);
	}

	private void checkBox35_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_32 = false;
		}
		else
		{
			gclass6_0.Boolean_32 = true;
		}
		gclass6_0.method_24();
	}

	private void checkBox36_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_33 = true;
		}
		else
		{
			gclass6_0.Boolean_33 = false;
		}
		gclass6_0.method_25();
	}

	private void checkBox37_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_34 = true;
		}
		else
		{
			gclass6_0.Boolean_34 = false;
		}
		gclass6_0.method_28();
	}

	private void checkBox38_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (!((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_35 = false;
		}
		else
		{
			gclass6_0.Boolean_35 = true;
		}
		gclass6_0.method_30();
	}

	private void checkBox39_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_36 = true;
		}
		else
		{
			gclass6_0.Boolean_36 = false;
		}
	}

	private void checkBox40_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_37 = true;
		}
		else
		{
			gclass6_0.Boolean_37 = false;
		}
		gclass6_0.method_32();
	}

	private void checkBox41_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_40 = true;
		}
		else
		{
			gclass6_0.Boolean_40 = false;
		}
		gclass6_0.method_34();
	}

	private void checkBox42_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_41 = true;
		}
		else
		{
			gclass6_0.Boolean_41 = false;
		}
	}

	private void checkBox44_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			if (((Control)(CheckBox)sender).Text == "Revive [ Normal ]")
			{
				gclass6_0.Boolean_38 = true;
				gclass6_0.Boolean_39 = false;
				((Control)(CheckBox)sender).Text = "Revive [ Disabled ]";
				gclass6_0.method_33();
			}
			return;
		}
		if (((Control)(CheckBox)sender).Text == "Revive [ Auto ]")
		{
			gclass6_0.Boolean_38 = false;
			gclass6_0.Boolean_39 = false;
			((Control)(CheckBox)sender).Text = "Revive [ Normal ]";
			gclass6_0.method_33();
		}
		if (((Control)(CheckBox)sender).Text == "Revive [ Disabled ]")
		{
			gclass6_0.Boolean_38 = false;
			gclass6_0.Boolean_39 = true;
			((Control)(CheckBox)sender).Text = "Revive [ Auto ]";
			((CheckBox)sender).Checked = true;
			gclass6_0.method_33();
		}
	}

	private void method_14(RadioButton radioButton_0)
	{
		if (radioButton_0.Checked)
		{
			((ButtonBase)radioButton_0).Image = (Image)(object)Class10.Bitmap_9;
		}
		else
		{
			((ButtonBase)radioButton_0).Image = (Image)(object)Class10.Bitmap_14;
		}
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_14((RadioButton)sender);
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_14((RadioButton)sender);
	}

	private void radioButton3_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_14((RadioButton)sender);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_6();
		if (gclass6_0 != null && gclass6_0.Boolean_44)
		{
			gclass6_0.method_37(gclass4_0, bool_46: false);
		}
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
		((Control)checkBox2).Text = $"ASPD [{gclass6_0.GClass3_0.Single_0}]";
		((Control)checkBox9).Text = $"Speed Hack [{gclass6_0.GClass3_0.Single_1}]";
		((Control)checkBox20).Text = $"Loot Delay [{gclass6_0.GClass3_0.Int64_0}]";
		((Control)checkBox14).Text = $"WR [{gclass6_0.GClass3_0.Int32_2}]";
		((Control)checkBox15).Text = $"RA [{gclass6_0.GClass3_0.Int32_3}]";
		((Control)checkBox16).Text = $"FO [{gclass6_0.GClass3_0.Int32_4}]";
		((Control)checkBox17).Text = $"LC [{gclass6_0.GClass3_0.Int32_5}]";
		try
		{
			gclass6_0.Int32_7 = int.Parse(((Control)textBox12).Text);
		}
		catch (Exception)
		{
			gclass6_0.Int32_7 = 200;
		}
		if (gclass6_0.Boolean_35)
		{
			((Control)label15).Text = $"X: {gclass6_0.Single_2} - Y: {gclass6_0.Single_3} - Z: {gclass6_0.Single_4}";
		}
		else
		{
			((Control)label15).Text = $"X: {gclass6_0.GClass3_0.Single_2} - Y: {gclass6_0.GClass3_0.Single_3} - Z: {gclass6_0.GClass3_0.Single_4}";
		}
		if (!checkBox23.Checked)
		{
			((Control)checkBox23).Text = "Bot Mode [ OFF ]";
		}
		else
		{
			((Control)checkBox23).Text = "Bot Mode [ ON ]";
		}
		if (checkBox14.Checked)
		{
			method_15(textBox4, 255);
		}
		if (checkBox15.Checked)
		{
			method_15(textBox5, 255);
		}
		if (checkBox16.Checked)
		{
			method_15(textBox6, 255);
		}
		if (checkBox17.Checked)
		{
			method_15(textBox7, 255);
		}
		if (checkBox29.Checked)
		{
			method_15(textBox8, 2000);
		}
		if (checkBox23.Checked)
		{
			method_15(textBox12, 2000);
		}
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

	private void method_15(TextBox textBox_0, int int_5)
	{
		try
		{
			if (int.Parse(((Control)textBox_0).Text) > int_5)
			{
				((Control)textBox_0).Text = int_5.ToString();
			}
		}
		catch (Exception)
		{
		}
	}

	private void label5_Click(object sender, EventArgs e)
	{
		((Control)label5).Cursor = Cursors.WaitCursor;
		method_6();
		((Control)label5).Cursor = Cursors.Hand;
	}

	private void method_16(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		Label val = (Label)sender;
		((Control)groupBox4).Controls.Remove((Control)(object)val);
		gclass6_0.List_1.Remove(val);
		gclass6_0.List_2.Remove(((Control)val).Text);
		method_10(gclass6_0);
	}

	private void tbxASPD_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Single_0 = float.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_3 = true;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox2.Checked = false;
			}
			((Control)checkBox2).Enabled = true;
		}
	}

	private void textBox2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Single_1 = float.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_10 = true;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox9.Checked = false;
			}
			((Control)checkBox9).Enabled = true;
		}
	}

	private void textBox3_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Int32_0 = int.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_21 = true;
				gclass6_0.method_14();
				gclass6_0.Timer_3.Interval = gclass6_0.Int32_0;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox20.Checked = false;
			}
			((Control)checkBox20).Enabled = true;
		}
	}

	private void textBox4_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Int32_1 = int.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_15 = true;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox14.Checked = false;
			}
			((Control)checkBox14).Enabled = true;
		}
	}

	private void textBox5_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Int32_2 = int.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_16 = true;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox15.Checked = false;
			}
			((Control)checkBox15).Enabled = true;
		}
	}

	private void textBox6_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Int32_3 = int.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_17 = true;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox16.Checked = false;
			}
			((Control)checkBox16).Enabled = true;
		}
	}

	private void textBox7_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			try
			{
				gclass6_0.Int32_4 = int.Parse(((Control)(TextBox)sender).Text);
				gclass6_0.Boolean_18 = true;
				((Control)(TextBox)sender).Visible = false;
			}
			catch (Exception)
			{
				checkBox17.Checked = false;
			}
			((Control)checkBox17).Enabled = true;
		}
	}

	private void textBox11_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			button3_Click(sender, (EventArgs)(object)e);
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		method_6();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		string text = ((Control)textBox11).Text.Trim();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		if (gclass6_0 != null)
		{
			if (gclass6_0.List_1 == null)
			{
				gclass6_0.List_1 = new List<Label>();
			}
			if (gclass6_0.List_2 == null)
			{
				gclass6_0.List_2 = new List<string>();
			}
			bool flag = false;
			foreach (Label item in gclass6_0.List_1)
			{
				if (item != null && ((Control)item).Text != null && text.Equals(((Control)item).Text.Trim(), StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				Label val = new Label();
				((Control)val).AutoSize = true;
				((Control)val).BackColor = Color.Transparent;
				((Control)val).Cursor = Cursors.Hand;
				int num = new Random().Next();
				((Control)val).Name = "labelMob" + gclass6_0.List_1.Count + num;
				((Control)val).Text = text;
				((Control)val).Click += method_16;
				((Control)val).Location = new Point(int_1, int_3);
				int_3 += int_4;
				gclass6_0.List_1.Add(val);
				bool flag2 = false;
				foreach (string item2 in gclass6_0.List_2)
				{
					if (item2 != null && item2.Equals(text, StringComparison.OrdinalIgnoreCase))
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					gclass6_0.List_2.Add(text);
				}
				if (groupBox4 != null)
				{
					((Control)groupBox4).Controls.Add((Control)(object)val);
				}
			}
		}
		else
		{
			MessageBox.Show("Silakan klik tombol LOAD terlebih dahulu agar proses/memori game terhubung!", "Peringatan", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		((Control)textBox11).Text = "";
	}

	private void button6_Click(object sender, EventArgs e)
	{
		gclass6_0.method_37(gclass4_0);
	}

	private void button7_Click(object sender, EventArgs e)
	{
		gclass6_0.method_38(gclass4_0);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private IntPtr method_17()
	{
		return ((Control)this).Handle;
	}

	private void chkDelayButton_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_13((CheckBox)sender);
		if (chkDelayButton.Checked)
		{
			((Control)tbxButtonDelay).Visible = true;
			((Control)tbxButtonDelay).Focus();
		}
	}

	private void tbxButtonDelay_TextChanged(object sender, EventArgs e)
	{
		string text = ((Control)tbxButtonDelay).Text;
		int result = 0;
		if (!int.TryParse(text, out result) && !string.IsNullOrEmpty(text))
		{
			((Control)tbxButtonDelay).Text = text.Remove(text.Length - 1);
		}
	}

	private void tbxButtonDelay_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.KeyCode == 13)
		{
			((Control)(TextBox)sender).Visible = false;
		}
	}

	private string Reverse4DHex(int hex)
	{
		string text = hex.ToString("X4");
		int i = 0;
		List<string> list = new List<string>();
		for (; i < text.Length; i += 2)
		{
			list.Add(text.Substring(i, 2));
		}
		return string.Join("", Enumerable.Reverse(list));
	}

	private void tbxButtonDelay_Leave(object sender, EventArgs e)
	{
		string text = ((Control)tbxButtonDelay).Text;
		int result = 0;
		if (int.TryParse(text, out result))
		{
			if (result < 0)
			{
				((Control)tbxButtonDelay).Text = "500";
				result = 500;
			}
			if (chkDelayButton.Checked)
			{
				string delayHex = Reverse4DHex(result);
				gclass6_0.LoadButtonDelay(delayHex);
			}
		}
		else
		{
			((Control)tbxButtonDelay).Text = ((Control)tbxButtonDelay).Text.Remove(((Control)tbxButtonDelay).Text.Length - 1);
		}
		((Control)chkDelayButton).Text = $"Button Delay [{result}]";
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 786)
		{
			int num = m.WParam.ToInt32();
			if (num == uniqueAutoTabTargetPartyAndGuildHotKeyId && checkBox29.Checked)
			{
				if (checkBox27.Checked)
				{
					PlayOff();
					checkBox27.Checked = false;
					checkBox28.Checked = false;
				}
				else
				{
					PlayOn();
					checkBox27.Checked = true;
					checkBox28.Checked = true;
				}
			}
			if (num == uniqueAutoTabMonsterHotKeyId && checkBox45.Checked)
			{
				gclass6_0.TabMonster();
			}
		}
		else if (m.Msg == 132)
		{
			((Form)this).WndProc(ref m);
			if ((int)m.Result == 1)
			{
				m.Result = (IntPtr)2;
			}
			return;
		}
		((Form)this).WndProc(ref m);
	}

	private void checkBox45_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.IsAutoTabMonster = true;
			checkBox29.Checked = false;
		}
		else
		{
			gclass6_0.IsAutoTabMonster = false;
		}
		gclass6_0.LoadAutoTabMonster();
	}

	private void checkBox43_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		method_13((CheckBox)sender);
		gclass6_0.LoadExtendView(checkBox43.Checked);
	}

	private void PlayOn()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		SoundPlayer val = new SoundPlayer((Stream)Resources.on);
		val.Play();
	}

	private void PlayOff()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		SoundPlayer val = new SoundPlayer((Stream)Resources.off);
		val.Play();
	}

	private void checkBox46_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		method_13((CheckBox)sender);
		if (((CheckBox)sender).Checked)
		{
			gclass6_0.Boolean_44 = true;
		}
		else
		{
			gclass6_0.Boolean_44 = false;
		}
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
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected Obj, but got Unknown
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdc: Expected Obj, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Expected Obj, but got Unknown
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bd: Expected Obj, but got Unknown
		//IL_214a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2154: Expected Obj, but got Unknown
		//IL_21ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f4: Expected Obj, but got Unknown
		//IL_2bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf4: Expected Obj, but got Unknown
		//IL_2c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c88: Expected Obj, but got Unknown
		//IL_2d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1c: Expected Obj, but got Unknown
		//IL_2da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db0: Expected Obj, but got Unknown
		//IL_440e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4418: Expected Obj, but got Unknown
		//IL_490b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4915: Expected Obj, but got Unknown
		//IL_4cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cdb: Expected Obj, but got Unknown
		//IL_4d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d24: Expected Obj, but got Unknown
		//IL_4df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e01: Expected Obj, but got Unknown
		//IL_4e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e3a: Expected Obj, but got Unknown
		//IL_50ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_50b5: Expected Obj, but got Unknown
		//IL_552a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5628: Unknown result type (might be due to invalid IL or missing references)
		//IL_5632: Expected Obj, but got Unknown
		//IL_5750: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_608f: Unknown result type (might be due to invalid IL or missing references)
		//IL_647d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6487: Expected Obj, but got Unknown
		//IL_64a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_64ab: Expected Obj, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(App));
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		panel1 = new Panel();
		checkBox45 = new CheckBox();
		checkBox43 = new CheckBox();
		tbxButtonDelay = new TextBox();
		chkDelayButton = new CheckBox();
		checkBox42 = new CheckBox();
		button7 = new Button();
		button6 = new Button();
		checkBox44 = new CheckBox();
		checkBox41 = new CheckBox();
		checkBox40 = new CheckBox();
		checkBox37 = new CheckBox();
		checkBox36 = new CheckBox();
		checkBox35 = new CheckBox();
		checkBox34 = new CheckBox();
		label14 = new Label();
		label13 = new Label();
		checkBox33 = new CheckBox();
		checkBox32 = new CheckBox();
		textBox9 = new TextBox();
		textBox8 = new TextBox();
		lblLockTarget = new Label();
		label6 = new Label();
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		tbxASPD = new TextBox();
		checkBox30 = new CheckBox();
		checkBox29 = new CheckBox();
		checkBox28 = new CheckBox();
		checkBox27 = new CheckBox();
		groupBox2 = new GroupBox();
		radioButton3 = new RadioButton();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		groupBox1 = new GroupBox();
		textBox7 = new TextBox();
		textBox6 = new TextBox();
		textBox5 = new TextBox();
		textBox4 = new TextBox();
		checkBox17 = new CheckBox();
		checkBox16 = new CheckBox();
		checkBox15 = new CheckBox();
		checkBox14 = new CheckBox();
		checkBox21 = new CheckBox();
		checkBox13 = new CheckBox();
		checkBox20 = new CheckBox();
		checkBox12 = new CheckBox();
		checkBox11 = new CheckBox();
		checkBox18 = new CheckBox();
		checkBox10 = new CheckBox();
		checkBox9 = new CheckBox();
		checkBox8 = new CheckBox();
		checkBox7 = new CheckBox();
		checkBox6 = new CheckBox();
		checkBox5 = new CheckBox();
		checkBox4 = new CheckBox();
		checkBox1 = new CheckBox();
		checkBox2 = new CheckBox();
		checkBox3 = new CheckBox();
		panel2 = new Panel();
		checkBox31 = new CheckBox();
		checkBox22 = new CheckBox();
		checkBox23 = new CheckBox();
		checkBox19 = new CheckBox();
		panel3 = new Panel();
		checkBox26 = new CheckBox();
		checkBox25 = new CheckBox();
		checkBox24 = new CheckBox();
		timer_0 = new Timer(components);
		panel4 = new Panel();
		label4 = new Label();
		panel5 = new Panel();
		label5 = new Label();
		panel6 = new Panel();
		checkBox39 = new CheckBox();
		label15 = new Label();
		checkBox38 = new CheckBox();
		label12 = new Label();
		label11 = new Label();
		textBox12 = new TextBox();
		label10 = new Label();
		button3 = new Button();
		textBox11 = new TextBox();
		label9 = new Label();
		groupBox4 = new GroupBox();
		button2 = new Button();
		textBox10 = new TextBox();
		label8 = new Label();
		groupBox3 = new GroupBox();
		button4 = new Button();
		timer_1 = new Timer(components);
		button5 = new Button();
		pictureBox9 = new PictureBox();
		pictureBox10 = new PictureBox();
		pictureBox8 = new PictureBox();
		pictureBox7 = new PictureBox();
		pictureBox6 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		lblVersion = new Label();
		checkBox46 = new CheckBox();
		((Control)panel1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)panel6).SuspendLayout();
		((ISupportInitialize)pictureBox9).BeginInit();
		((ISupportInitialize)pictureBox10).BeginInit();
		((ISupportInitialize)pictureBox8).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button1).BackColor = Color.Transparent;
		((Control)button1).BackgroundImage = (Image)(object)Resources.close_btn_grey;
		((Control)button1).BackgroundImageLayout = (ImageLayout)3;
		((Control)button1).Cursor = Cursors.Hand;
		((ButtonBase)button1).FlatAppearance.BorderSize = 0;
		((ButtonBase)button1).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)button1).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Location = new Point(768, 12);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(20, 20);
		((Control)button1).TabIndex = 100;
		((ButtonBase)button1).UseVisualStyleBackColor = false;
		((Control)button1).Click += button1_Click;
		((Control)button1).MouseEnter += button1_MouseEnter;
		((Control)button1).MouseLeave += button1_MouseLeave;
		((Control)label1).AutoSize = true;
		((Control)label1).BackColor = Color.Transparent;
		((Control)label1).Cursor = Cursors.Default;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).Location = new Point(97, 387);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(74, 16);
		((Control)label1).TabIndex = 102;
		((Control)label1).Text = "nickname";
		((Control)label2).AutoSize = true;
		((Control)label2).BackColor = Color.Transparent;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label2).Location = new Point(97, 408);
		((Control)label2).Name = "label2";
		((Control)label2).Size = new Size(31, 13);
		((Control)label2).TabIndex = 103;
		((Control)label2).Text = "VVIP";
		((Control)label3).AutoSize = true;
		((Control)label3).BackColor = Color.Transparent;
		((Control)label3).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)label3).Location = new Point(97, 428);
		((Control)label3).Name = "label3";
		((Control)label3).Size = new Size(92, 13);
		((Control)label3).TabIndex = 104;
		((Control)label3).Text = "28 days remaining";
		((Control)panel1).BackColor = Color.Transparent;
		((Control)panel1).Controls.Add((Control)(object)checkBox45);
		((Control)panel1).Controls.Add((Control)(object)checkBox43);
		((Control)panel1).Controls.Add((Control)(object)tbxButtonDelay);
		((Control)panel1).Controls.Add((Control)(object)chkDelayButton);
		((Control)panel1).Controls.Add((Control)(object)checkBox42);
		((Control)panel1).Controls.Add((Control)(object)button7);
		((Control)panel1).Controls.Add((Control)(object)button6);
		((Control)panel1).Controls.Add((Control)(object)checkBox44);
		((Control)panel1).Controls.Add((Control)(object)checkBox41);
		((Control)panel1).Controls.Add((Control)(object)checkBox40);
		((Control)panel1).Controls.Add((Control)(object)checkBox37);
		((Control)panel1).Controls.Add((Control)(object)checkBox36);
		((Control)panel1).Controls.Add((Control)(object)checkBox35);
		((Control)panel1).Controls.Add((Control)(object)checkBox34);
		((Control)panel1).Controls.Add((Control)(object)label14);
		((Control)panel1).Controls.Add((Control)(object)label13);
		((Control)panel1).Controls.Add((Control)(object)checkBox33);
		((Control)panel1).Controls.Add((Control)(object)checkBox32);
		((Control)panel1).Controls.Add((Control)(object)textBox9);
		((Control)panel1).Controls.Add((Control)(object)textBox8);
		((Control)panel1).Controls.Add((Control)(object)lblLockTarget);
		((Control)panel1).Controls.Add((Control)(object)label6);
		((Control)panel1).Controls.Add((Control)(object)textBox3);
		((Control)panel1).Controls.Add((Control)(object)textBox2);
		((Control)panel1).Controls.Add((Control)(object)tbxASPD);
		((Control)panel1).Controls.Add((Control)(object)checkBox30);
		((Control)panel1).Controls.Add((Control)(object)checkBox29);
		((Control)panel1).Controls.Add((Control)(object)checkBox28);
		((Control)panel1).Controls.Add((Control)(object)checkBox27);
		((Control)panel1).Controls.Add((Control)(object)groupBox2);
		((Control)panel1).Controls.Add((Control)(object)groupBox1);
		((Control)panel1).Controls.Add((Control)(object)checkBox21);
		((Control)panel1).Controls.Add((Control)(object)checkBox13);
		((Control)panel1).Controls.Add((Control)(object)checkBox20);
		((Control)panel1).Controls.Add((Control)(object)checkBox12);
		((Control)panel1).Controls.Add((Control)(object)checkBox11);
		((Control)panel1).Controls.Add((Control)(object)checkBox18);
		((Control)panel1).Controls.Add((Control)(object)checkBox10);
		((Control)panel1).Controls.Add((Control)(object)checkBox9);
		((Control)panel1).Controls.Add((Control)(object)checkBox8);
		((Control)panel1).Controls.Add((Control)(object)checkBox7);
		((Control)panel1).Controls.Add((Control)(object)checkBox6);
		((Control)panel1).Controls.Add((Control)(object)checkBox5);
		((Control)panel1).Controls.Add((Control)(object)checkBox4);
		((Control)panel1).Controls.Add((Control)(object)checkBox1);
		((Control)panel1).Controls.Add((Control)(object)checkBox2);
		((Control)panel1).Location = new Point(16, 52);
		((Control)panel1).Name = "panel1";
		((Control)panel1).Size = new Size(700, 290);
		((Control)panel1).TabIndex = 108;
		((Control)panel1).MouseDown += App_MouseDown;
		checkBox45.Appearance = (Appearance)1;
		((Control)checkBox45).AutoSize = true;
		((Control)checkBox45).BackColor = Color.Transparent;
		((Control)checkBox45).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox45).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox45).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox45).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox45).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox45).FlatStyle = (FlatStyle)0;
		((Control)checkBox45).Location = new Point(470, 209);
		((Control)checkBox45).Name = "checkBox45";
		((Control)checkBox45).Size = new Size(102, 23);
		((Control)checkBox45).TabIndex = 128;
		((Control)checkBox45).Text = "Auto Tab Monster";
		((ButtonBase)checkBox45).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox45).UseVisualStyleBackColor = false;
		checkBox45.CheckedChanged += checkBox45_CheckedChanged;
		checkBox43.Appearance = (Appearance)1;
		((Control)checkBox43).AutoSize = true;
		((Control)checkBox43).BackColor = Color.Transparent;
		((Control)checkBox43).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox43).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox43).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox43).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox43).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox43).FlatStyle = (FlatStyle)0;
		((Control)checkBox43).Location = new Point(578, 151);
		((Control)checkBox43).Name = "checkBox43";
		((Control)checkBox43).Size = new Size(76, 23);
		((Control)checkBox43).TabIndex = 127;
		((Control)checkBox43).Text = "Extend View";
		((ButtonBase)checkBox43).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox43).UseVisualStyleBackColor = false;
		checkBox43.CheckedChanged += checkBox43_CheckedChanged;
		((Control)tbxButtonDelay).BackColor = Color.Black;
		((Control)tbxButtonDelay).ForeColor = Color.White;
		((Control)tbxButtonDelay).Location = new Point(635, 181);
		((TextBoxBase)tbxButtonDelay).MaxLength = 3;
		((Control)tbxButtonDelay).Name = "tbxButtonDelay";
		((Control)tbxButtonDelay).Size = new Size(48, 20);
		((Control)tbxButtonDelay).TabIndex = 126;
		((Control)tbxButtonDelay).Text = "500";
		tbxButtonDelay.TextAlign = (HorizontalAlignment)2;
		((Control)tbxButtonDelay).TextChanged += tbxButtonDelay_TextChanged;
		((Control)tbxButtonDelay).KeyDown += tbxButtonDelay_KeyDown;
		((Control)tbxButtonDelay).Leave += tbxButtonDelay_Leave;
		chkDelayButton.Appearance = (Appearance)1;
		((Control)chkDelayButton).AutoSize = true;
		((Control)chkDelayButton).BackColor = Color.Transparent;
		((Control)chkDelayButton).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)chkDelayButton).FlatAppearance.BorderSize = 0;
		((ButtonBase)chkDelayButton).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)chkDelayButton).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)chkDelayButton).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)chkDelayButton).FlatStyle = (FlatStyle)0;
		((Control)chkDelayButton).Location = new Point(578, 180);
		((Control)chkDelayButton).Name = "chkDelayButton";
		((Control)chkDelayButton).Size = new Size(105, 23);
		((Control)chkDelayButton).TabIndex = 124;
		((Control)chkDelayButton).Text = "Button Delay [500]";
		((ButtonBase)chkDelayButton).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)chkDelayButton).UseVisualStyleBackColor = false;
		chkDelayButton.CheckedChanged += chkDelayButton_CheckedChanged;
		checkBox42.Appearance = (Appearance)1;
		((Control)checkBox42).AutoSize = true;
		((Control)checkBox42).BackColor = Color.Transparent;
		((Control)checkBox42).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox42).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox42).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox42).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox42).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox42).FlatStyle = (FlatStyle)0;
		((Control)checkBox42).Location = new Point(470, 180);
		((Control)checkBox42).Name = "checkBox42";
		((Control)checkBox42).Size = new Size(78, 23);
		((Control)checkBox42).TabIndex = 123;
		((Control)checkBox42).Text = "Peace Mode";
		((ButtonBase)checkBox42).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox42).UseVisualStyleBackColor = false;
		checkBox42.CheckedChanged += checkBox42_CheckedChanged;
		((Control)button7).BackColor = Color.Transparent;
		((Control)button7).Cursor = Cursors.Hand;
		((ButtonBase)button7).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button7).FlatStyle = (FlatStyle)0;
		((Control)button7).Location = new Point(469, 252);
		((Control)button7).Name = "button7";
		((Control)button7).Size = new Size(75, 23);
		((Control)button7).TabIndex = 122;
		((Control)button7).Text = "LOAD";
		((ButtonBase)button7).UseVisualStyleBackColor = false;
		((Control)button7).Click += button7_Click;
		((Control)button6).BackColor = Color.Transparent;
		((Control)button6).Cursor = Cursors.Hand;
		((ButtonBase)button6).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button6).FlatStyle = (FlatStyle)0;
		((Control)button6).Location = new Point(563, 252);
		((Control)button6).Name = "button6";
		((Control)button6).Size = new Size(75, 23);
		((Control)button6).TabIndex = 121;
		((Control)button6).Text = "SAVE";
		((ButtonBase)button6).UseVisualStyleBackColor = false;
		((Control)button6).Click += button6_Click;
		checkBox44.Appearance = (Appearance)1;
		((Control)checkBox44).AutoSize = true;
		((Control)checkBox44).BackColor = Color.Transparent;
		((Control)checkBox44).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox44).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox44).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox44).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox44).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox44).FlatStyle = (FlatStyle)0;
		((Control)checkBox44).Location = new Point(470, 122);
		((Control)checkBox44).Name = "checkBox44";
		((Control)checkBox44).Size = new Size(99, 23);
		((Control)checkBox44).TabIndex = 45;
		((Control)checkBox44).Text = "Revive [ Normal ]";
		((ButtonBase)checkBox44).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox44).UseVisualStyleBackColor = false;
		checkBox44.CheckedChanged += checkBox44_CheckedChanged;
		checkBox41.Appearance = (Appearance)1;
		((Control)checkBox41).AutoSize = true;
		((Control)checkBox41).BackColor = Color.Transparent;
		((Control)checkBox41).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox41).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox41).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox41).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox41).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox41).FlatStyle = (FlatStyle)0;
		((Control)checkBox41).Location = new Point(470, 151);
		((Control)checkBox41).Name = "checkBox41";
		((Control)checkBox41).Size = new Size(80, 23);
		((Control)checkBox41).TabIndex = 42;
		((Control)checkBox41).Text = "Anti Badword";
		((ButtonBase)checkBox41).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox41).UseVisualStyleBackColor = false;
		checkBox41.CheckedChanged += checkBox41_CheckedChanged;
		checkBox40.Appearance = (Appearance)1;
		((Control)checkBox40).AutoSize = true;
		((Control)checkBox40).BackColor = Color.Transparent;
		((Control)checkBox40).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox40).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox40).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox40).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox40).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox40).FlatStyle = (FlatStyle)0;
		((Control)checkBox40).Location = new Point(293, 151);
		((Control)checkBox40).Name = "checkBox40";
		((Control)checkBox40).Size = new Size(114, 23);
		((Control)checkBox40).TabIndex = 41;
		((Control)checkBox40).Text = "Expert Skill Spec [R]";
		((ButtonBase)checkBox40).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox40).UseVisualStyleBackColor = false;
		checkBox40.CheckedChanged += checkBox40_CheckedChanged;
		checkBox37.Appearance = (Appearance)1;
		((Control)checkBox37).AutoSize = true;
		((Control)checkBox37).BackColor = Color.Transparent;
		((Control)checkBox37).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox37).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox37).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox37).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox37).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox37).FlatStyle = (FlatStyle)0;
		((Control)checkBox37).Location = new Point(470, 6);
		((Control)checkBox37).Name = "checkBox37";
		((Control)checkBox37).Size = new Size(107, 23);
		((Control)checkBox37).TabIndex = 40;
		((Control)checkBox37).Text = "Range All Weapon";
		((ButtonBase)checkBox37).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox37).UseVisualStyleBackColor = false;
		checkBox37.CheckedChanged += checkBox37_CheckedChanged;
		checkBox36.Appearance = (Appearance)1;
		((Control)checkBox36).AutoSize = true;
		((Control)checkBox36).BackColor = Color.Transparent;
		((Control)checkBox36).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox36).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox36).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox36).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox36).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox36).FlatStyle = (FlatStyle)0;
		((Control)checkBox36).Location = new Point(293, 122);
		((Control)checkBox36).Name = "checkBox36";
		((Control)checkBox36).Size = new Size(133, 23);
		((Control)checkBox36).TabIndex = 39;
		((Control)checkBox36).Text = "Disable Booster Window";
		((ButtonBase)checkBox36).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox36).UseVisualStyleBackColor = false;
		checkBox36.CheckedChanged += checkBox36_CheckedChanged;
		checkBox35.Appearance = (Appearance)1;
		((Control)checkBox35).AutoSize = true;
		((Control)checkBox35).BackColor = Color.Transparent;
		((Control)checkBox35).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox35).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox35).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox35).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox35).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox35).FlatStyle = (FlatStyle)0;
		((Control)checkBox35).Location = new Point(293, 93);
		((Control)checkBox35).Name = "checkBox35";
		((Control)checkBox35).Size = new Size(72, 23);
		((Control)checkBox35).TabIndex = 38;
		((Control)checkBox35).Text = "Race Hack";
		((ButtonBase)checkBox35).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox35).UseVisualStyleBackColor = false;
		checkBox35.CheckedChanged += checkBox35_CheckedChanged;
		checkBox34.Appearance = (Appearance)1;
		((Control)checkBox34).AutoSize = true;
		((Control)checkBox34).BackColor = Color.Transparent;
		((Control)checkBox34).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox34).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox34).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox34).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox34).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox34).FlatStyle = (FlatStyle)0;
		((Control)checkBox34).Location = new Point(306, 209);
		((Control)checkBox34).Name = "checkBox34";
		((Control)checkBox34).Size = new Size(101, 23);
		((Control)checkBox34).TabIndex = 37;
		((Control)checkBox34).Text = "TAB Target Race";
		((ButtonBase)checkBox34).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox34).UseVisualStyleBackColor = false;
		((Control)checkBox34).Visible = false;
		checkBox34.CheckedChanged += checkBox34_CheckedChanged;
		((Control)label14).AutoSize = true;
		((Control)label14).Location = new Point(157, 270);
		((Control)label14).Name = "label14";
		((Control)label14).Size = new Size(105, 13);
		((Control)label14).TabIndex = 36;
		((Control)label14).Text = "Tab Status: Running";
		((Control)label13).AutoSize = true;
		((Control)label13).Location = new Point(27, 270);
		((Control)label13).Name = "label13";
		((Control)label13).Size = new Size(116, 13);
		((Control)label13).TabIndex = 35;
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
		((Control)checkBox33).Location = new Point(24, 237);
		((Control)checkBox33).Name = "checkBox33";
		((Control)checkBox33).Size = new Size(97, 23);
		((Control)checkBox33).TabIndex = 34;
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
		((Control)checkBox32).Location = new Point(24, 208);
		((Control)checkBox32).Name = "checkBox32";
		((Control)checkBox32).Size = new Size(114, 23);
		((Control)checkBox32).TabIndex = 33;
		((Control)checkBox32).Text = "TAB Target Accretia";
		((ButtonBase)checkBox32).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox32).UseVisualStyleBackColor = false;
		checkBox32.CheckedChanged += checkBox32_CheckedChanged;
		((Control)textBox9).BackColor = Color.Black;
		((Control)textBox9).ForeColor = Color.White;
		((Control)textBox9).Location = new Point(324, 181);
		((Control)textBox9).Name = "textBox9";
		((Control)textBox9).Size = new Size(102, 20);
		((Control)textBox9).TabIndex = 32;
		textBox9.TextAlign = (HorizontalAlignment)2;
		((TextBoxBase)textBox9).WordWrap = false;
		((Control)textBox8).BackColor = Color.Black;
		((Control)textBox8).ForeColor = Color.White;
		((Control)textBox8).Location = new Point(195, 181);
		((Control)textBox8).Name = "textBox8";
		((Control)textBox8).Size = new Size(36, 20);
		((Control)textBox8).TabIndex = 31;
		((Control)textBox8).Text = "200";
		textBox8.TextAlign = (HorizontalAlignment)2;
		((Control)lblLockTarget).AutoSize = true;
		((Control)lblLockTarget).Location = new Point(250, 185);
		((Control)lblLockTarget).Name = "lblLockTarget";
		((Control)lblLockTarget).Size = new Size(68, 13);
		((Control)lblLockTarget).TabIndex = 30;
		((Control)lblLockTarget).Text = "Lock Target:";
		((Control)label6).AutoSize = true;
		((Control)label6).Location = new Point(141, 185);
		((Control)label6).Name = "label6";
		((Control)label6).Size = new Size(52, 13);
		((Control)label6).TabIndex = 29;
		((Control)label6).Text = "Distance:";
		((Control)textBox3).BackColor = Color.Black;
		((Control)textBox3).ForeColor = Color.White;
		((Control)textBox3).Location = new Point(364, 37);
		((Control)textBox3).Name = "textBox3";
		((Control)textBox3).Size = new Size(50, 20);
		((Control)textBox3).TabIndex = 28;
		textBox3.TextAlign = (HorizontalAlignment)2;
		((Control)textBox3).Visible = false;
		((Control)textBox3).KeyDown += textBox3_KeyDown;
		((Control)textBox2).BackColor = Color.Black;
		((Control)textBox2).ForeColor = Color.White;
		((Control)textBox2).Location = new Point(240, 37);
		((Control)textBox2).Name = "textBox2";
		((Control)textBox2).Size = new Size(50, 20);
		((Control)textBox2).TabIndex = 27;
		textBox2.TextAlign = (HorizontalAlignment)2;
		((Control)textBox2).Visible = false;
		((Control)textBox2).KeyDown += textBox2_KeyDown;
		((Control)tbxASPD).BackColor = Color.Black;
		((Control)tbxASPD).ForeColor = Color.White;
		((Control)tbxASPD).Location = new Point(72, 36);
		((TextBoxBase)tbxASPD).MaxLength = 5;
		((Control)tbxASPD).Name = "tbxASPD";
		((Control)tbxASPD).Size = new Size(50, 20);
		((Control)tbxASPD).TabIndex = 26;
		tbxASPD.TextAlign = (HorizontalAlignment)2;
		((Control)tbxASPD).Visible = false;
		((Control)tbxASPD).KeyDown += tbxASPD_KeyDown;
		checkBox30.Appearance = (Appearance)1;
		((Control)checkBox30).AutoSize = true;
		((Control)checkBox30).BackColor = Color.Transparent;
		((Control)checkBox30).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox30).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox30).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox30).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox30).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox30).FlatStyle = (FlatStyle)0;
		((Control)checkBox30).Location = new Point(306, 237);
		((Control)checkBox30).Name = "checkBox30";
		((Control)checkBox30).Size = new Size(90, 23);
		((Control)checkBox30).TabIndex = 25;
		((Control)checkBox30).Text = "Auto Target CB";
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
		((Control)checkBox29).Location = new Point(24, 180);
		((Control)checkBox29).Name = "checkBox29";
		((Control)checkBox29).Size = new Size(105, 23);
		((Control)checkBox29).TabIndex = 24;
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
		((Control)checkBox28).Location = new Point(160, 237);
		((Control)checkBox28).Name = "checkBox28";
		((Control)checkBox28).Size = new Size(134, 23);
		((Control)checkBox28).TabIndex = 23;
		((Control)checkBox28).Text = "TAB Target Guild [Alt+Q]";
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
		((Control)checkBox27).Location = new Point(160, 208);
		((Control)checkBox27).Name = "checkBox27";
		((Control)checkBox27).Size = new Size(134, 23);
		((Control)checkBox27).TabIndex = 22;
		((Control)checkBox27).Text = "TAB Target Party [Alt+Q]";
		((ButtonBase)checkBox27).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox27).UseVisualStyleBackColor = false;
		checkBox27.CheckedChanged += checkBox27_CheckedChanged;
		((Control)groupBox2).Controls.Add((Control)(object)radioButton3);
		((Control)groupBox2).Controls.Add((Control)(object)radioButton2);
		((Control)groupBox2).Controls.Add((Control)(object)radioButton1);
		((Control)groupBox2).Enabled = false;
		((Control)groupBox2).ForeColor = Color.White;
		((Control)groupBox2).Location = new Point(673, 77);
		((Control)groupBox2).Name = "groupBox2";
		((Control)groupBox2).Size = new Size(164, 43);
		((Control)groupBox2).TabIndex = 14;
		groupBox2.TabStop = false;
		((Control)groupBox2).Text = "Race";
		((Control)groupBox2).Visible = false;
		radioButton3.Appearance = (Appearance)1;
		((Control)radioButton3).AutoSize = true;
		((ButtonBase)radioButton3).FlatAppearance.BorderSize = 0;
		((ButtonBase)radioButton3).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)radioButton3).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)radioButton3).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)radioButton3).FlatStyle = (FlatStyle)0;
		((Control)radioButton3).Location = new Point(124, 14);
		((Control)radioButton3).Name = "radioButton3";
		((Control)radioButton3).Size = new Size(24, 23);
		((Control)radioButton3).TabIndex = 2;
		radioButton3.TabStop = true;
		((Control)radioButton3).Text = "C";
		((ButtonBase)radioButton3).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)radioButton3).UseVisualStyleBackColor = true;
		radioButton3.CheckedChanged += radioButton3_CheckedChanged;
		radioButton2.Appearance = (Appearance)1;
		((Control)radioButton2).AutoSize = true;
		((ButtonBase)radioButton2).FlatAppearance.BorderSize = 0;
		((ButtonBase)radioButton2).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)radioButton2).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)radioButton2).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)radioButton2).FlatStyle = (FlatStyle)0;
		((Control)radioButton2).Location = new Point(72, 14);
		((Control)radioButton2).Name = "radioButton2";
		((Control)radioButton2).Size = new Size(24, 23);
		((Control)radioButton2).TabIndex = 1;
		radioButton2.TabStop = true;
		((Control)radioButton2).Text = "B";
		((ButtonBase)radioButton2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)radioButton2).UseVisualStyleBackColor = true;
		radioButton2.CheckedChanged += radioButton2_CheckedChanged;
		radioButton1.Appearance = (Appearance)1;
		((Control)radioButton1).AutoSize = true;
		((ButtonBase)radioButton1).FlatAppearance.BorderSize = 0;
		((ButtonBase)radioButton1).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)radioButton1).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)radioButton1).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)radioButton1).FlatStyle = (FlatStyle)0;
		((Control)radioButton1).Location = new Point(16, 14);
		((Control)radioButton1).Name = "radioButton1";
		((Control)radioButton1).Size = new Size(24, 23);
		((Control)radioButton1).TabIndex = 0;
		radioButton1.TabStop = true;
		((Control)radioButton1).Text = "A";
		((ButtonBase)radioButton1).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)radioButton1).UseVisualStyleBackColor = true;
		radioButton1.CheckedChanged += radioButton1_CheckedChanged;
		((Control)groupBox1).Controls.Add((Control)(object)textBox7);
		((Control)groupBox1).Controls.Add((Control)(object)textBox6);
		((Control)groupBox1).Controls.Add((Control)(object)textBox5);
		((Control)groupBox1).Controls.Add((Control)(object)textBox4);
		((Control)groupBox1).Controls.Add((Control)(object)checkBox17);
		((Control)groupBox1).Controls.Add((Control)(object)checkBox16);
		((Control)groupBox1).Controls.Add((Control)(object)checkBox15);
		((Control)groupBox1).Controls.Add((Control)(object)checkBox14);
		((Control)groupBox1).ForeColor = Color.White;
		((Control)groupBox1).Location = new Point(469, 31);
		((Control)groupBox1).Name = "groupBox1";
		((Control)groupBox1).Size = new Size(169, 80);
		((Control)groupBox1).TabIndex = 13;
		groupBox1.TabStop = false;
		((Control)groupBox1).Text = "Range";
		((Control)textBox7).BackColor = Color.Black;
		((Control)textBox7).ForeColor = Color.White;
		((Control)textBox7).Location = new Point(124, 49);
		((Control)textBox7).Name = "textBox7";
		((Control)textBox7).Size = new Size(35, 20);
		((Control)textBox7).TabIndex = 32;
		textBox7.TextAlign = (HorizontalAlignment)2;
		((Control)textBox7).Visible = false;
		((Control)textBox7).KeyDown += textBox7_KeyDown;
		((Control)textBox6).BackColor = Color.Black;
		((Control)textBox6).ForeColor = Color.White;
		((Control)textBox6).Location = new Point(48, 49);
		((Control)textBox6).Name = "textBox6";
		((Control)textBox6).Size = new Size(35, 20);
		((Control)textBox6).TabIndex = 31;
		textBox6.TextAlign = (HorizontalAlignment)2;
		((Control)textBox6).Visible = false;
		((Control)textBox6).KeyDown += textBox6_KeyDown;
		((Control)textBox5).BackColor = Color.Black;
		((Control)textBox5).ForeColor = Color.White;
		((Control)textBox5).Location = new Point(124, 15);
		((Control)textBox5).Name = "textBox5";
		((Control)textBox5).Size = new Size(35, 20);
		((Control)textBox5).TabIndex = 30;
		textBox5.TextAlign = (HorizontalAlignment)2;
		((Control)textBox5).Visible = false;
		((Control)textBox5).KeyDown += textBox5_KeyDown;
		((Control)textBox4).BackColor = Color.Black;
		((Control)textBox4).ForeColor = Color.White;
		((Control)textBox4).Location = new Point(49, 15);
		((Control)textBox4).Name = "textBox4";
		((Control)textBox4).Size = new Size(35, 20);
		((Control)textBox4).TabIndex = 29;
		textBox4.TextAlign = (HorizontalAlignment)2;
		((Control)textBox4).Visible = false;
		((Control)textBox4).KeyDown += textBox4_KeyDown;
		checkBox17.Appearance = (Appearance)1;
		((Control)checkBox17).AutoSize = true;
		((Control)checkBox17).BackColor = Color.Transparent;
		((Control)checkBox17).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox17).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox17).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox17).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox17).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox17).FlatStyle = (FlatStyle)0;
		((Control)checkBox17).Location = new Point(90, 48);
		((Control)checkBox17).Name = "checkBox17";
		((Control)checkBox17).Size = new Size(57, 23);
		((Control)checkBox17).TabIndex = 17;
		((Control)checkBox17).Text = "LC [255]";
		((ButtonBase)checkBox17).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox17).UseVisualStyleBackColor = false;
		checkBox17.CheckedChanged += checkBox17_CheckedChanged;
		checkBox16.Appearance = (Appearance)1;
		((Control)checkBox16).AutoSize = true;
		((Control)checkBox16).BackColor = Color.Transparent;
		((Control)checkBox16).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox16).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox16).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox16).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox16).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox16).FlatStyle = (FlatStyle)0;
		((Control)checkBox16).Location = new Point(11, 48);
		((Control)checkBox16).Name = "checkBox16";
		((Control)checkBox16).Size = new Size(58, 23);
		((Control)checkBox16).TabIndex = 16;
		((Control)checkBox16).Text = "FO [255]";
		((ButtonBase)checkBox16).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox16).UseVisualStyleBackColor = false;
		checkBox16.CheckedChanged += checkBox16_CheckedChanged;
		checkBox15.Appearance = (Appearance)1;
		((Control)checkBox15).AutoSize = true;
		((Control)checkBox15).BackColor = Color.Transparent;
		((Control)checkBox15).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox15).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox15).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox15).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox15).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox15).FlatStyle = (FlatStyle)0;
		((Control)checkBox15).Location = new Point(90, 14);
		((Control)checkBox15).Name = "checkBox15";
		((Control)checkBox15).Size = new Size(59, 23);
		((Control)checkBox15).TabIndex = 15;
		((Control)checkBox15).Text = "RA [255]";
		((ButtonBase)checkBox15).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox15).UseVisualStyleBackColor = false;
		checkBox15.CheckedChanged += checkBox15_CheckedChanged;
		checkBox14.Appearance = (Appearance)1;
		((Control)checkBox14).AutoSize = true;
		((Control)checkBox14).BackColor = Color.Transparent;
		((Control)checkBox14).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox14).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox14).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox14).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox14).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox14).FlatStyle = (FlatStyle)0;
		((Control)checkBox14).Location = new Point(11, 14);
		((Control)checkBox14).Name = "checkBox14";
		((Control)checkBox14).Size = new Size(63, 23);
		((Control)checkBox14).TabIndex = 14;
		((Control)checkBox14).Text = "WR [255]";
		((ButtonBase)checkBox14).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox14).UseVisualStyleBackColor = false;
		checkBox14.CheckedChanged += checkBox14_CheckedChanged;
		checkBox21.Appearance = (Appearance)1;
		((Control)checkBox21).AutoSize = true;
		((Control)checkBox21).BackColor = Color.Transparent;
		((Control)checkBox21).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox21).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox21).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox21).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox21).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox21).FlatStyle = (FlatStyle)0;
		((Control)checkBox21).Location = new Point(160, 151);
		((Control)checkBox21).Name = "checkBox21";
		((Control)checkBox21).Size = new Size(91, 23);
		((Control)checkBox21).TabIndex = 21;
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
		((Control)checkBox13).Location = new Point(23, 93);
		((Control)checkBox13).Name = "checkBox13";
		((Control)checkBox13).Size = new Size(98, 23);
		((Control)checkBox13).TabIndex = 12;
		((Control)checkBox13).Text = "Skill After Revive";
		((ButtonBase)checkBox13).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox13).UseVisualStyleBackColor = false;
		checkBox13.CheckedChanged += checkBox13_CheckedChanged;
		checkBox20.Appearance = (Appearance)1;
		((Control)checkBox20).AutoSize = true;
		((Control)checkBox20).BackColor = Color.Transparent;
		((Control)checkBox20).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox20).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox20).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox20).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox20).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox20).FlatStyle = (FlatStyle)0;
		((Control)checkBox20).Location = new Point(293, 35);
		((Control)checkBox20).Name = "checkBox20";
		((Control)checkBox20).Size = new Size(95, 23);
		((Control)checkBox20).TabIndex = 20;
		((Control)checkBox20).Text = "Loot Delay [500]";
		((ButtonBase)checkBox20).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox20).UseVisualStyleBackColor = false;
		checkBox20.CheckedChanged += checkBox20_CheckedChanged;
		checkBox12.Appearance = (Appearance)1;
		((Control)checkBox12).AutoSize = true;
		((Control)checkBox12).BackColor = Color.Transparent;
		((Control)checkBox12).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox12).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox12).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox12).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox12).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox12).FlatStyle = (FlatStyle)0;
		((Control)checkBox12).Location = new Point(24, 151);
		((Control)checkBox12).Name = "checkBox12";
		((Control)checkBox12).Size = new Size(108, 23);
		((Control)checkBox12).TabIndex = 11;
		((Control)checkBox12).Text = "All Skill All Weapon";
		((ButtonBase)checkBox12).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox12).UseVisualStyleBackColor = false;
		checkBox12.CheckedChanged += checkBox12_CheckedChanged;
		checkBox11.Appearance = (Appearance)1;
		((Control)checkBox11).AutoSize = true;
		((Control)checkBox11).BackColor = Color.Transparent;
		((Control)checkBox11).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox11).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox11).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox11).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox11).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox11).FlatStyle = (FlatStyle)0;
		((Control)checkBox11).Location = new Point(23, 122);
		((Control)checkBox11).Name = "checkBox11";
		((Control)checkBox11).Size = new Size(104, 23);
		((Control)checkBox11).TabIndex = 10;
		((Control)checkBox11).Text = "Fatal Stab No Buff";
		((ButtonBase)checkBox11).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox11).UseVisualStyleBackColor = false;
		checkBox11.CheckedChanged += checkBox11_CheckedChanged;
		checkBox18.Appearance = (Appearance)1;
		((Control)checkBox18).AutoSize = true;
		((Control)checkBox18).BackColor = Color.Transparent;
		((Control)checkBox18).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox18).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox18).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox18).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox18).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox18).FlatStyle = (FlatStyle)0;
		((Control)checkBox18).Location = new Point(293, 64);
		((Control)checkBox18).Name = "checkBox18";
		((Control)checkBox18).Size = new Size(63, 23);
		((Control)checkBox18).TabIndex = 18;
		((Control)checkBox18).Text = "Auto Loot";
		((ButtonBase)checkBox18).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox18).UseVisualStyleBackColor = false;
		checkBox18.CheckedChanged += checkBox18_CheckedChanged;
		checkBox10.Appearance = (Appearance)1;
		((Control)checkBox10).AutoSize = true;
		((Control)checkBox10).BackColor = Color.Transparent;
		((Control)checkBox10).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox10).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox10).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox10).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox10).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox10).FlatStyle = (FlatStyle)0;
		((Control)checkBox10).Location = new Point(293, 6);
		((Control)checkBox10).Name = "checkBox10";
		((Control)checkBox10).Size = new Size(69, 23);
		((Control)checkBox10).TabIndex = 9;
		((Control)checkBox10).Text = "Auto Purse";
		((ButtonBase)checkBox10).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox10).UseVisualStyleBackColor = false;
		checkBox10.CheckedChanged += checkBox10_CheckedChanged;
		checkBox9.Appearance = (Appearance)1;
		((Control)checkBox9).AutoSize = true;
		((Control)checkBox9).BackColor = Color.Transparent;
		((Control)checkBox9).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox9).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox9).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox9).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox9).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox9).FlatStyle = (FlatStyle)0;
		((Control)checkBox9).Location = new Point(160, 35);
		((Control)checkBox9).Name = "checkBox9";
		((Control)checkBox9).Size = new Size(107, 23);
		((Control)checkBox9).TabIndex = 8;
		((Control)checkBox9).Text = "Speed Hack [5.75]";
		((ButtonBase)checkBox9).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox9).UseVisualStyleBackColor = false;
		checkBox9.CheckedChanged += checkBox9_CheckedChanged;
		checkBox8.Appearance = (Appearance)1;
		((Control)checkBox8).AutoSize = true;
		((Control)checkBox8).BackColor = Color.Transparent;
		((Control)checkBox8).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox8).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox8).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox8).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox8).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox8).FlatStyle = (FlatStyle)0;
		((Control)checkBox8).Location = new Point(160, 122);
		((Control)checkBox8).Name = "checkBox8";
		((Control)checkBox8).Size = new Size(61, 23);
		((Control)checkBox8).TabIndex = 7;
		((Control)checkBox8).Text = "Self Blind";
		((ButtonBase)checkBox8).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox8).UseVisualStyleBackColor = false;
		checkBox8.CheckedChanged += checkBox8_CheckedChanged;
		checkBox7.Appearance = (Appearance)1;
		((Control)checkBox7).AutoSize = true;
		((Control)checkBox7).BackColor = Color.Transparent;
		((Control)checkBox7).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox7).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox7).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox7).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox7).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox7).FlatStyle = (FlatStyle)0;
		((Control)checkBox7).Location = new Point(160, 93);
		((Control)checkBox7).Name = "checkBox7";
		((Control)checkBox7).Size = new Size(61, 23);
		((Control)checkBox7).TabIndex = 6;
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
		((Control)checkBox6).Location = new Point(160, 64);
		((Control)checkBox6).Name = "checkBox6";
		((Control)checkBox6).Size = new Size(60, 23);
		((Control)checkBox6).TabIndex = 5;
		((Control)checkBox6).Text = "Anti Stun";
		((ButtonBase)checkBox6).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox6).UseVisualStyleBackColor = false;
		checkBox6.CheckedChanged += checkBox6_CheckedChanged;
		checkBox5.Appearance = (Appearance)1;
		((Control)checkBox5).AutoSize = true;
		((Control)checkBox5).BackColor = Color.Transparent;
		((Control)checkBox5).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox5).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox5).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox5).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox5).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox5).FlatStyle = (FlatStyle)0;
		((Control)checkBox5).Location = new Point(160, 6);
		((Control)checkBox5).Name = "checkBox5";
		((Control)checkBox5).Size = new Size(63, 23);
		((Control)checkBox5).TabIndex = 4;
		((Control)checkBox5).Text = "Detection";
		((ButtonBase)checkBox5).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox5).UseVisualStyleBackColor = false;
		checkBox5.CheckedChanged += checkBox5_CheckedChanged;
		checkBox4.Appearance = (Appearance)1;
		((Control)checkBox4).AutoSize = true;
		((Control)checkBox4).BackColor = Color.Transparent;
		((Control)checkBox4).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox4).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox4).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox4).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox4).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox4).FlatStyle = (FlatStyle)0;
		((Control)checkBox4).Location = new Point(23, 64);
		((Control)checkBox4).Name = "checkBox4";
		((Control)checkBox4).Size = new Size(90, 23);
		((Control)checkBox4).TabIndex = 3;
		((Control)checkBox4).Text = "ASPD Weapon";
		((ButtonBase)checkBox4).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox4).UseVisualStyleBackColor = false;
		checkBox4.CheckedChanged += checkBox4_CheckedChanged;
		checkBox1.Appearance = (Appearance)1;
		((Control)checkBox1).AutoSize = true;
		((Control)checkBox1).BackColor = Color.Transparent;
		((Control)checkBox1).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox1).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox1).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox1).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox1).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox1).FlatStyle = (FlatStyle)0;
		((Control)checkBox1).Location = new Point(23, 6);
		((Control)checkBox1).Name = "checkBox1";
		((Control)checkBox1).Size = new Size(65, 23);
		((Control)checkBox1).TabIndex = 0;
		((Control)checkBox1).Text = "Eagle Eye";
		((ButtonBase)checkBox1).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox1).UseVisualStyleBackColor = false;
		checkBox1.CheckedChanged += checkBox1_CheckedChanged;
		checkBox2.Appearance = (Appearance)1;
		((Control)checkBox2).AutoSize = true;
		((Control)checkBox2).BackColor = Color.Transparent;
		((Control)checkBox2).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox2).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox2).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox2).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox2).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox2).FlatStyle = (FlatStyle)0;
		((Control)checkBox2).ForeColor = Color.White;
		((Control)checkBox2).Location = new Point(23, 35);
		((Control)checkBox2).Name = "checkBox2";
		((Control)checkBox2).Size = new Size(76, 23);
		((Control)checkBox2).TabIndex = 1;
		((Control)checkBox2).Text = "ASPD [1.75]";
		((ButtonBase)checkBox2).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox2).UseVisualStyleBackColor = false;
		checkBox2.CheckedChanged += checkBox2_CheckedChanged;
		checkBox3.Appearance = (Appearance)1;
		((Control)checkBox3).AutoSize = true;
		((Control)checkBox3).BackColor = Color.Transparent;
		((Control)checkBox3).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox3).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox3).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox3).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox3).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox3).FlatStyle = (FlatStyle)0;
		((Control)checkBox3).Location = new Point(56, 45);
		((Control)checkBox3).Name = "checkBox3";
		((Control)checkBox3).Size = new Size(76, 23);
		((Control)checkBox3).TabIndex = 2;
		((Control)checkBox3).Text = "ASPD Brutal";
		((ButtonBase)checkBox3).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox3).UseVisualStyleBackColor = false;
		checkBox3.CheckedChanged += checkBox3_CheckedChanged;
		((Control)panel2).BackColor = Color.Transparent;
		((Control)panel2).Controls.Add((Control)(object)checkBox31);
		((Control)panel2).Controls.Add((Control)(object)checkBox22);
		((Control)panel2).Controls.Add((Control)(object)checkBox3);
		((Control)panel2).Location = new Point(7, 62);
		((Control)panel2).Name = "panel2";
		((Control)panel2).Size = new Size(580, 270);
		((Control)panel2).TabIndex = 109;
		((Control)panel2).MouseDown += App_MouseDown;
		checkBox31.Appearance = (Appearance)1;
		((Control)checkBox31).AutoSize = true;
		((Control)checkBox31).BackColor = Color.Transparent;
		((Control)checkBox31).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox31).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox31).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox31).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox31).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox31).FlatStyle = (FlatStyle)0;
		((Control)checkBox31).Location = new Point(56, 74);
		((Control)checkBox31).Name = "checkBox31";
		((Control)checkBox31).Size = new Size(61, 23);
		((Control)checkBox31).TabIndex = 23;
		((Control)checkBox31).Text = "Auto Buff";
		((ButtonBase)checkBox31).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox31).UseVisualStyleBackColor = false;
		checkBox31.CheckedChanged += checkBox31_CheckedChanged;
		checkBox22.Appearance = (Appearance)1;
		((Control)checkBox22).AutoSize = true;
		((Control)checkBox22).BackColor = Color.Transparent;
		((Control)checkBox22).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox22).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox22).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox22).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox22).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox22).FlatStyle = (FlatStyle)0;
		((Control)checkBox22).Location = new Point(56, 16);
		((Control)checkBox22).Name = "checkBox22";
		((Control)checkBox22).Size = new Size(106, 23);
		((Control)checkBox22).TabIndex = 22;
		((Control)checkBox22).Text = "Anti Stun Advance";
		((ButtonBase)checkBox22).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox22).UseVisualStyleBackColor = false;
		checkBox22.CheckedChanged += checkBox22_CheckedChanged;
		checkBox23.Appearance = (Appearance)1;
		((Control)checkBox23).AutoSize = true;
		((Control)checkBox23).BackColor = Color.Transparent;
		((ButtonBase)checkBox23).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox23).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox23).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox23).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox23).FlatStyle = (FlatStyle)0;
		((Control)checkBox23).Location = new Point(254, 16);
		((Control)checkBox23).Name = "checkBox23";
		((Control)checkBox23).Size = new Size(98, 23);
		((Control)checkBox23).TabIndex = 23;
		((Control)checkBox23).Text = "Bot Mode [ OFF ]";
		((ButtonBase)checkBox23).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox23).UseVisualStyleBackColor = false;
		checkBox23.CheckedChanged += checkBox23_CheckedChanged;
		checkBox19.Appearance = (Appearance)1;
		((Control)checkBox19).AutoSize = true;
		((Control)checkBox19).BackColor = Color.Transparent;
		((Control)checkBox19).BackgroundImageLayout = (ImageLayout)0;
		((ButtonBase)checkBox19).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox19).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox19).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox19).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox19).FlatStyle = (FlatStyle)0;
		((Control)checkBox19).Location = new Point(56, 16);
		((Control)checkBox19).Name = "checkBox19";
		((Control)checkBox19).Size = new Size(109, 23);
		((Control)checkBox19).TabIndex = 19;
		((Control)checkBox19).Text = "Auto Loot Advance";
		((ButtonBase)checkBox19).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox19).UseVisualStyleBackColor = false;
		checkBox19.CheckedChanged += checkBox19_CheckedChanged;
		((Control)panel3).BackColor = Color.Transparent;
		((Control)panel3).Controls.Add((Control)(object)checkBox26);
		((Control)panel3).Controls.Add((Control)(object)checkBox25);
		((Control)panel3).Controls.Add((Control)(object)checkBox24);
		((Control)panel3).Location = new Point(690, 65);
		((Control)panel3).Name = "panel3";
		((Control)panel3).Size = new Size(580, 270);
		((Control)panel3).TabIndex = 0;
		((Control)panel3).MouseDown += App_MouseDown;
		checkBox26.Appearance = (Appearance)1;
		((Control)checkBox26).AutoSize = true;
		((Control)checkBox26).BackColor = Color.Transparent;
		((ButtonBase)checkBox26).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox26).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox26).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox26).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox26).FlatStyle = (FlatStyle)0;
		((Control)checkBox26).Location = new Point(53, 100);
		((Control)checkBox26).Name = "checkBox26";
		((Control)checkBox26).Size = new Size(94, 23);
		((Control)checkBox26).TabIndex = 26;
		((Control)checkBox26).Text = "Autosave Profile";
		((ButtonBase)checkBox26).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox26).UseVisualStyleBackColor = false;
		checkBox26.CheckedChanged += checkBox26_CheckedChanged;
		checkBox25.Appearance = (Appearance)1;
		((Control)checkBox25).AutoSize = true;
		((Control)checkBox25).BackColor = Color.Transparent;
		((ButtonBase)checkBox25).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox25).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox25).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox25).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox25).FlatStyle = (FlatStyle)0;
		((Control)checkBox25).Location = new Point(53, 71);
		((Control)checkBox25).Name = "checkBox25";
		((Control)checkBox25).Size = new Size(128, 23);
		((Control)checkBox25).TabIndex = 25;
		((Control)checkBox25).Text = "Disable Auto Check RF";
		((ButtonBase)checkBox25).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox25).UseVisualStyleBackColor = false;
		checkBox25.CheckedChanged += checkBox25_CheckedChanged;
		checkBox24.Appearance = (Appearance)1;
		((Control)checkBox24).AutoSize = true;
		((Control)checkBox24).BackColor = Color.Transparent;
		((ButtonBase)checkBox24).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox24).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox24).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox24).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox24).FlatStyle = (FlatStyle)0;
		((Control)checkBox24).Location = new Point(53, 42);
		((Control)checkBox24).Name = "checkBox24";
		((Control)checkBox24).Size = new Size(101, 23);
		((Control)checkBox24).TabIndex = 24;
		((Control)checkBox24).Text = "Disable Animation";
		((ButtonBase)checkBox24).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox24).UseVisualStyleBackColor = false;
		checkBox24.CheckedChanged += checkBox24_CheckedChanged;
		timer_0.Interval = 5000;
		timer_0.Tick += timer_0_Tick;
		((Control)panel4).BackColor = Color.Transparent;
		((Control)panel4).Controls.Add((Control)(object)label4);
		((Control)panel4).Location = new Point(110, 4);
		((Control)panel4).Name = "panel4";
		((Control)panel4).Size = new Size(580, 77);
		((Control)panel4).TabIndex = 114;
		((Control)panel4).MouseDown += App_MouseDown;
		((Control)label4).AutoSize = true;
		((Control)label4).BackColor = Color.Transparent;
		((Control)label4).Cursor = Cursors.Default;
		((Control)label4).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label4).Location = new Point(53, 54);
		((Control)label4).Name = "label4";
		((Control)label4).Size = new Size(230, 16);
		((Control)label4).TabIndex = 115;
		((Control)label4).Text = "[66] Bellato - nickname - Ranger";
		((Control)panel5).BackColor = Color.Transparent;
		((Control)panel5).Controls.Add((Control)(object)label5);
		((Control)panel5).Location = new Point(41, 110);
		((Control)panel5).Name = "panel5";
		((Control)panel5).Size = new Size(580, 75);
		((Control)panel5).TabIndex = 115;
		((Control)panel5).MouseDown += App_MouseDown;
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
		((Control)panel6).BackColor = Color.Transparent;
		((Control)panel6).Controls.Add((Control)(object)checkBox46);
		((Control)panel6).Controls.Add((Control)(object)checkBox39);
		((Control)panel6).Controls.Add((Control)(object)label15);
		((Control)panel6).Controls.Add((Control)(object)checkBox38);
		((Control)panel6).Controls.Add((Control)(object)label12);
		((Control)panel6).Controls.Add((Control)(object)label11);
		((Control)panel6).Controls.Add((Control)(object)textBox12);
		((Control)panel6).Controls.Add((Control)(object)label10);
		((Control)panel6).Controls.Add((Control)(object)button3);
		((Control)panel6).Controls.Add((Control)(object)textBox11);
		((Control)panel6).Controls.Add((Control)(object)label9);
		((Control)panel6).Controls.Add((Control)(object)groupBox4);
		((Control)panel6).Controls.Add((Control)(object)button2);
		((Control)panel6).Controls.Add((Control)(object)textBox10);
		((Control)panel6).Controls.Add((Control)(object)label8);
		((Control)panel6).Controls.Add((Control)(object)groupBox3);
		((Control)panel6).Controls.Add((Control)(object)checkBox23);
		((Control)panel6).Controls.Add((Control)(object)checkBox19);
		((Control)panel6).Location = new Point(38, 7);
		((Control)panel6).Name = "panel6";
		((Control)panel6).Size = new Size(700, 290);
		((Control)panel6).TabIndex = 118;
		((Control)panel6).MouseDown += App_MouseDown;
		checkBox39.Appearance = (Appearance)1;
		((Control)checkBox39).AutoSize = true;
		((Control)checkBox39).BackColor = Color.Transparent;
		((ButtonBase)checkBox39).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox39).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox39).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox39).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox39).FlatStyle = (FlatStyle)0;
		((Control)checkBox39).Location = new Point(490, 16);
		((Control)checkBox39).Name = "checkBox39";
		((Control)checkBox39).Size = new Size(100, 23);
		((Control)checkBox39).TabIndex = 40;
		((Control)checkBox39).Text = "Normal Attack Hit";
		((ButtonBase)checkBox39).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox39).UseVisualStyleBackColor = false;
		checkBox39.CheckedChanged += checkBox39_CheckedChanged;
		((Control)label15).Location = new Point(-4, 108);
		((Control)label15).Name = "label15";
		((Control)label15).Size = new Size(246, 15);
		((Control)label15).TabIndex = 39;
		((Control)label15).Text = "X: 10000 - Y: 10000 - Z: 10000";
		label15.TextAlign = (ContentAlignment)32;
		checkBox38.Appearance = (Appearance)1;
		((Control)checkBox38).AutoSize = true;
		((Control)checkBox38).BackColor = Color.Transparent;
		((ButtonBase)checkBox38).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox38).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox38).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox38).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox38).FlatStyle = (FlatStyle)0;
		((Control)checkBox38).Location = new Point(72, 82);
		((Control)checkBox38).Name = "checkBox38";
		((Control)checkBox38).Size = new Size(66, 23);
		((Control)checkBox38).TabIndex = 38;
		((Control)checkBox38).Text = "Lock Spot";
		((ButtonBase)checkBox38).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox38).UseVisualStyleBackColor = false;
		checkBox38.CheckedChanged += checkBox38_CheckedChanged;
		((Control)label12).AutoSize = true;
		((Control)label12).Location = new Point(28, 58);
		((Control)label12).Name = "label12";
		((Control)label12).Size = new Size(185, 13);
		((Control)label12).TabIndex = 37;
		((Control)label12).Text = "loot without pursuing the ground items";
		((Control)label11).AutoSize = true;
		((Control)label11).Location = new Point(32, 41);
		((Control)label11).Name = "label11";
		((Control)label11).Size = new Size(177, 13);
		((Control)label11).TabIndex = 36;
		((Control)label11).Text = "loot without hindrance (sit, siege, dll)";
		((Control)textBox12).BackColor = Color.Black;
		((Control)textBox12).ForeColor = Color.White;
		((Control)textBox12).Location = new Point(403, 18);
		((Control)textBox12).Name = "textBox12";
		((Control)textBox12).Size = new Size(47, 20);
		((Control)textBox12).TabIndex = 35;
		((Control)textBox12).Text = "200";
		textBox12.TextAlign = (HorizontalAlignment)2;
		((Control)label10).AutoSize = true;
		((Control)label10).Location = new Point(368, 21);
		((Control)label10).Name = "label10";
		((Control)label10).Size = new Size(28, 13);
		((Control)label10).TabIndex = 34;
		((Control)label10).Text = "Dist.";
		((Control)button3).Cursor = Cursors.Hand;
		((ButtonBase)button3).FlatStyle = (FlatStyle)0;
		((Control)button3).ForeColor = Color.White;
		((Control)button3).Location = new Point(401, 234);
		((Control)button3).Margin = new Padding(0);
		((Control)button3).Name = "button3";
		((Control)button3).Size = new Size(30, 20);
		((Control)button3).TabIndex = 33;
		((Control)button3).Text = "+";
		((ButtonBase)button3).TextAlign = (ContentAlignment)2;
		((ButtonBase)button3).UseVisualStyleBackColor = true;
		((Control)button3).Click += button3_Click;
		((Control)textBox11).BackColor = Color.Black;
		((Control)textBox11).ForeColor = Color.White;
		((Control)textBox11).Location = new Point(316, 234);
		((Control)textBox11).Name = "textBox11";
		((Control)textBox11).Size = new Size(79, 20);
		((Control)textBox11).TabIndex = 32;
		textBox11.TextAlign = (HorizontalAlignment)2;
		((Control)textBox11).KeyDown += textBox11_KeyDown;
		((Control)label9).AutoSize = true;
		((Control)label9).Location = new Point(263, 239);
		((Control)label9).Name = "label9";
		((Control)label9).Size = new Size(55, 13);
		((Control)label9).TabIndex = 31;
		((Control)label9).Text = "Add Mobs";
		((Control)groupBox4).ForeColor = Color.White;
		((Control)groupBox4).Location = new Point(254, 50);
		((Control)groupBox4).Name = "groupBox4";
		((Control)groupBox4).Size = new Size(200, 177);
		((Control)groupBox4).TabIndex = 25;
		groupBox4.TabStop = false;
		((Control)groupBox4).Text = "Mobs to be Attacked";
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).ForeColor = Color.White;
		((Control)button2).Location = new Point(637, 173);
		((Control)button2).Margin = new Padding(0);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(30, 20);
		((Control)button2).TabIndex = 30;
		((Control)button2).Text = "+";
		((ButtonBase)button2).TextAlign = (ContentAlignment)2;
		((ButtonBase)button2).UseVisualStyleBackColor = true;
		((Control)textBox10).BackColor = Color.Black;
		((Control)textBox10).ForeColor = Color.White;
		((Control)textBox10).Location = new Point(552, 173);
		((Control)textBox10).Name = "textBox10";
		((Control)textBox10).Size = new Size(79, 20);
		((Control)textBox10).TabIndex = 29;
		textBox10.TextAlign = (HorizontalAlignment)2;
		((Control)label8).AutoSize = true;
		((Control)label8).Location = new Point(499, 178);
		((Control)label8).Name = "label8";
		((Control)label8).Size = new Size(48, 13);
		((Control)label8).TabIndex = 25;
		((Control)label8).Text = "Add Skill";
		((Control)groupBox3).ForeColor = Color.White;
		((Control)groupBox3).Location = new Point(490, 91);
		((Control)groupBox3).Name = "groupBox3";
		((Control)groupBox3).Size = new Size(200, 73);
		((Control)groupBox3).TabIndex = 24;
		groupBox3.TabStop = false;
		((Control)groupBox3).Text = "Skill List to be Invoked";
		((Control)button4).BackColor = Color.Transparent;
		((Control)button4).Cursor = Cursors.Hand;
		((ButtonBase)button4).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button4).FlatStyle = (FlatStyle)0;
		((Control)button4).Location = new Point(297, 392);
		((Control)button4).Name = "button4";
		((Control)button4).Size = new Size(75, 23);
		((Control)button4).TabIndex = 119;
		((Control)button4).Text = "SCAN RFS";
		((ButtonBase)button4).UseVisualStyleBackColor = false;
		((Control)button4).Visible = false;
		((Control)button4).Click += button4_Click;
		timer_1.Tick += timer_1_Tick;
		((Control)button5).BackColor = Color.Transparent;
		((Control)button5).BackgroundImage = (Image)(object)Resources.minimize_grey;
		((Control)button5).BackgroundImageLayout = (ImageLayout)3;
		((Control)button5).Cursor = Cursors.Hand;
		((ButtonBase)button5).FlatAppearance.BorderSize = 0;
		((ButtonBase)button5).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)button5).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button5).FlatStyle = (FlatStyle)0;
		((Control)button5).Location = new Point(734, 12);
		((Control)button5).Name = "button5";
		((Control)button5).Size = new Size(20, 20);
		((Control)button5).TabIndex = 120;
		((ButtonBase)button5).UseVisualStyleBackColor = false;
		((Control)button5).Click += button5_Click;
		((Control)button5).MouseEnter += button5_MouseEnter;
		((Control)button5).MouseLeave += button5_MouseLeave;
		((Control)pictureBox9).BackColor = Color.White;
		((Control)pictureBox9).Location = new Point(522, 437);
		((Control)pictureBox9).Name = "pictureBox9";
		((Control)pictureBox9).Size = new Size(50, 5);
		pictureBox9.TabIndex = 117;
		pictureBox9.TabStop = false;
		((Control)pictureBox10).BackColor = Color.Transparent;
		((Control)pictureBox10).BackgroundImageLayout = (ImageLayout)3;
		((Control)pictureBox10).Cursor = Cursors.Hand;
		pictureBox10.Image = (Image)(object)Resources.brutal;
		((Control)pictureBox10).Location = new Point(522, 384);
		((Control)pictureBox10).Margin = new Padding(0);
		((Control)pictureBox10).Name = "pictureBox10";
		((Control)pictureBox10).Size = new Size(50, 50);
		pictureBox10.TabIndex = 116;
		pictureBox10.TabStop = false;
		((Control)pictureBox10).Click += pictureBox10_Click;
		((Control)pictureBox8).BackColor = Color.White;
		((Control)pictureBox8).Location = new Point(244, 392);
		((Control)pictureBox8).Name = "pictureBox8";
		((Control)pictureBox8).Size = new Size(3, 50);
		pictureBox8.TabIndex = 113;
		pictureBox8.TabStop = false;
		((Control)pictureBox7).BackColor = Color.White;
		((Control)pictureBox7).Location = new Point(722, 437);
		((Control)pictureBox7).Name = "pictureBox7";
		((Control)pictureBox7).Size = new Size(50, 5);
		pictureBox7.TabIndex = 112;
		pictureBox7.TabStop = false;
		((Control)pictureBox6).BackColor = Color.White;
		((Control)pictureBox6).Location = new Point(622, 437);
		((Control)pictureBox6).Name = "pictureBox6";
		((Control)pictureBox6).Size = new Size(50, 5);
		pictureBox6.TabIndex = 111;
		pictureBox6.TabStop = false;
		((Control)pictureBox5).BackColor = Color.White;
		((Control)pictureBox5).Location = new Point(422, 437);
		((Control)pictureBox5).Name = "pictureBox5";
		((Control)pictureBox5).Size = new Size(50, 5);
		pictureBox5.TabIndex = 110;
		pictureBox5.TabStop = false;
		((Control)pictureBox4).BackColor = Color.Transparent;
		((Control)pictureBox4).BackgroundImageLayout = (ImageLayout)3;
		((Control)pictureBox4).Cursor = Cursors.Hand;
		pictureBox4.Image = (Image)(object)Resources.settings;
		((Control)pictureBox4).Location = new Point(722, 384);
		((Control)pictureBox4).Margin = new Padding(0);
		((Control)pictureBox4).Name = "pictureBox4";
		((Control)pictureBox4).Size = new Size(50, 50);
		pictureBox4.TabIndex = 107;
		pictureBox4.TabStop = false;
		((Control)pictureBox4).Click += pictureBox4_Click;
		((Control)pictureBox4).MouseHover += pictureBox4_MouseHover;
		((Control)pictureBox3).BackColor = Color.Transparent;
		((Control)pictureBox3).BackgroundImageLayout = (ImageLayout)3;
		((Control)pictureBox3).Cursor = Cursors.Hand;
		pictureBox3.Image = (Image)(object)Resources.gaming;
		((Control)pictureBox3).Location = new Point(622, 379);
		((Control)pictureBox3).Margin = new Padding(0);
		((Control)pictureBox3).Name = "pictureBox3";
		((Control)pictureBox3).Size = new Size(50, 50);
		pictureBox3.TabIndex = 106;
		pictureBox3.TabStop = false;
		((Control)pictureBox3).Click += pictureBox3_Click;
		((Control)pictureBox3).MouseHover += pictureBox3_MouseHover;
		((Control)pictureBox2).BackColor = Color.Transparent;
		((Control)pictureBox2).BackgroundImageLayout = (ImageLayout)3;
		((Control)pictureBox2).Cursor = Cursors.Hand;
		pictureBox2.Image = (Image)(object)Resources.joystick;
		((Control)pictureBox2).Location = new Point(422, 383);
		((Control)pictureBox2).Margin = new Padding(0);
		((Control)pictureBox2).Name = "pictureBox2";
		((Control)pictureBox2).Size = new Size(50, 50);
		pictureBox2.TabIndex = 105;
		pictureBox2.TabStop = false;
		((Control)pictureBox2).Click += pictureBox2_Click;
		((Control)pictureBox2).MouseHover += pictureBox2_MouseHover;
		((Control)pictureBox1).BackColor = Color.Transparent;
		((Control)pictureBox1).BackgroundImageLayout = (ImageLayout)3;
		((Control)pictureBox1).Cursor = Cursors.Hand;
		pictureBox1.Image = (Image)(object)Resources.GNTRainer_logo;
		((Control)pictureBox1).Location = new Point(9, 375);
		((Control)pictureBox1).Margin = new Padding(0);
		((Control)pictureBox1).Name = "pictureBox1";
		((Control)pictureBox1).Size = new Size(75, 75);
		pictureBox1.SizeMode = (PictureBoxSizeMode)1;
		pictureBox1.TabIndex = 101;
		pictureBox1.TabStop = false;
		((Control)pictureBox1).Click += pictureBox1_Click;
		((Control)lblVersion).AutoSize = true;
		((Control)lblVersion).BackColor = Color.Transparent;
		((Control)lblVersion).ForeColor = Color.White;
		((Control)lblVersion).Location = new Point(301, 420);
		((Control)lblVersion).Name = "lblVersion";
		((Control)lblVersion).Size = new Size(51, 13);
		((Control)lblVersion).TabIndex = 129;
		((Control)lblVersion).Text = "Version : ";
		checkBox46.Appearance = (Appearance)1;
		((Control)checkBox46).AutoSize = true;
		((Control)checkBox46).BackColor = Color.Transparent;
		((ButtonBase)checkBox46).FlatAppearance.BorderSize = 0;
		((ButtonBase)checkBox46).FlatAppearance.CheckedBackColor = Color.Transparent;
		((ButtonBase)checkBox46).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)checkBox46).FlatAppearance.MouseOverBackColor = Color.Gray;
		((ButtonBase)checkBox46).FlatStyle = (FlatStyle)0;
		((Control)checkBox46).Location = new Point(490, 48);
		((Control)checkBox46).Name = "checkBox46";
		((Control)checkBox46).Size = new Size(110, 23);
		((Control)checkBox46).TabIndex = 41;
		((Control)checkBox46).Text = "Auto Attack Animus";
		((ButtonBase)checkBox46).TextImageRelation = (TextImageRelation)4;
		((ButtonBase)checkBox46).UseVisualStyleBackColor = false;
		checkBox46.CheckedChanged += checkBox46_CheckedChanged;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImage = (Image)(object)Resources.bg;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		((Form)this).ClientSize = new Size(800, 450);
		((Control)this).Controls.Add((Control)(object)panel6);
		((Control)this).Controls.Add((Control)(object)lblVersion);
		((Control)this).Controls.Add((Control)(object)panel1);
		((Control)this).Controls.Add((Control)(object)panel2);
		((Control)this).Controls.Add((Control)(object)button5);
		((Control)this).Controls.Add((Control)(object)button4);
		((Control)this).Controls.Add((Control)(object)pictureBox9);
		((Control)this).Controls.Add((Control)(object)pictureBox10);
		((Control)this).Controls.Add((Control)(object)panel4);
		((Control)this).Controls.Add((Control)(object)pictureBox8);
		((Control)this).Controls.Add((Control)(object)pictureBox7);
		((Control)this).Controls.Add((Control)(object)pictureBox6);
		((Control)this).Controls.Add((Control)(object)pictureBox5);
		((Control)this).Controls.Add((Control)(object)pictureBox4);
		((Control)this).Controls.Add((Control)(object)pictureBox3);
		((Control)this).Controls.Add((Control)(object)pictureBox2);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)pictureBox1);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).Controls.Add((Control)(object)panel3);
		((Control)this).Controls.Add((Control)(object)panel5);
		((Control)this).DoubleBuffered = true;
		((Control)this).ForeColor = Color.White;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Control)this).Name = "App";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).MouseDown += App_MouseDown;
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((Control)panel5).ResumeLayout(false);
		((Control)panel5).PerformLayout();
		((Control)panel6).ResumeLayout(false);
		((Control)panel6).PerformLayout();
		((ISupportInitialize)pictureBox9).EndInit();
		((ISupportInitialize)pictureBox10).EndInit();
		((ISupportInitialize)pictureBox8).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
