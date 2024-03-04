namespace RouteFindingOnMaps
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
            loadImgButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loadImgButton
            // 
            loadImgButton.Location = new Point(12, 12);
            loadImgButton.Name = "loadImgButton";
            loadImgButton.Size = new Size(163, 23);
            loadImgButton.TabIndex = 0;
            loadImgButton.Text = "Load Image";
            loadImgButton.UseVisualStyleBackColor = true;
            loadImgButton.Click += loadImageButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1256, 667);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pictureBox1);
            Controls.Add(loadImgButton);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button loadImgButton;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
    }
}
