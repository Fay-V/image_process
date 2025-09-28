namespace image_process
{
    partial class form_ConvolutionProcessing
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem9 = new ToolStripMenuItem();
            button_LoadImage = new ToolStripMenuItem();
            button_SaveImage = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menu_WebCamToggle = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            comboBox_Filters = new ComboBox();
            label1 = new Label();
            button_ExecuteFilter = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem9, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.DropDownItems.AddRange(new ToolStripItem[] { button_LoadImage, button_SaveImage });
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(37, 20);
            toolStripMenuItem9.Text = "File";
            // 
            // button_LoadImage
            // 
            button_LoadImage.Name = "button_LoadImage";
            button_LoadImage.Size = new Size(136, 22);
            button_LoadImage.Text = "Load Image";
            button_LoadImage.Click += button_LoadImage_Click;
            // 
            // button_SaveImage
            // 
            button_SaveImage.Name = "button_SaveImage";
            button_SaveImage.Size = new Size(136, 22);
            button_SaveImage.Text = "Save Image";
            button_SaveImage.Click += button_SaveImage_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { menu_WebCamToggle });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(102, 20);
            toolStripMenuItem2.Text = "WebCam Mode";
            // 
            // menu_WebCamToggle
            // 
            menu_WebCamToggle.Name = "menu_WebCamToggle";
            menu_WebCamToggle.Size = new Size(180, 22);
            menu_WebCamToggle.Text = "Toggle On/Off (Off)";
            menu_WebCamToggle.Click += menu_WebcamToggle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(37, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(426, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(308, 287);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox_Filters
            // 
            comboBox_Filters.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Filters.FormattingEnabled = true;
            comboBox_Filters.Location = new Point(200, 405);
            comboBox_Filters.Name = "comboBox_Filters";
            comboBox_Filters.Size = new Size(157, 23);
            comboBox_Filters.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 387);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Selected Filter";
            // 
            // button_ExecuteFilter
            // 
            button_ExecuteFilter.Location = new Point(518, 404);
            button_ExecuteFilter.Name = "button_ExecuteFilter";
            button_ExecuteFilter.Size = new Size(128, 23);
            button_ExecuteFilter.TabIndex = 9;
            button_ExecuteFilter.Text = "Execute Filter";
            button_ExecuteFilter.UseVisualStyleBackColor = true;
            button_ExecuteFilter.Click += button_ExecuteFilters_Click;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // form_ConvolutionProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_ExecuteFilter);
            Controls.Add(label1);
            Controls.Add(comboBox_Filters);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "form_ConvolutionProcessing";
            Text = "Convolution Image Processing";
            Load += form_ConvolutionProcessing_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem menu_WebCamToggle;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem button_LoadImage;
        private ToolStripMenuItem button_SaveImage;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox comboBox_Filters;
        private Label label1;
        private Button button_ExecuteFilter;
        private System.Windows.Forms.Timer timer1;
    }
}