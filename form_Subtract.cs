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
    public partial class form_Subtract : Form
    {
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
                targetPictureBox.Image = image;
            }
        }

        private void button_execute_subtraction_Click(object sender, EventArgs e)
        {
            

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

            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            Bitmap resultImage = new Bitmap(pictureA.Width, pictureA.Height);

            for (int x = 0; x < pictureB.Width; x++)
            {
                for (int y = 0; y < pictureB.Height; y++)
                {
                    Color pixel = pictureB.GetPixel(x, y);
                    Color backpixel = pictureA.GetPixel(x, y);
                    
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);

                    if (subtractvalue > threshold)
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    } else
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
