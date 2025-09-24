using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace image_process
{
    public partial class form_Subtract : Form
    {

        private bool webCamMode = false;
        private Device myDevice;
        private Device[] devices;

        public form_Subtract()
        {
            InitializeComponent();
        }

        // BUTTONS

        private void button_load_file_Click(object sender, EventArgs e)
        {
            PictureBox targetPictureBox = null;
            Button clickedButton = sender as Button;

            if (clickedButton == button_loadForeground)
            {
                targetPictureBox = pictureBox_foreground;
            }
            else if (clickedButton == button_loadBackground)
            {
                targetPictureBox = pictureBox_background;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                if (clickedButton == button_loadBackground && webCamMode)
                {
                    if (image.Height != pictureBox_foreground.Height || image.Width != pictureBox_foreground.Width)
                    {
                        MessageBox.Show("Image size does not match with ImageA");
                        return;
                    }
                }
                
                targetPictureBox.Image = image;
            }
        }

        private void button_toggle_Webcam_Click(object sender, EventArgs e)
        {

            if (!webCamMode)
            {
                toggle_WebcamMode.Text = "Toggle On/Off (On)";
                button_loadForeground.Enabled = false;
                // button_loadBackground.Enabled = false;
                // get the driver going.
                devices = DeviceManager.GetAllDevices();
                if (devices.Length > 0)
                {
                    myDevice = devices[0];
                    myDevice.ShowWindow(pictureBox_foreground);
                    webCamMode = true;

                }
                else
                {
                    MessageBox.Show("No webcam found");
                }

            }
            else
            {
                if (myDevice != null)
                {
                    myDevice.Stop();
                    timer_ImageLoad.Stop();
                    pictureBox_foreground.Image = null;
                }
                webCamMode = false;
                toggle_WebcamMode.Text = "Toggle On/Off (Off)";
                button_loadForeground.Enabled = true;
                //sbutton_loadBackground.Enabled = true;
            }
        }
        private bool webcam_subtraction = false;
        private void button_execute_subtraction_Click(object sender, EventArgs e)
        {
            if (webCamMode)
            {
                //execute subtraction repeatedly, no questions asked.

                if(!webcam_subtraction)
                {
                    if (pictureBox_background == null)
                    {
                        MessageBox.Show("Background image is lacking");
                        return;
                    }

                    timer_ImageLoad.Stop();
                    timer_Subtraction.Start();
                    button_executeSubtraction.Text = "Stop Subtraction";
                } else if (webcam_subtraction)
                {
                    timer_Subtraction.Stop();
                    timer_ImageLoad.Start();
                    button_executeSubtraction.Text = "Subtraction";
                    webcam_subtraction = false;
                }
                Console.WriteLine("Subtraction webcam run executed once");
                return;
            }

            if (pictureBox_foreground.Image == null || pictureBox_background.Image == null)
            {
                MessageBox.Show("Images are lacking");
                return;
            }

            Bitmap pictureA = new Bitmap(pictureBox_foreground.Image);
            Bitmap pictureB = new Bitmap(pictureBox_background.Image);

            if (pictureA.Height != pictureB.Height || pictureA.Width != pictureB.Width)
            {
                MessageBox.Show("Image sizes do not match");
                return;
            }

            

            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            Bitmap resultImage = new Bitmap(pictureA.Width, pictureA.Height);

            for (int x = 0; x < pictureB.Width; x++)
            {
                for (int y = 0; y < pictureB.Height; y++)
                {
                    Color pixel = pictureA.GetPixel(x, y);
                    Color backpixel = pictureB.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(greygreen - grey);

                    /*int subtractvalue1 = Math.Abs(mygreen.R - pixel.R);
                    int subtractvalue2 = Math.Abs(mygreen.G - pixel.G);
                    int subtractvalue3 = Math.Abs(mygreen.B - pixel.B);*/

                    if (subtractvalue <= threshold)
                    //if (subtractvalue1 <= threshold && subtractvalue2 <= threshold && subtractvalue3 <= threshold)
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                }
            }
            pictureBox_result.Image = resultImage;
        }
        // TIMER METHODS

        

        private void timer_ImageLoad_Tick(object sender, EventArgs e)
        {
            if (myDevice != null)
            {
                myDevice.Sendmessage();

                if (Clipboard.ContainsImage())
                {
                    Bitmap img = (Bitmap)Clipboard.GetImage();
                    pictureBox_foreground.Image = img;
                    pictureBox_foreground.Refresh();
                }
            }
        }

        private void timer_Subtraction_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Subtraction webcamtick running");
            
            if (myDevice != null)
            {
                myDevice.Sendmessage();

                if (Clipboard.ContainsImage())
                {
                    Bitmap img = (Bitmap)Clipboard.GetImage();
                    pictureBox_foreground.Image = img;
                    pictureBox_foreground.Refresh();
                }
            }

            if (pictureBox_foreground.Image == null || pictureBox_background.Image == null)
            {
                timer_Subtraction.Stop();
                timer_ImageLoad.Start();
                button_executeSubtraction.Text = "Subtraction";
                MessageBox.Show("Images are lacking");   
                return;
            }

            Bitmap pictureA = new Bitmap(pictureBox_foreground.Image);
            Bitmap pictureB = new Bitmap(pictureBox_background.Image);

            if (pictureA.Height != pictureB.Height || pictureA.Width != pictureB.Width)
            {
                timer_ImageLoad.Start();
                timer_Subtraction.Stop();
                button_executeSubtraction.Text = "Subtraction";
                MessageBox.Show("Image sizes do not match");
                return;
            }
            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            Bitmap resultImage = new Bitmap(pictureA.Width, pictureA.Height);

            for (int x = 0; x < pictureB.Width; x++)
            {
                for (int y = 0; y < pictureB.Height; y++)
                {
                    Color pixel = pictureA.GetPixel(x, y);
                    Color backpixel = pictureB.GetPixel(x, y);

                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(greygreen - grey);
                    /*int subtractvalue1 = Math.Abs(mygreen.R - pixel.R);
                    int subtractvalue2 = Math.Abs(mygreen.G - pixel.G);
                    int subtractvalue3 = Math.Abs(mygreen.B - pixel.B);*/

                    if (subtractvalue <= threshold)
                    //if (subtractvalue1 <= threshold && subtractvalue2 <= threshold && subtractvalue3 <= threshold)
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                }
            }
            pictureBox_result.Image = resultImage;

        }

        // INITIALIZATION

        public void form_Subtract_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
        }
    }
}
