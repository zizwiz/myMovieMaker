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
            //Set colour for charts
            chrt_temperatures.Series["MaxTemperature"].Color = Color.Red;
            chrt_temperatures.Series["Dewpoint"].Color = Color.Green;
            chrt_winds.Series["Windspeed"].Color = Color.Blue;
            chrt_winds.Series["Gustspeed"].Color = Color.Fuchsia;
            chrt_pressure.Series["Pressure"].Color = Color.DarkOrange;
            chrt_rainfall.Series["Rainfall"].Color = Color.DodgerBlue;


            //Draw Graphs
            if (File.Exists(myFilePath))
            {
                using (StreamReader reader = new StreamReader(myFilePath))
                {
                    string line;

                    int counter = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        chrt_temperatures.Series["MaxTemperature"].Points.AddXY(values[0], values[1]);
                        chrt_temperatures.Series["Dewpoint"].Points.AddXY(values[0], values[2]);

                        chrt_winds.Series["Windspeed"].Points.AddXY(values[0], values[5]);
                        chrt_winds.Series["Gustspeed"].Points.AddXY(values[0], values[6]);

                        chrt_pressure.Series["Pressure"].Points.AddXY(values[0], values[7]);

                        chrt_rainfall.Series["Rainfall"].Points.AddXY(values[0], values[8]);

                        counter++;
                    }
                }
            }
            else
            {
                MsgBox.Show("CSV file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DrawPositionLine(string myFilePath, int myPosition, Chart myChart, double myCSVColumn, Series mySeries)
        {
            //Invoke to prevent cross threading
            myChart.BeginInvoke((MethodInvoker)delegate ()
            {
                //Remove the series so we can redraw it to make it look like it is moving
                mySeries.Points.Clear();
                mySeries.Color = Color.Black;

                if (File.Exists(myFilePath))
                {
                    using (StreamReader reader = new StreamReader(myFilePath))
                    {
                        int i;

                        string[] values = ReadSpecificLine(myFilePath, myPosition).Split(',');

                        myChart.Series["CurrentChartPosition"].Points.Clear();

                        for (i = 0; i < myPosition - 1; i++)
                        {
                            mySeries.Points.AddXY(0, 0);
                        }

                        mySeries.Points.AddXY(values[0], myCSVColumn);

                        // Show wind direction
                        lbl_wind_direction.Text = values[4];

                        //Show total rainfall for the day
                        lbl_total_rainfall.Text = values[9] + "mm";
                    }
                }
                else
                {
                    MsgBox.Show("CSV file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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