using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PageEngine;

namespace PageEnginePOC
{
	public partial class pTwoTextbox : Form, iPage
	{
		public string PageType { get { return "PageTwoTextbox"; } }
		public PForm pParent;



		public pTwoTextbox(bool ChangeTheText = false)
		{
			InitializeComponent();

			if (ChangeTheText) { this.textBox1.Text = "you know what to test"; }
		}
		public void Initialize(PForm StartPParent)
		{
			this.pParent = StartPParent;
		}
		public void Start()
		{
			
		}
		public void Pause()
		{

		}
		public void Destroy()
		{

		}
		private void pTwoTextbox_Load(object sender, EventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.pParent.GoBack();
		}
	}
}
