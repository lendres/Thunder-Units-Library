using System;
using System.Windows.Forms;

namespace Thor.TestApp
{
	/// <summary>
	/// Main program entry.
	/// </summary>
	static class Program
	{
		#region Main

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		#endregion

	} // End class.
} // End namespace.
