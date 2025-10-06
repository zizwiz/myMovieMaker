using System.IO;

namespace myMovieMaker.Utilities
{
    class FileUtilities
    {
        public static void CopyFiles(string sourceFolder, string backupFolder)
        {
            // Get all files in the source folder (no subfolders)
            string[] files = Directory.GetFiles(sourceFolder);

            foreach (string file in files)
            {
                // Get the file name
                string fileName = Path.GetFileName(file);

                // Construct the destination file path
                string destFile = Path.Combine(backupFolder, fileName);

                // Copy the file to the backup folder
                File.Copy(file, destFile, overwrite: true);
            }
        }
    }
}
