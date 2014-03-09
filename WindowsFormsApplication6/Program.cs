using System;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var state = new SharedState();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1(state));
		}
	}
}
