using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CenteredMessagebox;


namespace myMovieMaker
{
    public partial class Form1
    {



        private void FillGraph(string myFilePath)
        {
            Series MaxTemperature = chrt_temperatures.Series.Add("");
            MaxTemperature.Color = Color.Red;
            Series Dewpoint = chrt_temperatures.Series.Add("");
            Dewpoint.Color = Color.Green;

            Series Windspeed = chrt_winds.Series.Add("");
            Windspeed.Color = Color.Blue;
            Series Gustspeed = chrt_winds.Series.Add("");
            Gustspeed.Color = Color.Fuchsia;

            Series Pressure = chrt_pressure.Series.Add("");
            Pressure.Color = Color.DarkOrange;

            Series Rainfall = chrt_rainfall.Series.Add("");
            Rainfall.Color = Color.DodgerBlue;

            //type of chart
            //not sure why I need this but if not I get bar chart
            MaxTemperature.ChartType = SeriesChartType.FastLine;
            Dewpoint.ChartType = SeriesChartType.FastLine;

            Windspeed.ChartType = SeriesChartType.FastLine;
            Gustspeed.ChartType = SeriesChartType.FastLine;

            Pressure.ChartType = SeriesChartType.FastLine;

            Rainfall.ChartType = SeriesChartType.Column;

            if (File.Exists(myFilePath))
            {
                using (StreamReader reader = new StreamReader(myFilePath))
                {
                    string line;

                    int counter = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        MaxTemperature.Points.AddXY(values[0], values[1]);
                        Dewpoint.Points.AddXY(values[0], values[2]);

                        Windspeed.Points.AddXY(values[0], values[5]);
                        Gustspeed.Points.AddXY(values[0], values[6]);

                        Pressure.Points.AddXY(values[0], values[7]);

                        Rainfall.Points.AddXY(values[0], values[8]);

                        counter++;
                    }
                }
            }
            else
            {
                MsgBox.Show("CSV file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DrawPositionLine(string myFilePath, int myPosition, Chart myChart, double myCSVColumn)
        {
            //Invoke to prevent cross threading
            myChart.BeginInvoke((MethodInvoker)delegate ()
            {
                Series CurrentChartPosition = myChart.Series.Add("");
                CurrentChartPosition.Color = Color.Black;

               
                // type of chart
                //not sure why I need this but if not I get bar chart
                CurrentChartPosition.ChartType = SeriesChartType.Column;


                if (File.Exists(myFilePath))
                {
                    using (StreamReader reader = new StreamReader(myFilePath))
                    {
                        string[] values = ReadSpecificLine(myFilePath, myPosition).Split(',');
                        
                        for (int i = 0; i < myPosition; i++)
                        {
                            CurrentChartPosition.Points.AddXY(0, 0);
                        }

                        CurrentChartPosition.Points.AddXY(values[0], myCSVColumn);
                    }
                }
                else
                {
                    MsgBox.Show("CSV file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //if (myChart.Series.Contains(CurrentMyChartPosition))
                //{
                //myChart.Series.Remove(CurrentMyChartPosition);
                //    myChart.Invalidate(); // Redraw the chart
                //}
            });

        }


        private string ReadSpecificLine(string myFilePath, int myLineNumber)
        {
            if (!File.Exists(myFilePath))
                throw new FileNotFoundException("The specified file does not exist.");

            using (var reader = new StreamReader(myFilePath))
            {
                for (int i = 1; i <= myLineNumber; i++)
                {
                    string line = reader.ReadLine();
                    if (line == null) // End of file reached
                        return null;

                    if (i == myLineNumber)
                        return line;
                }
            }

            return null; // Line not found
        }


    }
}