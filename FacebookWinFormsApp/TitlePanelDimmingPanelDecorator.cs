using System;
using System.Windows.Forms;
using System.Drawing;


namespace BasicFacebookFeatures
{
	internal class TitlePanelDimmingPanelDecorator : TitlePanelDecorator
	{
		private readonly Timer r_DimmingTimer;
		private bool m_IsDimming = true;

		public TitlePanelDimmingPanelDecorator(ITitlePanelDecorator i_InnerDecorator) : base(i_InnerDecorator)
		{
			r_DimmingTimer = new Timer();
			r_DimmingTimer.Interval = 10; 
			r_DimmingTimer.Tick += r_DimmingTimer_Tick; 			
		}

		private void r_DimmingTimer_Tick(object sender, EventArgs e)
		{
			UserControlTitlePanelDecorated decoratedPanel = GetDecoratedControl() as UserControlTitlePanelDecorated;
				decoratedPanel.PanelSurrounding.BackColor = getNewColor(decoratedPanel.PanelSurrounding.BackColor);
		}

		private Color getNewColor(Color i_Color)
		{
			Color newColor = Color.Empty;
			int newR = i_Color.R;
			int newG = i_Color.G;
			int newB = i_Color.B ;
			int prevR = i_Color.R;
			int prevG = i_Color.G;
			int prevB = i_Color.B;
			int diff = 0;

			if (prevR >= 255 || prevG >= 255 || prevB >= 255)
			{
				m_IsDimming = true;
			}

			if (prevR <= 0 || prevG <= 0 || prevB <= 0)
			{
				m_IsDimming = false;
			}

			diff = m_IsDimming ? -1 : 1;
			newR = Math.Min(255, Math.Max(0, prevR + diff));
			newG = Math.Min(255, Math.Max(0, prevG + diff));
			newB = Math.Min(255, Math.Max(0, prevB + diff));			
			newColor = Color.FromArgb(255, newR, newG, newB);

			return newColor;
		}

		public override void ExecuteDecoration()
		{
			r_InnerDecorator.ExecuteDecoration();
			r_DimmingTimer.Start();
		}

		public override void StopDecoration()
		{
			r_InnerDecorator.StopDecoration();
			r_DimmingTimer.Stop();		
		}		
	}
}
