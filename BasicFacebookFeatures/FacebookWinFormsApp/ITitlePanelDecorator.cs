using System.Windows.Forms;

namespace BasicFacebookFeatures
{
	public interface ITitlePanelDecorator
	{
		void ExecuteDecoration();

		void StopDecoration();

		Control GetDecoratedControl();
	}
}
