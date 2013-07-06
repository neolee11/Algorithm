using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Algorithms
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MainForm());
            int[] b = new int[256];

            char a = 'a';
            int i = (int)a;
            //MessageBox.Show(i.ToString());

            Application.Run(new MainForm());
            //Application.Run(new BSTForm());
			//Application.Run(new SortingForm());
			//Application.Run(new LinkedListForm());
			//Application.Run(new DPForm());
			//Application.Run(new StackAndQueueForm());
			//Application.Run(new ArrayProblemsForm());
		}
	}
}