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
	public partial class pSubSubPage : Form, iPage
	{
		public string PageType { get { return "PageSubSub"; } }
		public PForm pParent;

		public pSubSubPage()
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
		private void pSubSubPage_Load(object sender, EventArgs e)
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

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.pParent.GoBack();
		}
		private void ButtonForward_Click(object sender, EventArgs e)
		{
			this.pParent.GoForward();
		}

		private void ButtonTwoTextbox_Click(object sender, EventArgs e)
		{
			pTwoTextbox newp = new pTwoTextbox(true);
			this.pParent.Navigate(newp);
		}
		private void ButtonInfiniteSubSub_Click(object sender, EventArgs e)
		{
			pSubSubPage newp = new pSubSubPage();
			this.pParent.Navigate(newp);
		}

	}
}
