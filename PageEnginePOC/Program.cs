using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PageEngine;

namespace PageEnginePOC
{
	static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);


			PForm MainForm = new PForm();
			MainForm.Title = "Page Engine Proof Of Concept";
			MainForm.Size = new System.Drawing.Size(700, 600);
			MainForm.MinimumSize = new System.Drawing.Size(400, 550);

			pMain MainPage = new pMain();
			MainForm.Navigate(MainPage);

			


			MainForm.ShowDialog();
		}
	}
}
