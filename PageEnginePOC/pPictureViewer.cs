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
	public partial class pPictureViewer : Form, iPage
	{
		public string PageType { get { return "PagePictureViewer"; } }
		public PForm pParent;

		public Bitmap TheImage;

		public pPictureViewer(Bitmap StartImage)
		{
			InitializeComponent();

			this.TheImage = StartImage;
			this.ImageBox.BackgroundImage = this.TheImage;
			this.ImageBox.BackgroundImageLayout = ImageLayout.Zoom;

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
		private void pPictureViewer_Load(object sender, EventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.pParent.GoBack();
		}

	}
}
