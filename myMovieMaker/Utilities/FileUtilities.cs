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

        public static void BackupFiles(string mySourceFolder, string myBackupFolder, Label myBackupFolderLabel, bool myFlag)
        {
            try
            {
                //create the new folder if it does not exist
                Directory.CreateDirectory(myBackupFolder);

                // Copy files from source to backup folder
                FileUtilities.CopyFiles(mySourceFolder, myBackupFolder);
                myBackupFolderLabel.Text = myBackupFolder;
                if (myFlag) MsgBox.Show("Files backed-up successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                myBackupFolderLabel.Text = "Files not backed-up";
                if (myFlag) MsgBox.Show($"Files not backed-up due to error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Createfolders(string mySourceFolder, Label myFolderPathLabel, Label myBackupFilePathLabel,
            Label myRenamedFilePath, Label mySynopticFilePath, Label myMovieFileImagesPath, Label myMovieFilePath)
        {
            myFolderPathLabel.Text = Path.GetDirectoryName(mySourceFolder) + "\\";
            myBackupFilePathLabel.Text = myFolderPathLabel.Text + "backup\\";
            myRenamedFilePath.Text = myFolderPathLabel.Text + "renamed\\";
            mySynopticFilePath.Text = myFolderPathLabel.Text + "synoptic\\";
            myMovieFileImagesPath.Text = myFolderPathLabel.Text + "movie_images\\";
            myMovieFilePath.Text = myFolderPathLabel.Text + "movie\\";
        }
    }
}
