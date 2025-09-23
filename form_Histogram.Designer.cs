namespace image_process
{
    partial class form_Histogram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            histogram_src_img = new PictureBox();
            histogram_red = new PictureBox();
            histogram_green = new PictureBox();
            histogram_blue = new PictureBox();
            histogram_gray = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)histogram_src_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histogram_red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histogram_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histogram_blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histogram_gray).BeginInit();
            SuspendLayout();
            // 
            // histogram_src_img
            // 
            histogram_src_img.Location = new Point(30, 40);
            histogram_src_img.Name = "histogram_src_img";
            histogram_src_img.Size = new Size(413, 381);
            histogram_src_img.SizeMode = PictureBoxSizeMode.Zoom;
            histogram_src_img.TabIndex = 0;
            histogram_src_img.TabStop = false;
            // 
            // histogram_red
            // 
            histogram_red.Location = new Point(488, 40);
            histogram_red.Name = "histogram_red";
            histogram_red.Size = new Size(113, 71);
            histogram_red.SizeMode = PictureBoxSizeMode.StretchImage;
            histogram_red.TabIndex = 1;
            histogram_red.TabStop = false;
            // 
            // histogram_green
            // 
            histogram_green.Location = new Point(488, 142);
            histogram_green.Name = "histogram_green";
            histogram_green.Size = new Size(113, 71);
            histogram_green.SizeMode = PictureBoxSizeMode.StretchImage;
            histogram_green.TabIndex = 2;
            histogram_green.TabStop = false;
            // 
            // histogram_blue
            // 
            histogram_blue.Location = new Point(488, 248);
            histogram_blue.Name = "histogram_blue";
            histogram_blue.Size = new Size(113, 71);
            histogram_blue.SizeMode = PictureBoxSizeMode.StretchImage;
            histogram_blue.TabIndex = 3;
            histogram_blue.TabStop = false;
            // 
            // histogram_gray
            // 
            histogram_gray.Location = new Point(488, 350);
            histogram_gray.Name = "histogram_gray";
            histogram_gray.Size = new Size(113, 71);
            histogram_gray.SizeMode = PictureBoxSizeMode.StretchImage;
            histogram_gray.TabIndex = 4;
            histogram_gray.TabStop = false;
            // 
            // form_Histogram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 457);
            Controls.Add(histogram_gray);
            Controls.Add(histogram_blue);
            Controls.Add(histogram_green);
            Controls.Add(histogram_red);
            Controls.Add(histogram_src_img);
            Name = "form_Histogram";
            Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)histogram_src_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)histogram_red).EndInit();
            ((System.ComponentModel.ISupportInitialize)histogram_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)histogram_blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)histogram_gray).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox histogram_src_img;
        private PictureBox histogram_red;
        private PictureBox histogram_green;
        private PictureBox histogram_blue;
        private PictureBox histogram_gray;
    }
}