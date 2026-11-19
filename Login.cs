using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;
using RFSNCS.Properties;

public class Login : Form
{
	private DateTime startDate;

	private int activeDays;

	private GClass4 gclass4_0;

	private IContainer icontainer_0;

	private Button button1;

	private TextBox textBox1;

	private Label label1;

	private Button button2;

	private BackgroundWorker backgroundWorker_0;

	public DateTime GetCurrentTime
	{
		get
		{
			try
			{
				using WebResponse webResponse = WebRequest.Create("http://www.google.com").GetResponse();
				return DateTime.ParseExact(webResponse.Headers["date"], "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
			}
			catch (WebException)
			{
				return DateTime.Now;
			}
		}
	}

	private void Login_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			GClass1.ReleaseCapture();
			GClass1.SendMessage(method_1(), 161, 2, 0);
		}
	}

	public Login()
	{
		startDate = DateTime.ParseExact("01/01/2099 00:00:00", "dd/MM/yyyy hh:mm:ss", null);
		activeDays = 999999;
		InitializeComponent();
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Region = Region.FromHrgn(GClass1.CreateRoundRectRgn(0, 0, ((Control)this).Width, ((Control)this).Height, 20, 20));
	}

	private void method_0(string string_0)
	{
		((Control)textBox1).Enabled = false;
		((Control)button1).Enabled = false;
		((Control)this).Cursor = Cursors.WaitCursor;
		backgroundWorker_0.RunWorkerAsync();
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		gclass4_0 = new GClass4();
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Form)this).Close();
		((Control)new Synchro(gclass4_0)).Show();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_0(((Control)textBox1).Text);
	}

	private void textBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			method_0(((Control)textBox1).Text);
		}
	}

	private void button2_MouseEnter(object sender, EventArgs e)
	{
		((Control)button2).BackgroundImage = (Image)(object)Class10.Bitmap_5;
	}

	private void button2_MouseLeave(object sender, EventArgs e)
	{
		((Control)button2).BackgroundImage = (Image)(object)Class10.Bitmap_4;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure want to exit?", "DelB - Exit", (MessageBoxButtons)3, (MessageBoxIcon)48) == 6)
		{
			Application.Exit();
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private IntPtr method_1()
	{
		return ((Control)this).Handle;
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		button1 = new Button();
		textBox1 = new TextBox();
		label1 = new Label();
		button2 = new Button();
		backgroundWorker_0 = new BackgroundWorker();
		((Control)this).SuspendLayout();
		((Control)button1).BackColor = Color.Black;
		((Control)button1).Cursor = Cursors.Hand;
		((ButtonBase)button1).FlatAppearance.BorderColor = Color.White;
		((ButtonBase)button1).FlatAppearance.MouseDownBackColor = Color.Black;
		((ButtonBase)button1).FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
		((ButtonBase)button1).FlatStyle = (FlatStyle)0;
		((Control)button1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)button1).Location = new Point(87, 102);
		((Control)button1).Margin = new Padding(0);
		((Control)button1).Name = "button1";
		((Control)button1).Size = new Size(100, 28);
		((Control)button1).TabIndex = 1;
		((Control)button1).Text = "Enter !";
		((ButtonBase)button1).TextAlign = (ContentAlignment)2;
		((ButtonBase)button1).UseVisualStyleBackColor = true;
		((Control)button1).Click += button1_Click;
		((Control)textBox1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)textBox1).Location = new Point(50, 62);
		((Control)textBox1).Name = "textBox1";
		textBox1.PasswordChar = '*';
		((Control)textBox1).Size = new Size(175, 22);
		((Control)textBox1).TabIndex = 0;
		textBox1.TextAlign = (HorizontalAlignment)2;
		((Control)textBox1).KeyDown += textBox1_KeyDown;
		((Control)label1).AutoSize = true;
		((Control)label1).BackColor = Color.Transparent;
		((Control)label1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)label1).ForeColor = SystemColors.ControlLightLight;
		((Control)label1).Location = new Point(42, 23);
		((Control)label1).Name = "label1";
		((Control)label1).Size = new Size(195, 20);
		((Control)label1).TabIndex = 2;
		((Control)label1).Text = "THE BROTHER LOGIN";
		((Control)label1).MouseDown += Login_MouseDown;
		((Control)button2).BackColor = Color.Transparent;
		((Control)button2).BackgroundImageLayout = (ImageLayout)3;
		((Control)button2).Cursor = Cursors.Hand;
		((ButtonBase)button2).FlatAppearance.BorderSize = 0;
		((ButtonBase)button2).FlatAppearance.MouseDownBackColor = Color.Transparent;
		((ButtonBase)button2).FlatAppearance.MouseOverBackColor = Color.Transparent;
		((ButtonBase)button2).FlatStyle = (FlatStyle)0;
		((Control)button2).Location = new Point(250, 5);
		((Control)button2).Name = "button2";
		((Control)button2).Size = new Size(20, 20);
		((Control)button2).TabIndex = 99;
		((ButtonBase)button2).UseVisualStyleBackColor = false;
		((Control)button2).Click += button2_Click;
		((Control)button2).MouseEnter += button2_MouseEnter;
		((Control)button2).MouseLeave += button2_MouseLeave;
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
		((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImage = (Image)(object)Resources.Untitled_design_1;
		((Control)this).BackgroundImageLayout = (ImageLayout)2;
		((Form)this).ClientSize = new Size(275, 150);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)textBox1);
		((Control)this).Controls.Add((Control)(object)button1);
		((Control)this).DoubleBuffered = true;
		((Control)this).ForeColor = Color.White;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "Login";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).Text = "Login";
		((Control)this).MouseDown += Login_MouseDown;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
