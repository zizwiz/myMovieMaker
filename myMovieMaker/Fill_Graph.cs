using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CenteredMessagebox;


namespace myMovieMaker
{
    public partial class Form1
    {

        private void btn_fill_graph_Click(object sender, EventArgs e)
        {
           FillGraph();
        }


        private void FillGraph()
        {
            // Load data from CSV and plot it
            string filePath = "weather_readings_sept.csv"; // Replace with your CSV file path

            Series series1 = chrt_temperatures.Series.Add("");
            Series series2 = chrt_temperatures.Series.Add("");

            Series series3 = chrt_winds.Series.Add("");
            Series series4 = chrt_winds.Series.Add("");

            Series series5 = chrt_pressure.Series.Add("");
            

            //type of chart
            series1.ChartType = SeriesChartType.FastLine; //not sure why I need this but if not I get bar chart
            series2.ChartType = SeriesChartType.FastLine; //not sure why I need this but if not I get bar chart

            series3.ChartType = SeriesChartType.FastLine; //not sure why I need this but if not I get bar chart
            series4.ChartType = SeriesChartType.FastLine; //not sure why I need this but if not I get bar chart

            series5.ChartType = SeriesChartType.FastLine; //not sure why I need this but if not I get bar chart

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        series1.Points.AddXY(values[0], values[1]);
                        series2.Points.AddXY(values[0], values[2]);

                        series3.Points.AddXY(values[0], values[5]);
                        series4.Points.AddXY(values[0], values[6]);

                        series5.Points.AddXY(values[0], values[7]);
                    }
                }
            }
            else
            {
                MsgBox.Show("CSV file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }





    }
}