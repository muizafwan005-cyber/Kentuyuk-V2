using System;
using System.Windows.Forms;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		((Control)new App(new GClass4
		{
			Int32_0 = 500,
			String_0 = "KENTUYUK TRAINER",
			String_1 = "LANANG MODE"
		})).Show();
		Application.Run();
	}
}
