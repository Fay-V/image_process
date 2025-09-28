using image_process.ConvolutionImageAssist;
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
        }

        //INPUT FIELDS HANDLING

        private void comboBox_Filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox_Filters.SelectedItem.ToString();
            switch (selectedFilter)
            {
                case "None":
                    // No filter selected
                    // Consider clearing the output image
                    break;
                case "Smooth":
                    filters_Smooth_Click(sender, e);
                    break;
                case "Gaussian Blur":
                    filters_GaussianBlur_Click(sender, e);
                    break;
                case "Sharpen":
                    filters_Sharpen_Click(sender, e);
                    break;
                case "Mean Removal":
                    filters_MeanRemoval_Click(sender, e);
                    break;
                case "Emboss Laplascian":
                    filters_EmbossLasplascian_Click(sender, e);
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

            if(textBox == null)
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
            } else
            {
                textBox.SelectionStart = Math.Max(0,cursorPosition - (originalText.Length - newTextLength));

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
