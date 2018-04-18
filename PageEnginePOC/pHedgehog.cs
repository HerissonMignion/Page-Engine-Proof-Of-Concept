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
	public partial class pHedgehog : Form, iPage
	{
		public string PageType { get { return "PageHedgehog"; } }
		public PForm pParent;

		public pHedgehog()
		{
			InitializeComponent();
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
		private void pHedgehog_Load(object sender, EventArgs e)
		{

		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.pParent.GoBack();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.imgHedgehog);
			this.pParent.Navigate(newp);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionTimbits);
			this.pParent.Navigate(newp);
		}
		private void button3_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionPouceBleu);
			this.pParent.Navigate(newp);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionCompanionCube);
			this.pParent.Navigate(newp);
		}
		private void button5_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionAvecPizza);
			this.pParent.Navigate(newp);
		}
		private void button6_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionAvecOrdi);
			this.pParent.Navigate(newp);
		}
		private void button7_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionAstronaute);
			this.pParent.Navigate(newp);
		}
		private void button8_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionPokemonGo);
			this.pParent.Navigate(newp);
		}
		private void button9_Click(object sender, EventArgs e)
		{
			pPictureViewer newp = new pPictureViewer(PageEnginePOC.Properties.Resources.HerissonMignionPepsi);
			this.pParent.Navigate(newp);
		}
	}
}
