using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
	//Implements ILabelDecorator interface to allow for decoration of the label core.
	public partial class UserControlTitlePanelDecorated : UserControl, ITitlePanelDecorator 		
	{				
		public Label InnerLabel => labelInner;
	
		public Panel PanelSurrounding => panelCoreLabel;

		public event EventHandler DecorationRequested;

		public event EventHandler DecorationStopRequested;

		public UserControlTitlePanelDecorated()
		{
			InitializeComponent();
		}

		public void RaiseDecorationRequested()
		{
			DecorationRequested?.Invoke(this, EventArgs.Empty);
		}

		public void RaiseDecorationStopRequested()
		{
			DecorationStopRequested?.Invoke(this, EventArgs.Empty);
		}

		public void ExecuteDecoration()
		{
			//Default behaviour - No Animation
		}

		public void StopDecoration()
		{
			//Default behaviour - No Animation to stop
		}

		public Control GetDecoratedControl()
		{
			return this;
		}
	}
}
