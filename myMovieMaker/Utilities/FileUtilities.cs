using System;
using System.IO;
using System.Windows.Forms;
using CenteredMessagebox;

namespace myMovieMaker.Utilities
{
    class FileUtilities
    {
        public static void CopyFiles(string mySourceFolder, string myBackupFolder)
        {
            // Get all files in the source folder (no subfolders)
            string[] files = Directory.GetFiles(mySourceFolder);

            foreach (string file in files)
            {
                // Get the file name
                string fileName = Path.GetFileName(file);

                // Construct the destination file path
                string destFile = Path.Combine(myBackupFolder, fileName);

                // Copy the file to the backup folder
                File.Copy(file, destFile, overwrite: true);
            }
        }

        public static void BackupFiles(string mySourceFolder, string myBackupFolder, Label myBackupFolderLabel)
        {
            try
            {
                //create the new folder if it does not exist
                Directory.CreateDirectory(myBackupFolder);

                // Copy files from source to backup folder
                FileUtilities.CopyFiles(mySourceFolder, myBackupFolder);
                myBackupFolderLabel.Text = myBackupFolder;
                MsgBox.Show("Files backed-up successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                myBackupFolderLabel.Text = "Files not backed-up";
                MsgBox.Show($"Files not backed-up due to error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
