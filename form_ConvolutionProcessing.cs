using image_process.ConvolutionImageAssist;
using image_process.DeviceAssist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_process
{
    public partial class form_ConvolutionProcessing : Form
    {
        private Device myDevice;
        private Device[] devices;
        private bool webCamMode = false;
        private int index4WebCam = 0;
        //FORM INITIALIZATION
        public form_ConvolutionProcessing()
        {
            InitializeComponent();
        }

        private void form_ConvolutionProcessing_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            string[] filter_options = { "None", "Smooth", "Gaussian Blur", "Sharpen", "Mean Removal", "Emboss Laplascian" };
            comboBox_Filters.Items.AddRange(filter_options);
            comboBox_Filters.SelectedIndex = 0; // Default to "None"
        }

        //INPUT FIELDS HANDLING
        //@TODO: The webcam part will be implemented within the filter methods.
        //@INFO: Re: Timer Implementation: Just pass the matrix to the timer. Have timer repeatedly collect the frames itself.
        private void button_ExecuteFilters_Click(object sender, EventArgs e)
        {
            if (webCamMode) 
            {
                timer1.Start();
            }

            
            
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }

            if (comboBox_Filters.SelectedItem == null)
            {
                return;
            }

            string selectedFilter = comboBox_Filters.SelectedItem.ToString().Trim();

            int weight = 1;
            int offset = 0;

            switch (selectedFilter)
            {
                case "None":
                    index4WebCam = 0;
                    filters_None_Click(sender, e);
                    break;
                case "Smooth":
                    index4WebCam = 1;
                    filters_Smooth_Click(sender, e, weight, offset);
                    break;
                case "Gaussian Blur":
                    index4WebCam = 2;
                    filters_GaussianBlur_Click(sender, e, weight, offset);
                    break;
                case "Sharpen":
                    index4WebCam = 3;
                    filters_Sharpen_Click(sender, e, weight, offset);
                    break;
                case "Mean Removal":
                    index4WebCam = 4;
                    filters_MeanRemoval_Click(sender, e, weight, offset);
                    break;
                case "Emboss Laplascian":
                    index4WebCam = 5;                    
                    filters_EmbossLasplascian_Click(sender, e, weight, offset);
                    break;
                default:
                    MessageBox.Show("Unknown filter selected.");
                    break;
            }
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string newText = string.Empty;

            if (textBox == null)
            {
                return;
            }
            foreach (char c in textBox.Text)
            {
                if (char.IsDigit(c))
                {
                    newText += c;
                }
            }

            //Adjust cursor position
            string originalText = textBox.Text;
            if (originalText == newText)
            {
                return;
            }

            int cursorPosition = textBox.SelectionStart;

            textBox.Text = newText;

            int newTextLength = newText.Length;

            if (cursorPosition > newTextLength)
            {
                textBox.SelectionStart = newText.Length;
            }
            else
            {
                textBox.SelectionStart = Math.Max(0, cursorPosition - (originalText.Length - newTextLength));

            }
        }

        //FOR FILE OPENING AND SAVING
        private void button_LoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

        private void button_SaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("No image to save.");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
        }

        //TIMER TICK & WEBCAM METHODS

        private void menu_WebcamToggle_Click(object sender, EventArgs e)
        {
            if (!webCamMode)
            {
                menu_WebCamToggle.Text = "Toggle On/Off (On)";
                button_LoadImage.Enabled = false;
                
                devices = DeviceManager.GetAllDevices();
                if (devices.Length > 0)
                {
                    myDevice = devices[0];
                    myDevice.ShowWindow(pictureBox1);
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
                    timer1.Stop();
                    pictureBox1.Image = null;
                }
                webCamMode = false;
                menu_WebCamToggle.Text = "Toggle On/Off (Off)";
                button_LoadImage.Enabled = true;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (myDevice != null)
            {
                myDevice.Sendmessage();

                if (Clipboard.ContainsImage())
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    Bitmap img = (Bitmap)Clipboard.GetImage();
                    pictureBox1.Image = img;
                    
                }

            } 
            else
            {
                MessageBox.Show("Device Lost");
                timer1.Stop();
            }
                

            switch (index4WebCam)
            {
                case 0:

                    filters_None_Click(sender, e);
                    break;
                case 1:

                    filters_Smooth_Click(sender, e);
                    break;
                case 2:

                    filters_GaussianBlur_Click(sender, e);
                    break;
                case 3:

                    filters_Sharpen_Click(sender, e);
                    break;
                case 4:

                    filters_MeanRemoval_Click(sender, e);
                    break;
                case 5:

                    filters_EmbossLasplascian_Click(sender, e);
                    break;
                default:
                    MessageBox.Show("Unknown filter selected.");
                    break;
            }
        }

        //FILTERS

        private void filters_None_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox2.Image = null;
                return;
            }

            pictureBox2.Image = new Bitmap(pictureBox1.Image);
        }

        private void filters_Smooth_Click(object sender, EventArgs e, int weight=1, int offset=0)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox2.Image = null;
                MessageBox.Show("No image to process.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);

            BitmapFilter.Smooth(original, weight, offset);

            
            
        if (pictureBox2.Image != null)
        {
            pictureBox2.Image.Dispose();
        }
            
            pictureBox2.Image = original;
        }

        private void filters_GaussianBlur_Click(object sender, EventArgs e, int weight=1, int offset=0)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox2.Image = null;
                MessageBox.Show("No image to process.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.GaussianBlur(original, weight, offset);
            
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }
            
            pictureBox2.Image = original;
        }

        private void filters_Sharpen_Click(object sender, EventArgs e, int weight=1, int offset=0)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox2.Image = null;
                MessageBox.Show("No image to process.");
                return;
            }
            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.Sharpen(original, weight, offset);
            
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }
            
            pictureBox2.Image = original;
        }

        private void filters_MeanRemoval_Click(object sender, EventArgs e, int weight=1, int offset=0)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox2.Image = null;
                MessageBox.Show("No image to process.");
                return;
            }
            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.MeanRemoval(original, weight, offset);
            
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }
            
            pictureBox2.Image = original;
        }

        private void filters_EmbossLasplascian_Click(object sender, EventArgs e, int weight=1, int offset=0)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox2.Image = null;
                MessageBox.Show("No image to process.");
                return;
            }
            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.EmbossLaplascian(original, weight, offset);
            
            
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }
            
            pictureBox2.Image = original;
        }

       

    }
}
