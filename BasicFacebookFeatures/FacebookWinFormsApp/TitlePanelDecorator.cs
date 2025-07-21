using System.Windows.Forms;

namespace BasicFacebookFeatures
{
	internal class TitlePanelDecorator : ITitlePanelDecorator
	{
		protected readonly ITitlePanelDecorator r_InnerDecorator;		

		protected TitlePanelDecorator(ITitlePanelDecorator i_LabelDecorator)
		{
			r_InnerDecorator = i_LabelDecorator;
		}

		public virtual void ExecuteDecoration()
		{	
			r_InnerDecorator.ExecuteDecoration();
		}

		public virtual void StopDecoration()
		{
			r_InnerDecorator.StopDecoration();
		}

		public Control GetDecoratedControl()
		{
			return r_InnerDecorator.GetDecoratedControl();
		}		
	}
}
