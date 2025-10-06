using System;
using System.IO;
using System.Windows.Forms;
using CenteredMessagebox;


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
                MsgBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(myWildCard))
            {
                MsgBox.Show("Please specify a myWildCard pattern (e.g., *.txt).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(MyNamePrefix))
            {
                DialogResult result = MsgBox.Show("Are you sure you do not want to prefix the file number? e.g File_{0}.", "Are you Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                   return; 
                }
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

                        MsgBox.Show($"File {newFileName} already exists. Skipping.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MsgBox.Show("Files renamed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MsgBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}