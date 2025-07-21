using System.Windows.Forms;

namespace BasicFacebookFeatures
{
	public static class MenuRenderer
	{
		public static void Render(Menu i_Menu, FlowLayoutPanel i_Panel)
		{
			i_Panel.Controls.Clear();

			foreach (MenuItem item in i_Menu.GetMenuItems())
			{
				i_Panel.Controls.Add(MenuItemUIFactory.CreateMenuButton(item));
			}
		}
	}
}