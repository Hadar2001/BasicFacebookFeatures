using System;
using System.Windows.Forms;


namespace BasicFacebookFeatures
{
	internal class TitlePanelFlashingDecorator : TitlePanelDecorator
	{
		private readonly Timer r_FlashingTimer;
		
		public TitlePanelFlashingDecorator(ITitlePanelDecorator i_InnerDecorator) : base(i_InnerDecorator)
		{
			r_FlashingTimer = new Timer();
			r_FlashingTimer.Interval = 1000; 
			r_FlashingTimer.Tick += onFlashingTimerTick;
		}

		private void onFlashingTimerTick(object sender, EventArgs e)
		{
			UserControlTitlePanelDecorated labelCore = GetDecoratedControl() as UserControlTitlePanelDecorated;
			labelCore.InnerLabel.Visible = !labelCore.InnerLabel.Visible;
		}

		public override void ExecuteDecoration()
		{
			r_InnerDecorator.ExecuteDecoration();
			r_FlashingTimer.Start();
		}

		public override void StopDecoration()
		{
			r_InnerDecorator.StopDecoration();
			r_FlashingTimer.Stop();
		}
	}
}
