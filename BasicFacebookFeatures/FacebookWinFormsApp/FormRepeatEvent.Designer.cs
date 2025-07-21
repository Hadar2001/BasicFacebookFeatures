namespace BasicFacebookFeatures
{
    partial class FormRepeatEvent
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
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownRepetitions = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitions)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.Location = new System.Drawing.Point(161, 138);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(132, 38);
			this.buttonConfirm.TabIndex = 0;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = true;
			this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(302, 138);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(132, 38);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_CLick);
			// 
			// numericUpDownDays
			// 
			this.numericUpDownDays.Location = new System.Drawing.Point(161, 24);
			this.numericUpDownDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numericUpDownDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownDays.Name = "numericUpDownDays";
			this.numericUpDownDays.Size = new System.Drawing.Size(89, 22);
			this.numericUpDownDays.TabIndex = 2;
			this.numericUpDownDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Repeat Every:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(272, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Days";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Number of Repetitions:";
			// 
			// numericUpDownRepetitions
			// 
			this.numericUpDownRepetitions.Location = new System.Drawing.Point(161, 61);
			this.numericUpDownRepetitions.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownRepetitions.Name = "numericUpDownRepetitions";
			this.numericUpDownRepetitions.Size = new System.Drawing.Size(89, 22);
			this.numericUpDownRepetitions.TabIndex = 6;
			this.numericUpDownRepetitions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(272, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "(minimum 1 - maximum 50)";
			// 
			// FormRepeatEvent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 207);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDownRepetitions);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownDays);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConfirm);
			this.Name = "FormRepeatEvent";
			this.Text = "Duplicate Event Form";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepetitions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRepetitions;
        private System.Windows.Forms.Label label4;
    }
}
