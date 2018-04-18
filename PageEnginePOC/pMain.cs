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
	public partial class pMain : Form, iPage
	{
		public string PageType { get { return "PageMain"; } }
		public PForm pParent;

		public pMain()
		{
			InitializeComponent();
		}
		public void Initialize(PForm StartPParent)
		{
			this.pParent = StartPParent;
		}
		public void Start()
		{
			this.CheckButtonVisibility();
		}
		public void Pause()
		{

		}
		public void Destroy()
		{

		}
		private void pMain_Load(object sender, EventArgs e)
		{
			
		}


		public void CheckButtonVisibility()
		{
			if (this.pParent.CanGoForward)
			{
				this.ButtonForward.Visible = true;
			}
			else
			{
				this.ButtonForward.Visible = false;
			}
		}

		private void ButtonForward_Click(object sender, EventArgs e)
		{
			this.pParent.GoForward();
		}

		private void ButtonTitleMode_Click(object sender, EventArgs e)
		{
			pTitleMode newp = new pTitleMode();
			this.pParent.Navigate(newp);
		}
		private void ButtonTwoTextbox_Click(object sender, EventArgs e)
		{
			pTwoTextbox newp = new pTwoTextbox();
			this.pParent.Navigate(newp);
		}
		private void ButtonSubSubPage_Click(object sender, EventArgs e)
		{
			pSubSubPage newp = new pSubSubPage();
			this.pParent.Navigate(newp);
		}
		private void ButtonHedgehog_Click(object sender, EventArgs e)
		{
			pHedgehog newp = new pHedgehog();
			this.pParent.Navigate(newp);
		}

	}
}
