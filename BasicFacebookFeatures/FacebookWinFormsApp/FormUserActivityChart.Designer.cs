namespace BasicFacebookFeatures
{
	partial class FormUserActivityChart
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
			this.label1 = new System.Windows.Forms.Label();
			this.ComboBoxCatagories = new System.Windows.Forms.ComboBox();
			this.ComboBoxTimeRange = new System.Windows.Forms.ComboBox();
			this.buttonShowChart = new System.Windows.Forms.Button();
			this.comboBoxTypeOfGraph = new System.Windows.Forms.ComboBox();
			this.panelGraphSettings = new System.Windows.Forms.Panel();
			this.textBoxTitleX = new System.Windows.Forms.TextBox();
			this.textBoxTitleY = new System.Windows.Forms.TextBox();
			this.buttonGraphColor = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panelActivityChart = new System.Windows.Forms.Panel();
			this.comboBoxDisplayType = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.panelGraphSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(691, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(369, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "Your Last Activities:";
			// 
			// ComboBoxCatagories
			// 
			this.ComboBoxCatagories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxCatagories.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.ComboBoxCatagories.FormattingEnabled = true;
			this.ComboBoxCatagories.Location = new System.Drawing.Point(1059, 132);
			this.ComboBoxCatagories.Name = "ComboBoxCatagories";
			this.ComboBoxCatagories.Size = new System.Drawing.Size(174, 33);
			this.ComboBoxCatagories.TabIndex = 2;
			// 
			// ComboBoxTimeRange
			// 
			this.ComboBoxTimeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxTimeRange.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboBoxTimeRange.FormattingEnabled = true;
			this.ComboBoxTimeRange.Location = new System.Drawing.Point(879, 132);
			this.ComboBoxTimeRange.Name = "ComboBoxTimeRange";
			this.ComboBoxTimeRange.Size = new System.Drawing.Size(174, 33);
			this.ComboBoxTimeRange.TabIndex = 3;
			// 
			// buttonShowChart
			// 
			this.buttonShowChart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonShowChart.ForeColor = System.Drawing.Color.Navy;
			this.buttonShowChart.Location = new System.Drawing.Point(746, 202);
			this.buttonShowChart.Name = "buttonShowChart";
			this.buttonShowChart.Size = new System.Drawing.Size(285, 46);
			this.buttonShowChart.TabIndex = 4;
			this.buttonShowChart.Text = "Show My Activity";
			this.buttonShowChart.UseVisualStyleBackColor = true;
			this.buttonShowChart.Click += new System.EventHandler(this.buttonShowChart_Click);
			// 
			// comboBoxTypeOfGraph
			// 
			this.comboBoxTypeOfGraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTypeOfGraph.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
			this.comboBoxTypeOfGraph.FormattingEnabled = true;
			this.comboBoxTypeOfGraph.Location = new System.Drawing.Point(699, 132);
			this.comboBoxTypeOfGraph.Name = "comboBoxTypeOfGraph";
			this.comboBoxTypeOfGraph.Size = new System.Drawing.Size(174, 33);
			this.comboBoxTypeOfGraph.TabIndex = 5;
			// 
			// panelGraphSettings
			// 
			this.panelGraphSettings.Controls.Add(this.textBoxTitleX);
			this.panelGraphSettings.Controls.Add(this.textBoxTitleY);
			this.panelGraphSettings.Controls.Add(this.buttonGraphColor);
			this.panelGraphSettings.Controls.Add(this.label2);
			this.panelGraphSettings.Location = new System.Drawing.Point(0, 12);
			this.panelGraphSettings.Name = "panelGraphSettings";
			this.panelGraphSettings.Size = new System.Drawing.Size(389, 363);
			this.panelGraphSettings.TabIndex = 6;
			// 
			// textBoxTitleX
			// 
			this.textBoxTitleX.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
			this.textBoxTitleX.Location = new System.Drawing.Point(66, 179);
			this.textBoxTitleX.Name = "textBoxTitleX";
			this.textBoxTitleX.Size = new System.Drawing.Size(295, 39);
			this.textBoxTitleX.TabIndex = 9;
			this.textBoxTitleX.Text = "Enter X-Axis Title";
			this.textBoxTitleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBoxTitleY
			// 
			this.textBoxTitleY.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
			this.textBoxTitleY.Location = new System.Drawing.Point(66, 240);
			this.textBoxTitleY.Name = "textBoxTitleY";
			this.textBoxTitleY.Size = new System.Drawing.Size(295, 39);
			this.textBoxTitleY.TabIndex = 8;
			this.textBoxTitleY.Text = "Enter Y-Axis Title";
			this.textBoxTitleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonGraphColor
			// 
			this.buttonGraphColor.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonGraphColor.Location = new System.Drawing.Point(66, 119);
			this.buttonGraphColor.Name = "buttonGraphColor";
			this.buttonGraphColor.Size = new System.Drawing.Size(295, 44);
			this.buttonGraphColor.TabIndex = 7;
			this.buttonGraphColor.Text = "Pick a graph color";
			this.buttonGraphColor.UseVisualStyleBackColor = true;
			this.buttonGraphColor.Click += new System.EventHandler(this.buttonGraphColor_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(3, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(376, 35);
			this.label2.TabIndex = 0;
			this.label2.Text = "User Activity Graph Settings";
			// 
			// panelActivityChart
			// 
			this.panelActivityChart.Location = new System.Drawing.Point(514, 260);
			this.panelActivityChart.Name = "panelActivityChart";
			this.panelActivityChart.Size = new System.Drawing.Size(746, 499);
			this.panelActivityChart.TabIndex = 7;
			// 
			// comboBoxDisplayType
			// 
			this.comboBoxDisplayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDisplayType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
			this.comboBoxDisplayType.FormattingEnabled = true;
			this.comboBoxDisplayType.Location = new System.Drawing.Point(519, 132);
			this.comboBoxDisplayType.Name = "comboBoxDisplayType";
			this.comboBoxDisplayType.Size = new System.Drawing.Size(174, 33);
			this.comboBoxDisplayType.TabIndex = 9;
			// 
			// flowLayoutPanelMenu
			// 
			this.flowLayoutPanelMenu.AutoScroll = true;
			this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 762);
			this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
			this.flowLayoutPanelMenu.Size = new System.Drawing.Size(1407, 93);
			this.flowLayoutPanelMenu.TabIndex = 10;
			// 
			// FormUserActivityChart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1407, 855);
			this.Controls.Add(this.flowLayoutPanelMenu);
			this.Controls.Add(this.comboBoxDisplayType);
			this.Controls.Add(this.panelActivityChart);
			this.Controls.Add(this.panelGraphSettings);
			this.Controls.Add(this.comboBoxTypeOfGraph);
			this.Controls.Add(this.buttonShowChart);
			this.Controls.Add(this.ComboBoxTimeRange);
			this.Controls.Add(this.ComboBoxCatagories);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormUserActivityChart";
			this.Text = "Facebook Activity Viewer\n\n";
			this.panelGraphSettings.ResumeLayout(false);
			this.panelGraphSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ComboBoxCatagories;
		private System.Windows.Forms.ComboBox ComboBoxTimeRange;
		private System.Windows.Forms.Button buttonShowChart;
		private System.Windows.Forms.ComboBox comboBoxTypeOfGraph;
		private System.Windows.Forms.Panel panelGraphSettings;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonGraphColor;
		private System.Windows.Forms.TextBox textBoxTitleX;
		private System.Windows.Forms.TextBox textBoxTitleY;
		private System.Windows.Forms.Panel panelActivityChart;
		private System.Windows.Forms.ComboBox comboBoxDisplayType;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
	}
}