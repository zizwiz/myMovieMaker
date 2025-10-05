using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace myMovieMaker
{
    public partial class Form1
    {

        private void CreateVideoFromImages(string[] myImagesArray, string myOutputVideo, int myFrameRate)
        {
            // Get all JPG files in the folder, sorted by name
           // var imageFiles = Directory.GetFiles(imageFolder, "*.jpg").OrderBy(f => f).ToList();

            if (myImagesArray.Length == 0)
            {
                MessageBox.Show("No JPG files found in the selected folder.");
                return;
            }


            //var inputArgs = "-framerate 20 -f rawvideo -pix_fmt rgb32 -video_size 1920x1080 -i -";
            // var outputArgs = "-vcodec libx264 -crf 23 -pix_fmt yuv420p -preset ultrafast -r 20 out.mp4";

            // var process = new Process
            // {
            //     StartInfo =
            //     {
            //         FileName = "ffmpeg.exe",
            //         Arguments = $"{inputArgs} {outputArgs}",
            //         UseShellExecute = false,
            //         CreateNoWindow = true,
            //         RedirectStandardInput = true
            //     }
            // };

            // process.Start();

            // var ffmpegIn = process.StandardInput.BaseStream;

            // // Write Data
            // ffmpegIn.Write(Data, Offset, Count);

            // // After you are done
            // ffmpegIn.Flush();
            // ffmpegIn.Close();

            // // Make sure ffmpeg has finished the work
            // process.WaitForExit();





            // FFmpeg command
            string ffmpegPath = "ffmpeg"; // Ensure FFmpeg is in your PATH or provide the full path
            string arguments = "-y -f image2pipe -framerate " + myFrameRate + " -i pipe:0 -c:v libx264 -pix_fmt yuv420p " + myOutputVideo;

            try
            {
                var process = new Process
                {
                    StartInfo =
                    {
                         FileName = ffmpegPath,
                         Arguments = arguments,
                         RedirectStandardInput = true,  // Redirect standard input
                         RedirectStandardOutput = true, // Redirect standard output
                         RedirectStandardError = true,  // Redirect standard error
                         UseShellExecute = false,       // Required for redirection
                         CreateNoWindow = true          // Optional: Run without creating a window
                    }
                };





                //using (var process = new Process())
                //{
                //    process.StartInfo.FileName = ffmpegPath;
                //    process.StartInfo.Arguments = arguments;
                //    process.StartInfo.UseShellExecute = false;
                //    process.StartInfo.RedirectStandardInput = true;
                //    process.StartInfo.RedirectStandardOutput = true;
                //    process.StartInfo.RedirectStandardError = true;
                //    process.StartInfo.CreateNoWindow = true;

                process.Start();

                Stream ffmpegInput = process.StandardInput.BaseStream;

                // Write images to FFmpeg's standard input
                // using (var ffmpegInput = process.StandardInput.BaseStream)
                using (ffmpegInput)
                {
                    foreach (string imageFile in myImagesArray)
                    {
                        using (var bitmap = new Bitmap(imageFile))
                        {
                            bitmap.Save(ffmpegInput, ImageFormat.Jpeg);
                            rchtxbx_output.AppendText("Adding:" + imageFile + "\r");
                            rchtxbx_output.ScrollToCaret();
                        }
                    }
                }

                // After you are done
                //ffmpegInput.Flush();
                // ffmpegInput.Close();

                // Wait for FFmpeg to finish
                if (!process.HasExited) process.WaitForExit();
                //process.Close();




                if (process.ExitCode == 0)
                {
                    MessageBox.Show($"Video created successfully: {myOutputVideo}");
                }
                else
                {
                    string error = process.StandardError.ReadToEnd();
                    MessageBox.Show($"FFmpeg error: {error}");
                }


                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }






    }
}