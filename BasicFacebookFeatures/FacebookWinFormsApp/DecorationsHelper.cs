using System;

namespace BasicFacebookFeatures
{
	public static class DecorationsHelper
	{
		public static void SetUpDecoration(
			UserControlSortableListBox i_SortableListBox,
			ITitlePanelDecorator i_Decorator,
			Action<UserControlTitlePanelDecorated> i_AttachStartTrigger,
			Action<UserControlTitlePanelDecorated> i_AttachStopTrigger)
		{
			UserControlTitlePanelDecorated titleCore;

			i_SortableListBox.TitlePanelDecorator = i_Decorator;
			titleCore = i_SortableListBox.UserControlLabelCoreTitle;
			i_AttachStartTrigger(titleCore);
			i_AttachStopTrigger(titleCore);
			titleCore.DecorationRequested += (s, e) => i_Decorator.ExecuteDecoration();
			titleCore.DecorationStopRequested += (s, e) => i_Decorator.StopDecoration();
		}
	}
}
