namespace SteganographyTest
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
            this.HT = new System.Windows.Forms.Button();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.GT = new System.Windows.Forms.Button();
            this.MainText = new System.Windows.Forms.TextBox();
            this.chooseFile = new System.Windows.Forms.Button();
            this.saveImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // HT
            // 
            this.HT.Enabled = false;
            this.HT.Location = new System.Drawing.Point(12, 12);
            this.HT.Name = "HT";
            this.HT.Size = new System.Drawing.Size(94, 29);
            this.HT.TabIndex = 0;
            this.HT.Text = "HideText";
            this.HT.UseVisualStyleBackColor = true;
            this.HT.Click += new System.EventHandler(this.HT_Click);
            // 
            // MainImage
            // 
            this.MainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainImage.Location = new System.Drawing.Point(155, 12);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(415, 282);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 1;
            this.MainImage.TabStop = false;
            // 
            // GT
            // 
            this.GT.Enabled = false;
            this.GT.Location = new System.Drawing.Point(12, 47);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(94, 29);
            this.GT.TabIndex = 2;
            this.GT.Text = "GetText";
            this.GT.UseVisualStyleBackColor = true;
            this.GT.Click += new System.EventHandler(this.GT_Click);
            // 
            // MainText
            // 
            this.MainText.Location = new System.Drawing.Point(155, 300);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(415, 27);
            this.MainText.TabIndex = 3;
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(12, 82);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(94, 29);
            this.chooseFile.TabIndex = 4;
            this.chooseFile.Text = "ChooseFile";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // saveImage
            // 
            this.saveImage.Enabled = false;
            this.saveImage.Location = new System.Drawing.Point(12, 117);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(94, 29);
            this.saveImage.TabIndex = 5;
            this.saveImage.Text = "SaveImage";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 339);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.MainImage);
            this.Controls.Add(this.HT);
            this.Name = "Form1";
            this.Text = "PictureEncryptor";
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HT;
        private PictureBox MainImage;
        private Button GT;
        private TextBox MainText;
        private Button chooseFile;
        private Button saveImage;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}