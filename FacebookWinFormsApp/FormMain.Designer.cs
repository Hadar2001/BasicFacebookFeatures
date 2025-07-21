namespace BasicFacebookFeatures
{
    partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
			this.labelWelcome = new System.Windows.Forms.Label();
			this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
			this.textBoxAppID = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.buttonPosts = new System.Windows.Forms.Button();
			this.listBoxPosts = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxLike = new System.Windows.Forms.PictureBox();
			this.mockEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mockEventBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.Location = new System.Drawing.Point(26, 310);
			this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(268, 48);
			this.buttonLogin.TabIndex = 36;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonLogout
			// 
			this.buttonLogout.Enabled = false;
			this.buttonLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogout.Location = new System.Drawing.Point(26, 381);
			this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(268, 44);
			this.buttonLogout.TabIndex = 52;
			this.buttonLogout.Text = "Logout";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 111);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(876, 50);
			this.label1.TabIndex = 53;
			this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\". The grader will use it to test yo" +
    "ur app.\r\nType here your own AppID to test it:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1243, 697);
			this.tabControl1.TabIndex = 54;
			// 
			// tabPage1
			// 
			this.tabPage1.AutoScroll = true;
			this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tabPage1.Controls.Add(this.pictureBoxFacebookLogo);
			this.tabPage1.Controls.Add(this.labelWelcome);
			this.tabPage1.Controls.Add(this.pictureBoxProfile);
			this.tabPage1.Controls.Add(this.textBoxAppID);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.buttonLogout);
			this.tabPage1.Controls.Add(this.buttonLogin);
			this.tabPage1.Location = new System.Drawing.Point(4, 31);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1235, 662);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// pictureBoxFacebookLogo
			// 
			this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(175, 26);
			this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
			this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(71, 68);
			this.pictureBoxFacebookLogo.TabIndex = 55;
			this.pictureBoxFacebookLogo.TabStop = false;
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
			this.labelWelcome.Location = new System.Drawing.Point(252, 26);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(582, 68);
			this.labelWelcome.TabIndex = 56;
			this.labelWelcome.Text = "Welcome to Facebook";
			// 
			// pictureBoxProfile
			// 
			this.pictureBoxProfile.Location = new System.Drawing.Point(356, 293);
			this.pictureBoxProfile.Name = "pictureBoxProfile";
			this.pictureBoxProfile.Size = new System.Drawing.Size(146, 132);
			this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxProfile.TabIndex = 55;
			this.pictureBoxProfile.TabStop = false;
			// 
			// textBoxAppID
			// 
			this.textBoxAppID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAppID.Location = new System.Drawing.Point(26, 211);
			this.textBoxAppID.Name = "textBoxAppID";
			this.textBoxAppID.Size = new System.Drawing.Size(238, 42);
			this.textBoxAppID.TabIndex = 54;
			this.textBoxAppID.Text = "699645029066505";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.buttonPosts);
			this.tabPage2.Controls.Add(this.listBoxPosts);
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.pictureBoxLike);
			this.tabPage2.Location = new System.Drawing.Point(4, 31);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1235, 662);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// buttonPosts
			// 
			this.buttonPosts.Location = new System.Drawing.Point(488, 124);
			this.buttonPosts.Name = "buttonPosts";
			this.buttonPosts.Size = new System.Drawing.Size(186, 46);
			this.buttonPosts.TabIndex = 3;
			this.buttonPosts.Text = "buttonGetPosts";
			this.buttonPosts.UseVisualStyleBackColor = true;
			// 
			// listBoxPosts
			// 
			this.listBoxPosts.FormattingEnabled = true;
			this.listBoxPosts.ItemHeight = 22;
			this.listBoxPosts.Location = new System.Drawing.Point(37, 189);
			this.listBoxPosts.Name = "listBoxPosts";
			this.listBoxPosts.Size = new System.Drawing.Size(452, 202);
			this.listBoxPosts.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(242, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(173, 109);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBoxLike
			// 
			this.pictureBoxLike.Location = new System.Drawing.Point(35, 41);
			this.pictureBoxLike.Name = "pictureBoxLike";
			this.pictureBoxLike.Size = new System.Drawing.Size(131, 103);
			this.pictureBoxLike.TabIndex = 0;
			this.pictureBoxLike.TabStop = false;
			// 
			// mockEventBindingSource
			// 
			this.mockEventBindingSource.DataSource = typeof(BasicFacebookFeatures.MockEvent);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1243, 697);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Facebook App";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLike)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mockEventBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxLike;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.BindingSource mockEventBindingSource;

        //

    }
}
