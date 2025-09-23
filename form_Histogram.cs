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
    public partial class form_Histogram : Form
    {
        
        public form_Histogram()
        {
            InitializeComponent();
        }

        public form_Histogram(Bitmap image_src, Bitmap image_histogram_red, Bitmap image_histogram_green, Bitmap image_histogram_blue, Bitmap image_histogram_gray)
        {
            InitializeComponent();
            histogram_src_img.Image = image_src;
            histogram_red.Image = image_histogram_red;
            histogram_green.Image = image_histogram_green;
            histogram_blue.Image = image_histogram_blue;
            histogram_gray.Image = image_histogram_gray;
        }


        private void button_close_histogram_Click(object sender, EventArgs e)
        {
            Close();
        }

        


    }
}
