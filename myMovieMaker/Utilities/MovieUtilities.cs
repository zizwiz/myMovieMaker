using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CenteredMessagebox;

namespace myMovieMaker.Utilities
{
    class MovieUtilities
    {

        public static void CreateMovieImage(Panel myPanel, int count)
        {
            //Invoke to prevent cross threading
            myPanel.BeginInvoke((MethodInvoker)delegate ()
            {

                string myFilePath = "C:\\temp\\temp\\test\\west17\\movie_images\\" + count + ".jpg";

                // Create a bitmap with the size of the panel
                Bitmap bitmap = new Bitmap(myPanel.Width, myPanel.Height);

                // Draw the panel's content onto the bitmap
                myPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, myPanel.Width, myPanel.Height));

                // Save the bitmap to the specified location
                bitmap.Save(myFilePath, ImageFormat.Jpeg);


            });


            /*
            try
            {
                // Open a SaveFileDialog to ask the user for the file name and location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Bitmap Image|*.jpg";
                    saveFileDialog.Title = "Save Hobbs Data as Image";
                    saveFileDialog.FileName = myComboBox.Text + "_" + myDateTimePicker.Text;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Ensure the user provided a valid file path
                        if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                        {
                            // Create a bitmap with the size of the panel
                            Bitmap bitmap = new Bitmap(myPanel.Width, myPanel.Height);

                            // Draw the panel's content onto the bitmap
                            myPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, myPanel.Width, myPanel.Height));

                            // Save the bitmap to the specified location
                            bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);




                            //MsgBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK,
                            //    MessageBoxIcon.Information);
                        }
                        else
                        {
                            MsgBox.Show("Invalid file name or path.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MsgBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }*/
        }
    }
}
