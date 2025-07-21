using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMockEvents
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
			this.attendingCountLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.endDateLabel = new System.Windows.Forms.Label();
			this.locationLabel = new System.Windows.Forms.Label();
			this.maybeCountLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.startDateLabel = new System.Windows.Forms.Label();
			this.locationLabel1 = new System.Windows.Forms.Label();
			this.buttonGetEvents = new System.Windows.Forms.Button();
			this.buttonSaveEvents = new System.Windows.Forms.Button();
			this.buttonDuplicateSelectedEvent = new System.Windows.Forms.Button();
			this.buttonDeleteEvent = new System.Windows.Forms.Button();
			this.buttonCreateEvent = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.attendingCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.listEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.locationTextBox = new System.Windows.Forms.TextBox();
			this.maybeCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
			this.userControlSortableListBoxEvents = new BasicFacebookFeatures.UserControlSortableListBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.attendingCountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.listEventsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maybeCountNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
			this.SuspendLayout();
			// 
			// attendingCountLabel
			// 
			this.attendingCountLabel.AutoSize = true;
			this.attendingCountLabel.Location = new System.Drawing.Point(6, 338);
			this.attendingCountLabel.Name = "attendingCountLabel";
			this.attendingCountLabel.Size = new System.Drawing.Size(103, 16);
			this.attendingCountLabel.TabIndex = 0;
			this.attendingCountLabel.Text = "Attending Count:";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(6, 95);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(78, 16);
			this.descriptionLabel.TabIndex = 2;
			this.descriptionLabel.Text = "Description:";
			// 
			// endDateLabel
			// 
			this.endDateLabel.AutoSize = true;
			this.endDateLabel.Location = new System.Drawing.Point(6, 416);
			this.endDateLabel.Name = "endDateLabel";
			this.endDateLabel.Size = new System.Drawing.Size(66, 16);
			this.endDateLabel.TabIndex = 4;
			this.endDateLabel.Text = "End Date:";
			// 
			// locationLabel
			// 
			this.locationLabel.AutoSize = true;
			this.locationLabel.Location = new System.Drawing.Point(6, 266);
			this.locationLabel.Name = "locationLabel";
			this.locationLabel.Size = new System.Drawing.Size(61, 16);
			this.locationLabel.TabIndex = 8;
			this.locationLabel.Text = "Location:";
			// 
			// maybeCountLabel
			// 
			this.maybeCountLabel.AutoSize = true;
			this.maybeCountLabel.Location = new System.Drawing.Point(6, 308);
			this.maybeCountLabel.Name = "maybeCountLabel";
			this.maybeCountLabel.Size = new System.Drawing.Size(89, 16);
			this.maybeCountLabel.TabIndex = 10;
			this.maybeCountLabel.Text = "Maybe Count:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(6, 15);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(47, 16);
			this.nameLabel.TabIndex = 12;
			this.nameLabel.Text = "Name:";
			// 
			// startDateLabel
			// 
			this.startDateLabel.AutoSize = true;
			this.startDateLabel.Location = new System.Drawing.Point(6, 388);
			this.startDateLabel.Name = "startDateLabel";
			this.startDateLabel.Size = new System.Drawing.Size(69, 16);
			this.startDateLabel.TabIndex = 14;
			this.startDateLabel.Text = "Start Date:";
			// 
			// locationLabel1
			// 
			this.locationLabel1.Location = new System.Drawing.Point(0, 0);
			this.locationLabel1.Name = "locationLabel1";
			this.locationLabel1.Size = new System.Drawing.Size(100, 23);
			this.locationLabel1.TabIndex = 0;
			this.locationLabel1.Text = "Location:";
			// 
			// buttonGetEvents
			// 
			this.buttonGetEvents.CausesValidation = false;
			this.buttonGetEvents.Location = new System.Drawing.Point(12, 11);
			this.buttonGetEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonGetEvents.Name = "buttonGetEvents";
			this.buttonGetEvents.Size = new System.Drawing.Size(420, 30);
			this.buttonGetEvents.TabIndex = 0;
			this.buttonGetEvents.Text = "Get Events";
			this.buttonGetEvents.UseVisualStyleBackColor = true;
			this.buttonGetEvents.Click += new System.EventHandler(this.buttonGetEvents_Click);
			// 
			// buttonSaveEvents
			// 
			this.buttonSaveEvents.Location = new System.Drawing.Point(12, 147);
			this.buttonSaveEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSaveEvents.Name = "buttonSaveEvents";
			this.buttonSaveEvents.Size = new System.Drawing.Size(420, 30);
			this.buttonSaveEvents.TabIndex = 4;
			this.buttonSaveEvents.Text = "Save Current State";
			this.buttonSaveEvents.UseVisualStyleBackColor = true;
			this.buttonSaveEvents.Click += new System.EventHandler(this.buttonSaveEvents_Click);
			// 
			// buttonDuplicateSelectedEvent
			// 
			this.buttonDuplicateSelectedEvent.Enabled = false;
			this.buttonDuplicateSelectedEvent.Location = new System.Drawing.Point(12, 113);
			this.buttonDuplicateSelectedEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonDuplicateSelectedEvent.Name = "buttonDuplicateSelectedEvent";
			this.buttonDuplicateSelectedEvent.Size = new System.Drawing.Size(420, 30);
			this.buttonDuplicateSelectedEvent.TabIndex = 59;
			this.buttonDuplicateSelectedEvent.Text = "Duplicate Selected";
			this.buttonDuplicateSelectedEvent.UseVisualStyleBackColor = true;
			this.buttonDuplicateSelectedEvent.Click += new System.EventHandler(this.buttonDuplicateSelectedEvent_Click);
			// 
			// buttonDeleteEvent
			// 
			this.buttonDeleteEvent.Enabled = false;
			this.buttonDeleteEvent.Location = new System.Drawing.Point(12, 79);
			this.buttonDeleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonDeleteEvent.Name = "buttonDeleteEvent";
			this.buttonDeleteEvent.Size = new System.Drawing.Size(420, 30);
			this.buttonDeleteEvent.TabIndex = 63;
			this.buttonDeleteEvent.Text = "Delete Current Selected Event";
			this.buttonDeleteEvent.UseVisualStyleBackColor = true;
			this.buttonDeleteEvent.Click += new System.EventHandler(this.buttonDeleteEvent_Click);
			// 
			// buttonCreateEvent
			// 
			this.buttonCreateEvent.Enabled = false;
			this.buttonCreateEvent.Location = new System.Drawing.Point(12, 45);
			this.buttonCreateEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCreateEvent.Name = "buttonCreateEvent";
			this.buttonCreateEvent.Size = new System.Drawing.Size(420, 30);
			this.buttonCreateEvent.TabIndex = 64;
			this.buttonCreateEvent.Text = "Create New Event";
			this.buttonCreateEvent.UseVisualStyleBackColor = true;
			this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.attendingCountLabel);
			this.panel1.Controls.Add(this.attendingCountNumericUpDown);
			this.panel1.Controls.Add(this.descriptionLabel);
			this.panel1.Controls.Add(this.descriptionTextBox);
			this.panel1.Controls.Add(this.endDateLabel);
			this.panel1.Controls.Add(this.endDateDateTimePicker);
			this.panel1.Controls.Add(this.locationLabel);
			this.panel1.Controls.Add(this.locationTextBox);
			this.panel1.Controls.Add(this.maybeCountLabel);
			this.panel1.Controls.Add(this.maybeCountNumericUpDown);
			this.panel1.Controls.Add(this.nameLabel);
			this.panel1.Controls.Add(this.nameTextBox);
			this.panel1.Controls.Add(this.startDateLabel);
			this.panel1.Controls.Add(this.startDateDateTimePicker);
			this.panel1.Location = new System.Drawing.Point(455, 191);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 463);
			this.panel1.TabIndex = 67;
			// 
			// attendingCountNumericUpDown
			// 
			this.attendingCountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listEventsBindingSource, "AttendingCount", true));
			this.attendingCountNumericUpDown.Location = new System.Drawing.Point(115, 336);
			this.attendingCountNumericUpDown.Name = "attendingCountNumericUpDown";
			this.attendingCountNumericUpDown.Size = new System.Drawing.Size(137, 22);
			this.attendingCountNumericUpDown.TabIndex = 1;
			this.attendingCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listEventsBindingSource
			// 
			this.listEventsBindingSource.DataSource = typeof(BasicFacebookFeatures.MockEvent);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listEventsBindingSource, "Description", true));
			this.descriptionTextBox.Location = new System.Drawing.Point(9, 114);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(306, 143);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// endDateDateTimePicker
			// 
			this.endDateDateTimePicker.CustomFormat = "dd MMM yyyy hh:mm tt";
			this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listEventsBindingSource, "EndDate", true));
			this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.endDateDateTimePicker.Location = new System.Drawing.Point(81, 412);
			this.endDateDateTimePicker.Name = "endDateDateTimePicker";
			this.endDateDateTimePicker.Size = new System.Drawing.Size(234, 22);
			this.endDateDateTimePicker.TabIndex = 5;
			this.endDateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.endDateDateTimePicker_Validating);
			// 
			// locationTextBox
			// 
			this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listEventsBindingSource, "Location", true));
			this.locationTextBox.Location = new System.Drawing.Point(81, 263);
			this.locationTextBox.Name = "locationTextBox";
			this.locationTextBox.Size = new System.Drawing.Size(234, 22);
			this.locationTextBox.TabIndex = 9;
			// 
			// maybeCountNumericUpDown
			// 
			this.maybeCountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listEventsBindingSource, "MaybeCount", true));
			this.maybeCountNumericUpDown.Location = new System.Drawing.Point(115, 306);
			this.maybeCountNumericUpDown.Name = "maybeCountNumericUpDown";
			this.maybeCountNumericUpDown.Size = new System.Drawing.Size(137, 22);
			this.maybeCountNumericUpDown.TabIndex = 11;
			this.maybeCountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listEventsBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(9, 34);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(306, 22);
			this.nameTextBox.TabIndex = 13;
			this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
			// 
			// startDateDateTimePicker
			// 
			this.startDateDateTimePicker.CustomFormat = "dd MMM yyyy hh:mm tt";
			this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listEventsBindingSource, "StartDate", true));
			this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.startDateDateTimePicker.Location = new System.Drawing.Point(81, 384);
			this.startDateDateTimePicker.Name = "startDateDateTimePicker";
			this.startDateDateTimePicker.Size = new System.Drawing.Size(234, 22);
			this.startDateDateTimePicker.TabIndex = 15;
			// 
			// pictureBoxEvent
			// 
			this.pictureBoxEvent.Location = new System.Drawing.Point(608, 22);
			this.pictureBoxEvent.Name = "pictureBoxEvent";
			this.pictureBoxEvent.Size = new System.Drawing.Size(196, 154);
			this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxEvent.TabIndex = 68;
			this.pictureBoxEvent.TabStop = false;
			// 
			// userControlSortableListBoxEvents
			// 
			this.userControlSortableListBoxEvents.DataSource = null;
			this.userControlSortableListBoxEvents.DisplayMember = "";
			this.userControlSortableListBoxEvents.Location = new System.Drawing.Point(12, 191);
			this.userControlSortableListBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.userControlSortableListBoxEvents.Name = "userControlSortableListBoxEvents";
			this.userControlSortableListBoxEvents.Size = new System.Drawing.Size(420, 463);
			this.userControlSortableListBoxEvents.TabIndex = 62;
			this.userControlSortableListBoxEvents.Title = "";
			// 
			// FormMockEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 666);
			this.Controls.Add(this.pictureBoxEvent);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonCreateEvent);
			this.Controls.Add(this.buttonDeleteEvent);
			this.Controls.Add(this.userControlSortableListBoxEvents);
			this.Controls.Add(this.buttonDuplicateSelectedEvent);
			this.Controls.Add(this.buttonSaveEvents);
			this.Controls.Add(this.buttonGetEvents);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormMockEvents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMockEvents";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.attendingCountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.listEventsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maybeCountNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGetEvents;
        private System.Windows.Forms.Button buttonSaveEvents;
        private System.Windows.Forms.Button buttonDuplicateSelectedEvent;
        private System.Windows.Forms.Label locationLabel1;
        private UserControlSortableListBox userControlSortableListBoxEvents;
        private System.Windows.Forms.Button buttonDeleteEvent;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.BindingSource listEventsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown attendingCountNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.NumericUpDown maybeCountNumericUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
		private Label attendingCountLabel;
		private Label descriptionLabel;
		private Label endDateLabel;
		private Label locationLabel;
		private Label maybeCountLabel;
		private Label nameLabel;
		private Label startDateLabel;
		private PictureBox pictureBoxEvent;
	}
}
