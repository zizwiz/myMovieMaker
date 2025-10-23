using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CenteredMessagebox;

namespace myMovieMaker.Utilities
{
    class csvFileUtilities
    {

        public static int CountLinesInCSVFile(string myFilePath)
        {
            int lineCount = 0;

            // Using StreamReader to read the file line by line
            using (StreamReader reader = new StreamReader(myFilePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }


        public static double[] GetMaxMinColumnValue(string myFilePath, string myColumnName)
        {
            double[] Values = new []{0.0,0.0};
            

            try
            {
                // Load CSV file
                var lines = File.ReadAllLines(myFilePath);

                // Parse CSV into a DataTable
                var dataTable = new DataTable();
                var headers = lines[0].Split(',');

                foreach (var header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    dataTable.Rows.Add(lines[i].Split(','));
                }

                // Bind to DataGridView for visualization (optional)
              //  dataGridView1.DataSource = dataTable;

                // Find Max and Min in a specific column (e.g., "ColumnName")
               var columnValues = dataTable.AsEnumerable()
                    .Select(row => Convert.ToDouble(row[myColumnName]))
                    .ToList();

                Values[0] = columnValues.Max();
                Values[1] = columnValues.Min();
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Values;
        }


        public static int GetLineNumber(string myCSVFilePath, TimeSpan myCurrentTime)
        {
            int closestLineNumber = -1;

            try
            {
               // Read all lines from the CSV file
                var lines = File.ReadAllLines(myCSVFilePath);

                // Get the current time of day in hh:mm format
               // TimeSpan currentTime = DateTime.Now.TimeOfDay;

                // Initialize variables to track the closest match
                
                TimeSpan closestTimeDifference = TimeSpan.MaxValue;

                // Iterate through each line in the CSV file
                for (int i = 0; i < lines.Length; i++)
                {
                    // Split the line by commas to get the first column (time)
                    var columns = lines[i].Split(',');

                    if (columns.Length > 0)
                    {
                        // Parse the time from the first column
                        if (TimeSpan.TryParseExact(columns[0], "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan recordedTime))
                        {
                            // Calculate the time difference
                            TimeSpan timeDifference = (myCurrentTime - recordedTime).Duration();

                            // Update the closest match if this is a smaller difference
                            if (timeDifference < closestTimeDifference)
                            {
                                closestTimeDifference = timeDifference;
                                closestLineNumber = i + 1; // Line numbers are 1-based
                            }
                        }
                    }
                }

                // Display the result
                //if (closestLineNumber != -1)
                //{
                //    MessageBox.Show($"Closest match is on line {closestLineNumber} with a time difference of {closestTimeDifference.TotalMinutes} minutes.");
                //}
                //else
                //{
                //    MessageBox.Show("No valid time entries found in the CSV file.");
                //}
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                //MessageBox.Show($"An error occurred: {ex.Message}");
            }




            return closestLineNumber;
        }



    }
}
