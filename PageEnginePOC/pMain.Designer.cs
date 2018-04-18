namespace PageEnginePOC
{
	partial class pMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonTitleMode = new System.Windows.Forms.Button();
			this.ButtonForward = new System.Windows.Forms.Button();
			this.ButtonTwoTextbox = new System.Windows.Forms.Button();
			this.ButtonSubSubPage = new System.Windows.Forms.Button();
			this.ButtonHedgehog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonTitleMode
			// 
			this.ButtonTitleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonTitleMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonTitleMode.Location = new System.Drawing.Point(12, 51);
			this.ButtonTitleMode.Name = "ButtonTitleMode";
			this.ButtonTitleMode.Size = new System.Drawing.Size(551, 95);
			this.ButtonTitleMode.TabIndex = 0;
			this.ButtonTitleMode.Text = "Change Title Mode";
			this.ButtonTitleMode.UseVisualStyleBackColor = true;
			this.ButtonTitleMode.Click += new System.EventHandler(this.ButtonTitleMode_Click);
			// 
			// ButtonForward
			// 
			this.ButtonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonForward.Location = new System.Drawing.Point(515, 12);
			this.ButtonForward.Name = "ButtonForward";
			this.ButtonForward.Size = new System.Drawing.Size(48, 33);
			this.ButtonForward.TabIndex = 1;
			this.ButtonForward.Text = "-->";
			this.ButtonForward.UseVisualStyleBackColor = true;
			this.ButtonForward.Click += new System.EventHandler(this.ButtonForward_Click);
			// 
			// ButtonTwoTextbox
			// 
			this.ButtonTwoTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonTwoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonTwoTextbox.Location = new System.Drawing.Point(12, 152);
			this.ButtonTwoTextbox.Name = "ButtonTwoTextbox";
			this.ButtonTwoTextbox.Size = new System.Drawing.Size(551, 95);
			this.ButtonTwoTextbox.TabIndex = 2;
			this.ButtonTwoTextbox.Text = "Two Textbox (test the \"go forward\" option)";
			this.ButtonTwoTextbox.UseVisualStyleBackColor = true;
			this.ButtonTwoTextbox.Click += new System.EventHandler(this.ButtonTwoTextbox_Click);
			// 
			// ButtonSubSubPage
			// 
			this.ButtonSubSubPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonSubSubPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSubSubPage.Location = new System.Drawing.Point(12, 253);
			this.ButtonSubSubPage.Name = "ButtonSubSubPage";
			this.ButtonSubSubPage.Size = new System.Drawing.Size(551, 95);
			this.ButtonSubSubPage.TabIndex = 3;
			this.ButtonSubSubPage.Text = "Sub Sub Page (history can store more than one page)";
			this.ButtonSubSubPage.UseVisualStyleBackColor = true;
			this.ButtonSubSubPage.Click += new System.EventHandler(this.ButtonSubSubPage_Click);
			// 
			// ButtonHedgehog
			// 
			this.ButtonHedgehog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonHedgehog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonHedgehog.Location = new System.Drawing.Point(12, 354);
			this.ButtonHedgehog.Name = "ButtonHedgehog";
			this.ButtonHedgehog.Size = new System.Drawing.Size(551, 95);
			this.ButtonHedgehog.TabIndex = 4;
			this.ButtonHedgehog.Text = "Picture Of A Hedgehog (why not?)";
			this.ButtonHedgehog.UseVisualStyleBackColor = true;
			this.ButtonHedgehog.Click += new System.EventHandler(this.ButtonHedgehog_Click);
			// 
			// pMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 495);
			this.Controls.Add(this.ButtonHedgehog);
			this.Controls.Add(this.ButtonSubSubPage);
			this.Controls.Add(this.ButtonTwoTextbox);
			this.Controls.Add(this.ButtonForward);
			this.Controls.Add(this.ButtonTitleMode);
			this.Name = "pMain";
			this.Text = "Main Page";
			this.Load += new System.EventHandler(this.pMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ButtonTitleMode;
		private System.Windows.Forms.Button ButtonForward;
		private System.Windows.Forms.Button ButtonTwoTextbox;
		private System.Windows.Forms.Button ButtonSubSubPage;
		private System.Windows.Forms.Button ButtonHedgehog;
	}
}