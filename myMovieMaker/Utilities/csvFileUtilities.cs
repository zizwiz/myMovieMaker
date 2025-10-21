using System;
using System.Data;
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


    }
}
