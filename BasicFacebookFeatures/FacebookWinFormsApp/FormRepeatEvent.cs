using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormRepeatEvent : Form
    {
        public int Repetitions { get; private set; }

        public int IntervalValue { get; private set; }

        public FormRepeatEvent()
        {
            InitializeComponent();
        }

        private void buttonCancel_CLick(object sender, EventArgs e)
        {
            this.Close();
        }

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Repetitions = (int)numericUpDownRepetitions.Value;
			IntervalValue = (int)numericUpDownDays.Value;
			this.Close();
		}
	}
}
