using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
	public static class MenuItemUIFactory
	{
		public static Button CreateMenuButton(MenuItem i_MenuItem)
		{
			Button button = new Button
			{
				Text = i_MenuItem.Name,
				Size = new System.Drawing.Size(180, 45),
				Font = new System.Drawing.Font("Times New Roman", 18, System.Drawing.FontStyle.Bold),
				ForeColor = System.Drawing.Color.Black
			};

			button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			button.Click += (s, e) => i_MenuItem.ExecuteAction();

			return button;
		}
	}
}