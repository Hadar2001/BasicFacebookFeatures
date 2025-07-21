using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
	public partial class FormUserActivityChart : Form
	{
		private UserActivitySummary m_UserActivitySummary;
		private UserActivityGraphComposer m_GraphComposer;
		private Color m_GraphColor;
		private Chart m_UserActivityChart;
		private Menu m_MenuCommand;

		public FormUserActivityChart(User i_LoggedInUser)
		{
			InitializeComponent();
			m_UserActivitySummary = new UserActivitySummary(i_LoggedInUser);
			m_GraphComposer = new UserActivityGraphComposer(new UserActivityGraphBuilder());
			initializeCategoryComboBox();
			initializeTimeRangeComboBox();
			initializeGraphType();
			initializeDisplayOptions();
			populateMenu();			
			MenuRenderer.Render(m_MenuCommand, flowLayoutPanelMenu);
		}

		private void initializeCategoryComboBox()
		{
			ComboBoxCatagories.Items.Add("All");
			ComboBoxCatagories.Items.Add("Posts");
			ComboBoxCatagories.Items.Add("Albums");
			ComboBoxCatagories.Items.Add("Events");
			ComboBoxCatagories.SelectedIndex = 0;
		}

		private void initializeTimeRangeComboBox()
		{
			ComboBoxTimeRange.Items.Add("Daily");
			ComboBoxTimeRange.Items.Add("Weekly");
			ComboBoxTimeRange.Items.Add("Monthly");
			ComboBoxTimeRange.SelectedIndex = 1;
		}

		private void initializeGraphType()
		{
			comboBoxTypeOfGraph.Items.Add("Pie Chart");
			comboBoxTypeOfGraph.Items.Add("Bar Chart");
			comboBoxTypeOfGraph.Items.Add("Line Chart");
			comboBoxTypeOfGraph.SelectedIndex = 1;
		}

		private void initializeDisplayOptions()
		{
			comboBoxDisplayType.Items.Add("Percent");
			comboBoxDisplayType.Items.Add("Absolute");
			comboBoxDisplayType.SelectedIndex = 1;
		}

		private void populateMenu()
		{
			m_MenuCommand = new Menu("Command Menu");
			m_MenuCommand.AddMenuItem(new MenuItem("Print Graph", printGraph));
			m_MenuCommand.AddMenuItem(new MenuItem("Save Graph", saveGraph));
			m_MenuCommand.AddMenuItem(new MenuItem("Export to CSV", exportToCsv));
		}

		private void buttonShowChart_Click(object sender, EventArgs e)
		{
			
			string xAxisTitle = textBoxTitleX.Text;
			string yAxisTitle = textBoxTitleY.Text;
			string displayType = comboBoxDisplayType.SelectedItem.ToString();
			eGraphType selectedGraphType = 
				(eGraphType)Enum.Parse(
					typeof(eGraphType), 
					comboBoxTypeOfGraph.SelectedItem.ToString().Replace(" ", ""));

			Dictionary<DateTime, int> summary = getContext();
			m_UserActivityChart = m_GraphComposer.ConstructGraph(selectedGraphType, xAxisTitle, yAxisTitle, m_GraphColor, summary, displayType);
			m_UserActivityChart.Dock = DockStyle.Fill;
			panelActivityChart.Controls.Clear();
			panelActivityChart.Controls.Add(m_UserActivityChart);
		}

		private Dictionary<DateTime, int> getContext()
		{
			eAnalyzerCategory selectedCategory = (eAnalyzerCategory)Enum.Parse(typeof(eAnalyzerCategory), ComboBoxCatagories.SelectedItem.ToString());
			eTimeRangeOptions selectedTimeRange = (eTimeRangeOptions)Enum.Parse(typeof(eTimeRangeOptions), ComboBoxTimeRange.SelectedItem.ToString());
			Dictionary<DateTime, int> summary;

			if (selectedCategory == eAnalyzerCategory.All)
			{
				summary = m_UserActivitySummary.GetAllCategoriesSummary(selectedTimeRange);
			}
			else
			{
				summary = m_UserActivitySummary.GetDataForCategory(selectedCategory, selectedTimeRange);
			}

			return summary;
		}

		private void buttonGraphColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();

			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				m_GraphColor = colorDialog.Color;
			}
		}
		private bool isValidChartToExport()
		{
			return m_UserActivityChart != null &&
			m_UserActivityChart.Series.Count > 0 &&
			m_UserActivityChart.Series.Any(series => series.Points.Count > 0);
		}

		private void saveGraph()
		{
			if (!isValidChartToExport())
			{
				MessageBox.Show("Cannot save. The chart has not been generated or contains no data.",
								"Save Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
			}
			else
			{
				string defaultFileName = getDefaultFileName("png");
				SaveFileDialog dlg = new SaveFileDialog();

				dlg.Filter = "Image|*.png";
				dlg.FileName = defaultFileName;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					Bitmap bmp = new Bitmap(m_UserActivityChart.Width, m_UserActivityChart.Height);
					m_UserActivityChart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
					bmp.Save(dlg.FileName);
				}			
			}
		}

		private void printGraph()
		{
			if (!isValidChartToExport())
			{
				MessageBox.Show("Cannot print. The chart has not been generated or contains no data.",
								"Print Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
			}
			else
			{
				PrintDocument doc = new PrintDocument();
				Bitmap bmp = new Bitmap(m_UserActivityChart.Width, m_UserActivityChart.Height);
				PrintDialog dlg = new PrintDialog { Document = doc };

				m_UserActivityChart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
				doc.PrintPage += (s, e) => e.Graphics.DrawImage(bmp, new Point(100, 100));

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					doc.Print();
				}
			}
		}

		private string getDefaultFileName(string i_Extension)
		{
			string chartType = comboBoxTypeOfGraph.SelectedItem?.ToString() ?? "Chart";
			string timeRange = ComboBoxTimeRange.SelectedItem?.ToString() ?? "TimeRange";
			string category = ComboBoxCatagories.SelectedItem?.ToString() ?? "Category";
			string datePart = DateTime.Now.ToString("dd-MM-yyyy");
			string fileName = $"MyActivity_{category}{chartType}{timeRange}_{datePart}.{i_Extension}";

			return fileName.Replace(" ", "");
		}

		private void exportToCsv()
		{
			if (!isValidChartToExport())
			{
				MessageBox.Show("Cannot export. The chart has not been generated or contains no data.",
								"Export Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning);
				
			}
			else
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Filter = "CSV files (.csv)|.csv";
				dlg.FileName = getDefaultFileName("csv");
				string category = ComboBoxCatagories.SelectedItem.ToString();

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					using (StreamWriter writer = new StreamWriter(dlg.FileName))
					{
						writer.WriteLine($"Category:,{category}");
						writer.WriteLine("Date,ActivityCount");
						foreach (DataPoint point in m_UserActivityChart.Series[0].Points)
						{
							string date = point.AxisLabel;
							int count = (int)point.YValues[0];
							writer.WriteLine($"{date},{count}");
						}
					}

					MessageBox.Show("Export completed successfully!", "Export to CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}			
		}
	}
}