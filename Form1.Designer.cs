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
            mapImage = new PictureBox();
            clearMarkerButton = new Button();
            findPathButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mapImage).BeginInit();
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
            // 
            // mapImage
            // 
            mapImage.Location = new Point(12, 41);
            mapImage.Name = "mapImage";
            mapImage.Size = new Size(1256, 667);
            mapImage.TabIndex = 1;
            mapImage.TabStop = false;
            mapImage.MouseClick += addMarkerClick;
            // 
            // clearMarkerButton
            // 
            clearMarkerButton.Location = new Point(181, 12);
            clearMarkerButton.Name = "clearMarkerButton";
            clearMarkerButton.Size = new Size(163, 23);
            clearMarkerButton.TabIndex = 2;
            clearMarkerButton.Text = "Clear Markers";
            clearMarkerButton.UseVisualStyleBackColor = true;
            clearMarkerButton.Click += clearMarkers;
            // 
            // findPathButton
            // 
            findPathButton.Location = new Point(350, 12);
            findPathButton.Name = "findPathButton";
            findPathButton.Size = new Size(163, 23);
            findPathButton.TabIndex = 3;
            findPathButton.Text = "Find shortest Path";
            findPathButton.UseVisualStyleBackColor = true;
            findPathButton.Click += findShortestPath;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(clearMarkerButton);
            Controls.Add(mapImage);
            Controls.Add(loadImgButton);
            Controls.Add(findPathButton);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)mapImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button loadImgButton;
        private OpenFileDialog openFileDialog1;
        private PictureBox mapImage;
        private Button clearMarkerButton;
        private Button findPathButton;
    }
}
