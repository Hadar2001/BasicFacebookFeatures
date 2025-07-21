using System;
using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures
{
	internal class TitlePanelMovingTextDecorator : TitlePanelDecorator
	{
		
		private readonly Timer r_Timer;
		private bool m_MovingRight = true;

		public TitlePanelMovingTextDecorator(ITitlePanelDecorator i_LabelDecorator) : base(i_LabelDecorator)
		{
			r_Timer = new Timer();
			r_Timer.Interval = 10; 
			r_Timer.Tick += r_TimerTick_MoveText;
		}

		private void r_TimerTick_MoveText(object sender, EventArgs e)
		{
			UserControlTitlePanelDecorated labelCore = GetDecoratedControl() as UserControlTitlePanelDecorated;
			Point textLocation = labelCore.InnerLabel.Location;

			int leftBound = 0; 
			int rightBound = labelCore.PanelSurrounding.Width - labelCore.InnerLabel.Width;

			if (m_MovingRight)
			{
				textLocation.X += 2;
				if (textLocation.X > rightBound)
				{
					textLocation.X = rightBound;
					m_MovingRight = false; 
				}
			}
			else
			{
				textLocation.X -= 2;
				if (textLocation.X < leftBound)
				{
					textLocation.X = leftBound;
					m_MovingRight = true;
				}
			}

			labelCore.InnerLabel.Location = textLocation;
		}

		public override void ExecuteDecoration()
		{			
			r_InnerDecorator.ExecuteDecoration();
			r_Timer.Start();
		}

		public override void StopDecoration()
		{
			UserControlTitlePanelDecorated labelCore = GetDecoratedControl() as UserControlTitlePanelDecorated;
			Point centerLocation = labelCore.InnerLabel.Location;
			
			r_Timer.Stop();
			centerLocation.X = (labelCore.PanelSurrounding.Width / 2) - (labelCore.InnerLabel.Width / 2);
			labelCore.InnerLabel.Location = centerLocation;
			r_InnerDecorator.StopDecoration();			
		}		
	}
}
