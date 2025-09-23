
using HistogramUtil;
namespace image_process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void file_load_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Bitmap image = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = image;
        }

        private void file_save_Click(object sender, EventArgs e)
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

        private void filters_copy_Click(object sender, EventArgs e)
        {
            /*
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = new Bitmap(pictureBox1.Image);
            }
            pictureBox2.Refresh();
            */

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to convert.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap copy = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    copy.SetPixel(x, y, pixelColor);
                }
            }
            pictureBox2.Image = copy;
            pictureBox2.Refresh();

        }

        private void filters_greyscale_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to convert.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap grayscale = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    int grayValue = ((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayscale.SetPixel(x, y, grayColor);
                }
            }
            pictureBox2.Image = grayscale;
            pictureBox2.Refresh();

        }

        private void filters_colorInverse_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to convert.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap inverse = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    int redValue = 255 - pixelColor.R;
                    int greenValue = 255 - pixelColor.G;
                    int blueValue = 255 - pixelColor.B;
                    Color inverse_color = Color.FromArgb(redValue, greenValue, blueValue);
                    inverse.SetPixel(x, y, inverse_color);
                }
            }
            pictureBox2.Image = inverse;
            pictureBox2.Refresh();
        }

        private void filters_sepia_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to convert.");
                return;
            }

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap sepia = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    
                    int redValue = (int)(0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);

                    if (redValue < 0) { redValue = 0; }
                    if (redValue > 255) { redValue = 255; }

                    int greenValue = (int)(0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);

                    if (greenValue < 0) { greenValue = 0; }
                    if (greenValue > 255) { greenValue = 255; }

                    int blueValue = (int)(0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);

                    if (blueValue < 0) { blueValue = 0; }
                    if (blueValue > 255) { blueValue = 255; }

                    Color sepia_color = Color.FromArgb(redValue, greenValue, blueValue);
                    sepia.SetPixel(x, y, sepia_color);
                }
            }
            pictureBox2.Image = sepia;
            pictureBox2.Refresh();
        }

        private void filters_histogram_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No image to process.");
                return;
            }
            //make code to make histograms
            Bitmap image_source = new Bitmap(pictureBox1.Image);
            HistogramHelper histogram_maker = new HistogramHelper(image_source);
            Bitmap redHistogram = histogram_maker.generate_RedHistogram();
            Bitmap greenHistogram = histogram_maker.generate_GreenHistogram();
            Bitmap blueHistogram = histogram_maker.generate_BlueHistogram();
            Bitmap grayHistogram = histogram_maker.generate_GrayHistogram();


            form_Histogram histogramForm = new form_Histogram(image_source,redHistogram,greenHistogram,blueHistogram,grayHistogram);
            histogramForm.Show();
        }

        private void subtract_tab_Click(object sender, EventArgs e)
        {
            form_Subtract subtractionForm = new form_Subtract();
            subtractionForm.Show();
            
        }


        // FORM INITIALIZING

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
        }
    }
}
