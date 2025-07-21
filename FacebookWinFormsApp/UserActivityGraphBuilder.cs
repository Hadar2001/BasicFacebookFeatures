using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
	public class UserActivityGraphBuilder
	{
		public UserActivityGraphBuilder(){}

		private void setGraphType(Series i_Series, eGraphType i_GraphType)
		{
			switch (i_GraphType)
			{
				case eGraphType.BarChart:
					i_Series.ChartType = SeriesChartType.Column;
					break;
				case eGraphType.LineChart:
					i_Series.ChartType = SeriesChartType.Line;
					break;
				case eGraphType.PieChart:
					i_Series.ChartType = SeriesChartType.Pie;
					break;
				default:
					i_Series.ChartType = SeriesChartType.Column;
					break;
			}
		}

		private Dictionary<DateTime, double> convertToDisplayType(Dictionary<DateTime, int> i_Data, string i_DisplayType)
		{
			int total = i_Data.Values.Sum();
			Dictionary<DateTime, double> convertedData = new Dictionary<DateTime, double>();

			foreach (var entry in i_Data.OrderBy(e => e.Key))
			{
				double value = entry.Value;

				if (i_DisplayType == "Percent" && total > 0)
				{
					value = (entry.Value / (double)total) * 100;
				}

				convertedData.Add(entry.Key, value);
			}

			return convertedData;
		}

		private void setAxisTitles(ChartArea i_ChartArea, string i_XAxisTitle, string i_YAxisTitle)
		{
			i_ChartArea.AxisX.Title = i_XAxisTitle;
			i_ChartArea.AxisY.Title = i_YAxisTitle;
		}

		public Chart GetChart(Dictionary<DateTime, int> i_Data, eGraphType i_GraphType, string i_XAxisTitle, string i_YAxisTitle, Color i_Color, string i_DisplayType)
		{
			Chart chart = new Chart();
			Series series = new Series();
			ChartArea chartArea = new ChartArea("MainArea");
			Dictionary<DateTime, double> convertedData = convertToDisplayType(i_Data, i_DisplayType);

			foreach (var activityEntry in convertedData)
			{
				double activityValue = activityEntry.Value;
				string formattedLabel = (i_DisplayType == "Percent") ? activityValue.ToString("0.00") + "%" : activityValue.ToString();
				series.Points.AddXY(activityEntry.Key.ToShortDateString(), activityValue);
				series.Points[series.Points.Count - 1].Label = formattedLabel;
			}

			ColorGraphSettings.SetSeriesColor(series, i_GraphType, i_Color, i_Data.Count);			
			setGraphType(series, i_GraphType);
			setAxisTitles(chartArea, i_XAxisTitle, i_YAxisTitle);
			chart.ChartAreas.Add(chartArea);
			chart.Series.Add(series);
				
			return chart;
		}
	}
}