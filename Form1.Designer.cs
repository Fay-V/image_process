namespace image_process
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            file_tab = new ToolStripMenuItem();
            file_load_image = new ToolStripMenuItem();
            file_save_image = new ToolStripMenuItem();
            filters_tab = new ToolStripMenuItem();
            filters_copy = new ToolStripMenuItem();
            filters_greyscale = new ToolStripMenuItem();
            filters_sepia = new ToolStripMenuItem();
            filters_colorInversion = new ToolStripMenuItem();
            filters_histogram = new ToolStripMenuItem();
            webcam_tab = new ToolStripMenuItem();
            webcam_toggle = new ToolStripMenuItem();
            subtract_tab = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            label_source = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(27, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(418, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(352, 332);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { file_tab, filters_tab, webcam_tab, subtract_tab });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // file_tab
            // 
            file_tab.DropDownItems.AddRange(new ToolStripItem[] { file_load_image, file_save_image });
            file_tab.Name = "file_tab";
            file_tab.Size = new Size(37, 20);
            file_tab.Text = "File";
            // 
            // file_load_image
            // 
            file_load_image.Name = "file_load_image";
            file_load_image.Size = new Size(137, 22);
            file_load_image.Text = "Load Image";
            file_load_image.Click += file_load_Click;
            // 
            // file_save_image
            // 
            file_save_image.Name = "file_save_image";
            file_save_image.Size = new Size(137, 22);
            file_save_image.Text = "Save Image ";
            file_save_image.Click += file_save_Click;
            // 
            // filters_tab
            // 
            filters_tab.DropDownItems.AddRange(new ToolStripItem[] { filters_copy, filters_greyscale, filters_sepia, filters_colorInversion, filters_histogram });
            filters_tab.Name = "filters_tab";
            filters_tab.Size = new Size(50, 20);
            filters_tab.Text = "Filters";
            // 
            // filters_copy
            // 
            filters_copy.Name = "filters_copy";
            filters_copy.Size = new Size(154, 22);
            filters_copy.Text = "Copy";
            filters_copy.Click += filters_copy_Click;
            // 
            // filters_greyscale
            // 
            filters_greyscale.Name = "filters_greyscale";
            filters_greyscale.Size = new Size(154, 22);
            filters_greyscale.Text = "Greyscale";
            filters_greyscale.Click += filters_greyscale_Click;
            // 
            // filters_sepia
            // 
            filters_sepia.Name = "filters_sepia";
            filters_sepia.Size = new Size(154, 22);
            filters_sepia.Text = "Sepia";
            filters_sepia.Click += filters_sepia_Click;
            // 
            // filters_colorInversion
            // 
            filters_colorInversion.Name = "filters_colorInversion";
            filters_colorInversion.Size = new Size(154, 22);
            filters_colorInversion.Text = "Color Inversion";
            filters_colorInversion.Click += filters_colorInverse_Click;
            // 
            // filters_histogram
            // 
            filters_histogram.Name = "filters_histogram";
            filters_histogram.Size = new Size(154, 22);
            filters_histogram.Text = "Histogram";
            filters_histogram.Click += filters_histogram_Click;
            // 
            // webcam_tab
            // 
            webcam_tab.DropDownItems.AddRange(new ToolStripItem[] { webcam_toggle });
            webcam_tab.Name = "webcam_tab";
            webcam_tab.Size = new Size(100, 20);
            webcam_tab.Text = "Webcam Mode";
            // 
            // webcam_toggle
            // 
            webcam_toggle.Name = "webcam_toggle";
            webcam_toggle.Size = new Size(128, 22);
            webcam_toggle.Text = "Toggle On";
            // 
            // subtract_tab
            // 
            subtract_tab.Name = "subtract_tab";
            subtract_tab.Size = new Size(63, 20);
            subtract_tab.Text = "Subtract";
            subtract_tab.Click += subtract_tab_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // label_source
            // 
            label_source.AutoSize = true;
            label_source.Location = new Point(159, 49);
            label_source.Name = "label_source";
            label_source.Size = new Size(43, 15);
            label_source.TabIndex = 3;
            label_source.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 4;
            label1.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label_source);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Image Processor";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem file_tab;
        private ToolStripMenuItem file_load_image;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem file_save_image;
        private ToolStripMenuItem filters_tab;
        private ToolStripMenuItem filters_copy;
        private ToolStripMenuItem filters_greyscale;
        private ToolStripMenuItem filters_colorInversion;
        private ToolStripMenuItem filters_histogram;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem filters_sepia;
        private ToolStripMenuItem webcam_tab;
        private ToolStripMenuItem webcam_toggle;
        private Label label_source;
        private Label label1;
        private ToolStripMenuItem subtract_tab;
    }
}
