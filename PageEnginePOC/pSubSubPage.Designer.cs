namespace PageEnginePOC
{
	partial class pSubSubPage
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
			this.BackButton = new System.Windows.Forms.Button();
			this.ButtonForward = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonTwoTextbox = new System.Windows.Forms.Button();
			this.ButtonInfiniteSubSub = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BackButton
			// 
			this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackButton.Location = new System.Drawing.Point(12, 12);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(53, 33);
			this.BackButton.TabIndex = 2;
			this.BackButton.Text = "<--";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// ButtonForward
			// 
			this.ButtonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonForward.Location = new System.Drawing.Point(550, 12);
			this.ButtonForward.Name = "ButtonForward";
			this.ButtonForward.Size = new System.Drawing.Size(53, 33);
			this.ButtonForward.TabIndex = 3;
			this.ButtonForward.Text = "-->";
			this.ButtonForward.UseVisualStyleBackColor = true;
			this.ButtonForward.Click += new System.EventHandler(this.ButtonForward_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.ButtonTwoTextbox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ButtonInfiniteSubSub, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 51);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 430);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// ButtonTwoTextbox
			// 
			this.ButtonTwoTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonTwoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonTwoTextbox.Location = new System.Drawing.Point(3, 3);
			this.ButtonTwoTextbox.Name = "ButtonTwoTextbox";
			this.ButtonTwoTextbox.Size = new System.Drawing.Size(585, 137);
			this.ButtonTwoTextbox.TabIndex = 0;
			this.ButtonTwoTextbox.Text = "Two Textbox (again)";
			this.ButtonTwoTextbox.UseVisualStyleBackColor = true;
			this.ButtonTwoTextbox.Click += new System.EventHandler(this.ButtonTwoTextbox_Click);
			// 
			// ButtonInfiniteSubSub
			// 
			this.ButtonInfiniteSubSub.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonInfiniteSubSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonInfiniteSubSub.Location = new System.Drawing.Point(3, 146);
			this.ButtonInfiniteSubSub.Name = "ButtonInfiniteSubSub";
			this.ButtonInfiniteSubSub.Size = new System.Drawing.Size(585, 137);
			this.ButtonInfiniteSubSub.TabIndex = 1;
			this.ButtonInfiniteSubSub.Text = "Infinite Sub Page (there\'s a textbox at the top of the page)";
			this.ButtonInfiniteSubSub.UseVisualStyleBackColor = true;
			this.ButtonInfiniteSubSub.Click += new System.EventHandler(this.ButtonInfiniteSubSub_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(71, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(335, 20);
			this.textBox1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 286);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "a useless space";
			// 
			// pSubSubPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 493);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.ButtonForward);
			this.Controls.Add(this.BackButton);
			this.Name = "pSubSubPage";
			this.Text = "Choose An Other Page";
			this.Load += new System.EventHandler(this.pSubSubPage_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Button ButtonForward;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button ButtonTwoTextbox;
		private System.Windows.Forms.Button ButtonInfiniteSubSub;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}