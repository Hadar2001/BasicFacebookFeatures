using System;

namespace BasicFacebookFeatures
{
	public class MenuItem
	{
		private string m_Name;
		private Action m_Action;

		public string Name
		{
			get { return m_Name; }
			set { m_Name = value; }
		}

		public MenuItem(string i_Name, Action i_Action)
		{
			Name = i_Name;
			m_Action = i_Action;
		}

		public void ExecuteAction()
		{
			m_Action?.Invoke();
		}
	}
}