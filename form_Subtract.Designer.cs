namespace image_process
{
    partial class form_Subtract
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
            pictureBox_foreground = new PictureBox();
            pictureBox_background = new PictureBox();
            pictureBox_result = new PictureBox();
            button_loadBackground = new Button();
            button_executeSubtraction = new Button();
            button_loadForeground = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toggle_WebcamMode = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            timer_Subtraction = new System.Windows.Forms.Timer(components);
            timer_ImageLoad = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_foreground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_result).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_foreground
            // 
            pictureBox_foreground.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_foreground.Location = new Point(38, 86);
            pictureBox_foreground.Name = "pictureBox_foreground";
            pictureBox_foreground.Size = new Size(250, 248);
            pictureBox_foreground.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_foreground.TabIndex = 0;
            pictureBox_foreground.TabStop = false;
            // 
            // pictureBox_background
            // 
            pictureBox_background.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_background.Location = new Point(306, 86);
            pictureBox_background.Name = "pictureBox_background";
            pictureBox_background.Size = new Size(250, 248);
            pictureBox_background.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_background.TabIndex = 1;
            pictureBox_background.TabStop = false;
            // 
            // pictureBox_result
            // 
            pictureBox_result.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_result.Location = new Point(574, 86);
            pictureBox_result.Name = "pictureBox_result";
            pictureBox_result.Size = new Size(250, 248);
            pictureBox_result.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_result.TabIndex = 2;
            pictureBox_result.TabStop = false;
            // 
            // button_loadBackground
            // 
            button_loadBackground.Location = new Point(397, 371);
            button_loadBackground.Name = "button_loadBackground";
            button_loadBackground.Size = new Size(75, 23);
            button_loadBackground.TabIndex = 3;
            button_loadBackground.Text = "Load";
            button_loadBackground.UseVisualStyleBackColor = true;
            button_loadBackground.Click += button_load_file_Click;
            // 
            // button_executeSubtraction
            // 
            button_executeSubtraction.Location = new Point(666, 371);
            button_executeSubtraction.Name = "button_executeSubtraction";
            button_executeSubtraction.Size = new Size(75, 23);
            button_executeSubtraction.TabIndex = 4;
            button_executeSubtraction.Text = "Subtract";
            button_executeSubtraction.UseVisualStyleBackColor = true;
            button_executeSubtraction.Click += button_execute_subtraction_Click;
            // 
            // button_loadForeground
            // 
            button_loadForeground.Location = new Point(130, 368);
            button_loadForeground.Name = "button_loadForeground";
            button_loadForeground.Size = new Size(75, 23);
            button_loadForeground.TabIndex = 5;
            button_loadForeground.Text = "Load";
            button_loadForeground.UseVisualStyleBackColor = true;
            button_loadForeground.Click += button_load_file_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toggle_WebcamMode });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(100, 20);
            toolStripMenuItem1.Text = "Webcam Mode";
            // 
            // toggle_WebcamMode
            // 
            toggle_WebcamMode.Name = "toggle_WebcamMode";
            toggle_WebcamMode.Size = new Size(180, 22);
            toggle_WebcamMode.Text = "Toggle On/Off";
            toggle_WebcamMode.Click += toggle_WebcamMode_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // form_Subtract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 435);
            Controls.Add(button_loadForeground);
            Controls.Add(button_executeSubtraction);
            Controls.Add(button_loadBackground);
            Controls.Add(pictureBox_result);
            Controls.Add(pictureBox_background);
            Controls.Add(pictureBox_foreground);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "form_Subtract";
            Text = "Image Subtraction";
            Load += form_Subtract_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_foreground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_background).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_result).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_foreground;
        private PictureBox pictureBox_background;
        private PictureBox pictureBox_result;
        private Button button_loadBackground;
        private Button button_executeSubtraction;
        private Button button_loadForeground;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toggle_WebcamMode;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer_Subtraction;
        private System.Windows.Forms.Timer timer_ImageLoad;
    }
}