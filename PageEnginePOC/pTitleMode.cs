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
	public partial class pTitleMode : Form, iPage
	{
		public string PageType { get { return "PageTitleMode"; } }
		public PForm pParent;

		public pTitleMode()
		{
			InitializeComponent();
		}
		public void Initialize(PForm StartPParent)
		{
			this.pParent = StartPParent;
		}
		public void Start()
		{
			this.CheckButtonEnable();
		}
		public void Pause()
		{

		}
		public void Destroy()
		{

		}
		private void pTitleMode_Load(object sender, EventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.pParent.GoBack();
		}

		

		public void CheckButtonEnable()
		{
			this.ButtonMainAndPage.Enabled = true;
			this.ButtonMainOnly.Enabled = true;
			this.ButtonPageOnly.Enabled = true;
			if (this.pParent.TitleMode == PForm.PFormTitleMode.MainAndPage) { this.ButtonMainAndPage.Enabled = false; }
			if (this.pParent.TitleMode == PForm.PFormTitleMode.MainTitleOnly) { this.ButtonMainOnly.Enabled = false; }
			if (this.pParent.TitleMode == PForm.PFormTitleMode.PageTitleOnly) { this.ButtonPageOnly.Enabled = false; }
		}
		private void ButtonMainAndPage_Click(object sender, EventArgs e)
		{
			this.pParent.TitleMode = PForm.PFormTitleMode.MainAndPage;
			this.CheckButtonEnable();
		}
		private void ButtonMainOnly_Click(object sender, EventArgs e)
		{
			this.pParent.TitleMode = PForm.PFormTitleMode.MainTitleOnly;
			this.CheckButtonEnable();
		}
		private void ButtonPageOnly_Click(object sender, EventArgs e)
		{
			this.pParent.TitleMode = PForm.PFormTitleMode.PageTitleOnly;
			this.CheckButtonEnable();
		}

	}
}
