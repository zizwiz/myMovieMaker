using System;
using System.IO;
using System.Windows.Forms;
using CenteredMessagebox;
using myMovieMaker.Utilities;


namespace myMovieMaker
{
    public partial class Form1
    {

        private void ProcessJpgFiles(TextBox myTextBox)
        {
            try
            {
                // Get all .jpg files in the folder, sorted by name
                // var myImagesArray = Directory.GetFiles(folderPath, "*.jpg").OrderBy(f => f).ToList();

                //first backup files even if we are only renaming a single file out of a whole directory of files.
                string sourceFolder = lbl_folder_path.Text;
                string backupFolder = sourceFolder + "backup_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + "\\";
                FileUtilities.BackupFiles(sourceFolder, backupFolder, lbl_backup_folder);
                
                //Get the list from the text box and place in an array 
                string[] myImagesArray = txtbx_file_list.Lines;


                if (myImagesArray.Length < 2)
                {
                    MsgBox.Show("The folder must contain at least two .jpg files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i < myImagesArray.Length; i++) // Start from the second file
                {
                    string previousFile = myImagesArray[i - 1];

                    if (rchtxtbx_checking_file.Text == "")
                    {
                        rchtxtbx_checking_file.AppendText("Checking file: " + previousFile);
                    }
                    else
                    {
                        rchtxtbx_checking_file.AppendText("\rChecking file: " + previousFile);
                    }
                    rchtxtbx_checking_file.ScrollToCaret();
                    
                    string currentFile = myImagesArray[i];
                    FileInfo fileInfo = new FileInfo(currentFile);

                    // Check if the file size is less than 10 KB
                    if (fileInfo.Length < 10 * 1024)
                    {
                        if (rchtxtbx_checked_files.Text == "")
                        {
                            rchtxtbx_checked_files.AppendText("Replaced file: " + currentFile);
                        }
                        else
                        {
                            rchtxtbx_checked_files.AppendText("\rReplaced file: " + currentFile);
                        }
                        rchtxtbx_checked_files.ScrollToCaret();

                        // Replace the current file with the previous file
                        File.Copy(previousFile, currentFile, overwrite: true);
                    }
                    else
                    {
                        if (rchtxtbx_checked_files.Text == "")
                        {
                            rchtxtbx_checked_files.AppendText("Checked file: " + currentFile);
                            }
                        else
                        {
                            rchtxtbx_checked_files.AppendText("\rChecked file: " + currentFile);
                        }
                        rchtxtbx_checked_files.ScrollToCaret();
                    }
                }

                MsgBox.Show("Processing completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MsgBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}