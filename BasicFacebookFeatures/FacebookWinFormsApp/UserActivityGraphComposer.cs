using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
	public class UserActivityGraphComposer
	{
		private UserActivityGraphBuilder m_Builder;

		public UserActivityGraphComposer(UserActivityGraphBuilder i_Builder)
		{
			m_Builder = i_Builder;
		}

		public Chart ConstructGraph(
			eGraphType i_GraphType,
			string i_XAxisTitle, 
			string i_YAxisTitle, 
			Color i_GraphColor, 
			Dictionary<DateTime, int> i_Data, 
			string i_DisplayType)
		{
			Chart chart = m_Builder.GetChart(i_Data, i_GraphType, i_XAxisTitle, i_YAxisTitle, i_GraphColor, i_DisplayType);

			return chart;
		}
	}
}