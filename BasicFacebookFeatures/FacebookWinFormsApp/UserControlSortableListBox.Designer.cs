namespace BasicFacebookFeatures
{
    partial class UserControlSortableListBox
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
			this.tableLayoutPanelOrganizer = new System.Windows.Forms.TableLayoutPanel();
			this.panelSorting = new System.Windows.Forms.Panel();
			this.listBoxItems = new System.Windows.Forms.ListBox();
			this.userControlLabelCoreTitle = new BasicFacebookFeatures.UserControlTitlePanelDecorated();
			this.tableLayoutPanelOrganizer.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelOrganizer
			// 
			this.tableLayoutPanelOrganizer.ColumnCount = 1;
			this.tableLayoutPanelOrganizer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelOrganizer.Controls.Add(this.panelSorting, 0, 2);
			this.tableLayoutPanelOrganizer.Controls.Add(this.listBoxItems, 0, 1);
			this.tableLayoutPanelOrganizer.Controls.Add(this.userControlLabelCoreTitle, 0, 0);
			this.tableLayoutPanelOrganizer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelOrganizer.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelOrganizer.Name = "tableLayoutPanelOrganizer";
			this.tableLayoutPanelOrganizer.RowCount = 3;
			this.tableLayoutPanelOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelOrganizer.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelOrganizer.Size = new System.Drawing.Size(445, 466);
			this.tableLayoutPanelOrganizer.TabIndex = 4;
			// 
			// panelSorting
			// 
			this.panelSorting.BackColor = System.Drawing.Color.Navy;
			this.panelSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelSorting.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.panelSorting.Location = new System.Drawing.Point(3, 345);
			this.panelSorting.Name = "panelSorting";
			this.panelSorting.Size = new System.Drawing.Size(439, 118);
			this.panelSorting.TabIndex = 5;
			// 
			// listBoxItems
			// 
			this.listBoxItems.BackColor = System.Drawing.SystemColors.Menu;
			this.listBoxItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxItems.FormattingEnabled = true;
			this.listBoxItems.HorizontalScrollbar = true;
			this.listBoxItems.ItemHeight = 16;
			this.listBoxItems.Location = new System.Drawing.Point(0, 103);
			this.listBoxItems.Margin = new System.Windows.Forms.Padding(0);
			this.listBoxItems.Name = "listBoxItems";
			this.listBoxItems.Size = new System.Drawing.Size(445, 239);
			this.listBoxItems.TabIndex = 7;
			this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listboxItems_SelectedIndexChanged);
			// 
			// userControlLabelCoreTitle
			// 
			this.userControlLabelCoreTitle.BackColor = System.Drawing.Color.Navy;
			this.userControlLabelCoreTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.userControlLabelCoreTitle.Location = new System.Drawing.Point(3, 3);
			this.userControlLabelCoreTitle.Name = "userControlLabelCoreTitle";
			this.userControlLabelCoreTitle.Size = new System.Drawing.Size(439, 97);
			this.userControlLabelCoreTitle.TabIndex = 8;
			// 
			// UserControlSortableListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelOrganizer);
			this.Name = "UserControlSortableListBox";
			this.Size = new System.Drawing.Size(445, 466);
			this.tableLayoutPanelOrganizer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrganizer;
        private System.Windows.Forms.Panel panelSorting;
        private System.Windows.Forms.ListBox listBoxItems;
		private UserControlTitlePanelDecorated userControlLabelCoreTitle;
	}
}
