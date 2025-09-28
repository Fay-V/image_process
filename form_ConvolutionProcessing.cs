using image_convolution;
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
        public form_ConvolutionProcessing()
        {
            InitializeComponent();
        }

        private void form_ConvolutionProcessing_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            string[] filter_options = { "None", "Smooth", "Gaussian Blur", "Sharpen", "Mean Removal", "Emboss Laplascian" };
            comboBox_Filters.Items.AddRange(filter_options);
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

        //FILTERS

        private void filters_Smooth_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);

            BitmapFilter.Smooth(original);

            pictureBox2.Image = original;
        }

        private void filters_GaussianBlur_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.GaussianBlur(original);
            pictureBox2.Image = original;
        }

        private void filters_Sharpen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }
            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.Sharpen(original);
            pictureBox2.Image = original;
        }

        private void filters_MeanRemoval_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }
            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.MeanRemoval(original);
            pictureBox2.Image = original;
        }

        private void filters_EmbossLasplascian_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }
            Bitmap original = new Bitmap(pictureBox1.Image);
            BitmapFilter.EmbossLaplascian(original);
            pictureBox2.Image = original;
        }
    }
}
