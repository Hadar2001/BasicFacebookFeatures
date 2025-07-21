using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class Menu
    {
        private readonly List<MenuItem> r_MenuItemsList;
		
        public event Action<MenuItem> MenuItemAdded;

		public string Title { get; }

		public Menu(string i_MenuTitle)
        {
            Title = i_MenuTitle;
            r_MenuItemsList = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItemsList.Add(i_MenuItem);
            MenuItemAdded?.Invoke(i_MenuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return r_MenuItemsList;
        }
    }
}