using System;
using System.IO;
using System.Windows.Forms;


namespace myMovieMaker
{
    public partial class Form1
    {
        //Here we will rename the files
        private void RenameFactory(string myFolderPath, string myWildCard, string MyNamePrefix)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(myFolderPath) || !Directory.Exists(myFolderPath))
            {
                MessageBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(myWildCard))
            {
                MessageBox.Show("Please specify a myWildCard pattern (e.g., *.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(MyNamePrefix))
            {
                MessageBox.Show("Please specify a new name format (e.g., File_{0}.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //var files = Directory.GetFiles(myFolderPath, myWildCard);

                string[] myImagesArray = txtbx_file_list.Lines;

                int counter = 1;

                foreach (var file in myImagesArray)
                {
                    string extension = Path.GetExtension(file);
                    string newFileName = MyNamePrefix + counter + extension;
                    string newFilePath = Path.Combine(myFolderPath + lbl_renamed_files_folder.Text, newFileName);

                    //create the new folder if it does not exist
                    Directory.CreateDirectory(myFolderPath + lbl_renamed_files_folder.Text);

                    rchtxtbx_original_name.AppendText(file + "\r");
                    rchtxtbx_original_name.ScrollToCaret();
                    
                    // Ensure no overwriting of existing files
                    if (File.Exists(newFilePath))
                    {
                        rchtxtbx_renamed_file_name.AppendText(newFilePath + "Already exists - Skipping\r");
                        rchtxtbx_renamed_file_name.ScrollToCaret();

                        MessageBox.Show($"File {newFileName} already exists. Skipping.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                    else
                    {
                        rchtxtbx_renamed_file_name.AppendText(newFilePath + "\r");
                        rchtxtbx_renamed_file_name.ScrollToCaret();
                    }

                    //File.Move(file, newFilePath);
                    File.Copy(file, newFilePath);
                    counter++;
                }

                MessageBox.Show("Files renamed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}