namespace PageEnginePOC
{
	partial class pTitleMode
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.BackButton = new System.Windows.Forms.Button();
			this.ButtonMainAndPage = new System.Windows.Forms.Button();
			this.ButtonMainOnly = new System.Windows.Forms.Button();
			this.ButtonPageOnly = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BackButton
			// 
			this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackButton.Location = new System.Drawing.Point(12, 12);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(53, 33);
			this.BackButton.TabIndex = 0;
			this.BackButton.Text = "<--";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// ButtonMainAndPage
			// 
			this.ButtonMainAndPage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonMainAndPage.Location = new System.Drawing.Point(206, 132);
			this.ButtonMainAndPage.Name = "ButtonMainAndPage";
			this.ButtonMainAndPage.Size = new System.Drawing.Size(219, 33);
			this.ButtonMainAndPage.TabIndex = 1;
			this.ButtonMainAndPage.Text = "Main And Page";
			this.ButtonMainAndPage.UseVisualStyleBackColor = true;
			this.ButtonMainAndPage.Click += new System.EventHandler(this.ButtonMainAndPage_Click);
			// 
			// ButtonMainOnly
			// 
			this.ButtonMainOnly.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonMainOnly.Location = new System.Drawing.Point(206, 171);
			this.ButtonMainOnly.Name = "ButtonMainOnly";
			this.ButtonMainOnly.Size = new System.Drawing.Size(219, 33);
			this.ButtonMainOnly.TabIndex = 2;
			this.ButtonMainOnly.Text = "Main Only";
			this.ButtonMainOnly.UseVisualStyleBackColor = true;
			this.ButtonMainOnly.Click += new System.EventHandler(this.ButtonMainOnly_Click);
			// 
			// ButtonPageOnly
			// 
			this.ButtonPageOnly.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonPageOnly.Location = new System.Drawing.Point(206, 210);
			this.ButtonPageOnly.Name = "ButtonPageOnly";
			this.ButtonPageOnly.Size = new System.Drawing.Size(219, 33);
			this.ButtonPageOnly.TabIndex = 3;
			this.ButtonPageOnly.Text = "Page Only";
			this.ButtonPageOnly.UseVisualStyleBackColor = true;
			this.ButtonPageOnly.Click += new System.EventHandler(this.ButtonPageOnly_Click);
			// 
			// pTitleMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 410);
			this.Controls.Add(this.ButtonPageOnly);
			this.Controls.Add(this.ButtonMainOnly);
			this.Controls.Add(this.ButtonMainAndPage);
			this.Controls.Add(this.BackButton);
			this.Name = "pTitleMode";
			this.Text = "Title Mode";
			this.Load += new System.EventHandler(this.pTitleMode_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Button ButtonMainAndPage;
		private System.Windows.Forms.Button ButtonMainOnly;
		private System.Windows.Forms.Button ButtonPageOnly;
	}
}

