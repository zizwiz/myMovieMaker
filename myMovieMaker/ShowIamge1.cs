using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CenteredMessagebox;


namespace myMovieMaker
{
    public partial class Form1
    {

        private void ShowImage(string myImageFile)
        {
            //pcbx_image.BeginInvoke((MethodInvoker)delegate ()
            //{
                //pcbx_image.Image = null;
                GC.Collect();
                pcbx_image.Image = Image.FromFile(myImageFile);

              //  if (myImageFile.)
                    

            //});


        }

    }
}