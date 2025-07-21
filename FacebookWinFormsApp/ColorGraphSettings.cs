using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public class ColorGraphSettings
    {
        public static void SetSeriesColor(Series i_Series, eGraphType i_GraphType, Color i_BaseColor, int i_NumberOfSlices = 0)
        {
            if (i_GraphType == eGraphType.PieChart)
            {
                Color[] colorPalette = generateColorPalette(i_NumberOfSlices, i_BaseColor);

                for (int i = 0; i < colorPalette.Length; i++)
                {
                    i_Series.Points[i].Color = colorPalette[i];
                }
            }
            else
            {
                i_Series.Color = i_BaseColor;
            }
        }

        private static Color[] generateColorPalette(int i_NumberOfSlices, Color i_BaseColor)
        {
            Color[] palette = new Color[i_NumberOfSlices];

            for (int i = 0; i < i_NumberOfSlices; i++)
            {
                int adjustment = i * 20 - 40;
                palette[i] = adjustColorBrightness(i_BaseColor, adjustment);
            }

            return palette;
        }

        private static Color adjustColorBrightness(Color i_Color, int i_Adjustment)
        {
            int r = Math.Min(Math.Max(i_Color.R + i_Adjustment, 0), 255);
            int g = Math.Min(Math.Max(i_Color.G + i_Adjustment, 0), 255);
            int b = Math.Min(Math.Max(i_Color.B + i_Adjustment, 0), 255);

            return Color.FromArgb(r, g, b);
        }
    }
}