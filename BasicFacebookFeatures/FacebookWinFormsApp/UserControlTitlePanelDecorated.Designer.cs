namespace BasicFacebookFeatures
{
	partial class UserControlTitlePanelDecorated
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelInner = new System.Windows.Forms.Label();
			this.panelCoreLabel = new System.Windows.Forms.Panel();
			this.panelCoreLabel.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelInner
			// 
			this.labelInner.AutoSize = true;
			this.labelInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInner.ForeColor = System.Drawing.SystemColors.Control;
			this.labelInner.Location = new System.Drawing.Point(54, 34);
			this.labelInner.Name = "labelInner";
			this.labelInner.Size = new System.Drawing.Size(140, 29);
			this.labelInner.TabIndex = 0;
			this.labelInner.Text = "Hello World";
			this.labelInner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelCoreLabel
			// 
			this.panelCoreLabel.BackColor = System.Drawing.Color.Navy;
			this.panelCoreLabel.Controls.Add(this.labelInner);
			this.panelCoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelCoreLabel.Location = new System.Drawing.Point(0, 0);
			this.panelCoreLabel.Name = "panelCoreLabel";
			this.panelCoreLabel.Size = new System.Drawing.Size(198, 85);
			this.panelCoreLabel.TabIndex = 1;
			// 
			// UserControlLabelCore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelCoreLabel);
			this.Name = "UserControlLabelCore";
			this.Size = new System.Drawing.Size(198, 85);
			this.panelCoreLabel.ResumeLayout(false);
			this.panelCoreLabel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelInner;
		private System.Windows.Forms.Panel panelCoreLabel;
	}
}
