using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CenteredMessagebox;
using myMovieMaker.Utilities;

//using Accord.Video.FFMPEG;

namespace myMovieMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_select_image_files_Click(object sender, EventArgs e)
        {
            // Open file dialog to select multiple JPG files
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lbl_folder_path.Text = Path.GetDirectoryName(openFileDialog.FileName) + "\\";
                    txtbx_file_list.Lines = openFileDialog.FileNames;
                }
            }
        }

        private void btn_create_video_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                string[] myImagesArray = rchtxtbx_renamed_file_name.Lines;

                if (myImagesArray.Length == 0)
                {
                    MsgBox.Show("Please select at least one image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cast text to int and check it is legal if not stop and exit
                if (!int.TryParse(txtFrameRate.Text, out int frameRate) || frameRate <= 0)
                {
                    MsgBox.Show("Please enter a valid frame rate (positive integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save video file
                if (chkbx_autoname.Checked)
                {
                    CreateVideoFromImages(myImagesArray, DateTime.Now.ToString("ddMMyyyy_HHmmss"), frameRate, true);
                }
                else
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        //We save files as Mpeg4 only
                        saveFileDialog.Filter = "mpeg4 files (*.mp4)|*.mp4";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            CreateVideoFromImages(myImagesArray, saveFileDialog.FileName, frameRate, true);

                            // CreateVideoFromImages(inputFolder, outputPath, frameRate);
                            MsgBox.Show("Video created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MsgBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            RenameFactory(lbl_folder_path.Text, txtWildcard.Text, txtNewNameFormat.Text, true);
        }

        private void btn_move_line_up_Click(object sender, EventArgs e)
        {
            RichTextBoxLineManipulation.MoveLine(-1, txtbx_file_list); // Move the selected line up
        }

        private void btn_delete_line_Click(object sender, EventArgs e)
        {
            RichTextBoxLineManipulation.DeleteLine(txtbx_file_list); // Delete the selected line
        }

        private void btn_move_line_down_Click(object sender, EventArgs e)
        {
            RichTextBoxLineManipulation.MoveLine(1, txtbx_file_list); // Move the selected line down
        }

        private void btn_check_for_empty_jpg_Click(object sender, EventArgs e)
        {
            if (!ProcessJpgFiles(txtbx_file_list, true)) return;
        }

        private void btn_backup_files_Click(object sender, EventArgs e)
        {
            // Open folder browser dialogs for source and backup folders
            //using (FolderBrowserDialog sourceDialog = new FolderBrowserDialog())
            //using (FolderBrowserDialog backupDialog = new FolderBrowserDialog())
            //{
            //    sourceDialog.Description = "Select the Source Folder";
            //    backupDialog.Description = "Select the Backup Folder";

            //    if (sourceDialog.ShowDialog() == DialogResult.OK &&
            //        backupDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string sourceFolder = sourceDialog.SelectedPath;
            //        string backupFolder = backupDialog.SelectedPath;

            string sourceFolder = lbl_folder_path.Text;
            string backupFolder = sourceFolder + "backup_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + "\\";


            try
            {
                //create the new folder if it does not exist
                Directory.CreateDirectory(backupFolder);

                // Copy files from source to backup folder
                FileUtilities.CopyFiles(sourceFolder, backupFolder);
                lbl_backup_folder.Text = backupFolder;
                MsgBox.Show("Files backed-up successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MsgBox.Show($"Files not backed-up due to error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            // }

        }

        private void btn_make_movie_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tab_replace_empty_jpg;
            if (!ProcessJpgFiles(txtbx_file_list, false)) return;

            tabControl1.SelectedTab = tab_rename_files;
            if (!RenameFactory(lbl_folder_path.Text, txtWildcard.Text, txtNewNameFormat.Text, false)) return;

            tabControl1.SelectedTab = tab_movie_maker;
            // Cast text to int and check it is legal if not stop and exit
            if (!int.TryParse(txtFrameRate.Text, out int frameRate) || frameRate <= 0)
            {
                MsgBox.Show("Please enter a valid frame rate (positive integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save video file
            if (chkbx_autoname.Checked)
            {
                CreateVideoFromImages(rchtxtbx_renamed_file_name.Lines, DateTime.Now.ToString("ddMMyyyy_HHmmss"), frameRate, false);
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    //We save files as Mp4 only
                    saveFileDialog.Filter = "mpeg4 files (*.mp4)|*.mp4";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (!CreateVideoFromImages(rchtxtbx_renamed_file_name.Lines, saveFileDialog.FileName, frameRate,
                                false)) return;

                        //All worked and video has been created
                        MsgBox.Show("Movie awaits its premier", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rchtxtbx_renamed_file_name.Clear();
            rchtxtbx_original_name.Clear();
            rchtxbx_output.Clear();
            rchtxtbx_checked_files.Clear();
            rchtxtbx_checking_file.Clear();
            txtbx_file_list.Clear();
            txtbx_rename_counter.Text = "1";
            txtWildcard.Text = "";
            lbl_backup_folder.Text = "....";
            lbl_folder_path.Text = "....";
            lbl_renamed_files_folder.Text = "....";
        }

       

        //private void CreateVideoFromImages(string[] imagePaths, string outputPath, int frameRate)
        //{
        //    // Ensure all images exist
        //    foreach (string path in imagePaths)
        //    {
        //        if (!File.Exists(path))
        //        {
        //            throw new FileNotFoundException($"Image file not found: {path}");
        //        }
        //    }

        //    // Get the size of the first image
        //    Bitmap firstImage = new Bitmap(imagePaths[0]);
        //    int width = firstImage.Width;
        //    int height = firstImage.Height;
        //    firstImage.Dispose();

        //    // Create the video file
        //    using (VideoFileWriter writer = new VideoFileWriter())
        //    {
        //        // writer.Open(outputPath, width, height, frameRate, VideoCodec.MPEG4);

        //        // writer.Open(outputPath, width, height, frameRate, VideoCodec.VP9);
        //        //-vcodec mpeg4
        //        writer.Open(outputPath, width, height, frameRate, VideoCodec.MPEG4);

        //        foreach (string imagePath in imagePaths)
        //        {
        //            using (Bitmap image = new Bitmap(imagePath))
        //            {
        //                // Ensure all images have the same dimensions
        //                if (image.Width != width || image.Height != height)
        //                {
        //                    throw new InvalidOperationException("All images must have the same dimensions.");
        //                }

        //                writer.WriteVideoFrame(image);
        //                image.Dispose();
        //            }
        //        }

        //        writer.Close();
        //    }
        //}
    }
}
