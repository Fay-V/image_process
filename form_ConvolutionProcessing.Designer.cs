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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem9 = new ToolStripMenuItem();
            button_LoadImage = new ToolStripMenuItem();
            button_SaveImage = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            comboBox_Filters = new ComboBox();
            textBox_Weight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_Offset = new TextBox();
            button_ExecuteFilter = new Button();
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
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(102, 20);
            toolStripMenuItem2.Text = "WebCam Mode";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Toggle On/Off (Off)";
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
            comboBox_Filters.FormattingEnabled = true;
            comboBox_Filters.Location = new Point(200, 405);
            comboBox_Filters.Name = "comboBox_Filters";
            comboBox_Filters.Size = new Size(121, 23);
            comboBox_Filters.TabIndex = 3;
            // 
            // textBox_Weight
            // 
            textBox_Weight.Location = new Point(345, 405);
            textBox_Weight.Name = "textBox_Weight";
            textBox_Weight.Size = new Size(46, 23);
            textBox_Weight.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 387);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 387);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Offset";
            // 
            // textBox_Offset
            // 
            textBox_Offset.Location = new Point(409, 405);
            textBox_Offset.Name = "textBox_Offset";
            textBox_Offset.Size = new Size(46, 23);
            textBox_Offset.TabIndex = 8;
            // 
            // button_ExecuteFilter
            // 
            button_ExecuteFilter.Location = new Point(518, 404);
            button_ExecuteFilter.Name = "button_ExecuteFilter";
            button_ExecuteFilter.Size = new Size(128, 23);
            button_ExecuteFilter.TabIndex = 9;
            button_ExecuteFilter.Text = "Execute Filter";
            button_ExecuteFilter.UseVisualStyleBackColor = true;
            // 
            // form_ConvolutionProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_ExecuteFilter);
            Controls.Add(textBox_Offset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Weight);
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
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem button_LoadImage;
        private ToolStripMenuItem button_SaveImage;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox comboBox_Filters;
        private TextBox textBox_Weight;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Offset;
        private Button button_ExecuteFilter;
    }
}