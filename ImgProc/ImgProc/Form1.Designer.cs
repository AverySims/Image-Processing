namespace ImgProc
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
			btnLoadImg = new Button();
			btnDesaturate = new Button();
			imgOriginal = new PictureBox();
			imgModified = new PictureBox();
			btnSaveImg = new Button();
			btnEdgeDetect = new Button();
			((System.ComponentModel.ISupportInitialize)imgOriginal).BeginInit();
			((System.ComponentModel.ISupportInitialize)imgModified).BeginInit();
			SuspendLayout();
			// 
			// btnLoadImg
			// 
			btnLoadImg.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnLoadImg.Location = new Point(75, 316);
			btnLoadImg.Name = "btnLoadImg";
			btnLoadImg.Size = new Size(256, 39);
			btnLoadImg.TabIndex = 0;
			btnLoadImg.Text = "Load Image";
			btnLoadImg.UseVisualStyleBackColor = true;
			btnLoadImg.Click += LoadImage_Click;
			// 
			// btnDesaturate
			// 
			btnDesaturate.AccessibleName = "desaturate";
			btnDesaturate.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnDesaturate.Location = new Point(471, 316);
			btnDesaturate.Name = "btnDesaturate";
			btnDesaturate.Size = new Size(256, 39);
			btnDesaturate.TabIndex = 1;
			btnDesaturate.Text = "Apply Desaturation Filter";
			btnDesaturate.UseVisualStyleBackColor = true;
			btnDesaturate.Click += ApplyFilter_Click;
			// 
			// imgOriginal
			// 
			imgOriginal.AccessibleName = "ImgOriginal";
			imgOriginal.Location = new Point(75, 54);
			imgOriginal.Name = "imgOriginal";
			imgOriginal.Size = new Size(256, 256);
			imgOriginal.SizeMode = PictureBoxSizeMode.Zoom;
			imgOriginal.TabIndex = 2;
			imgOriginal.TabStop = false;
			// 
			// imgModified
			// 
			imgModified.AccessibleName = "ImgModified";
			imgModified.Location = new Point(471, 54);
			imgModified.Name = "imgModified";
			imgModified.Size = new Size(256, 256);
			imgModified.SizeMode = PictureBoxSizeMode.Zoom;
			imgModified.TabIndex = 3;
			imgModified.TabStop = false;
			// 
			// btnSaveImg
			// 
			btnSaveImg.Location = new Point(713, 12);
			btnSaveImg.Name = "btnSaveImg";
			btnSaveImg.Size = new Size(75, 23);
			btnSaveImg.TabIndex = 4;
			btnSaveImg.Text = "Save Image";
			btnSaveImg.UseVisualStyleBackColor = true;
			btnSaveImg.Click += SaveImage_Clicked;
			// 
			// btnEdgeDetect
			// 
			btnEdgeDetect.AccessibleName = "edgeDetect";
			btnEdgeDetect.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdgeDetect.Location = new Point(471, 361);
			btnEdgeDetect.Name = "btnEdgeDetect";
			btnEdgeDetect.Size = new Size(256, 39);
			btnEdgeDetect.TabIndex = 5;
			btnEdgeDetect.Text = "Apply Edge-Detect Filter";
			btnEdgeDetect.UseVisualStyleBackColor = true;
			btnEdgeDetect.Click += ApplyFilter_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnEdgeDetect);
			Controls.Add(btnSaveImg);
			Controls.Add(imgModified);
			Controls.Add(imgOriginal);
			Controls.Add(btnDesaturate);
			Controls.Add(btnLoadImg);
			MaximumSize = new Size(816, 489);
			MinimumSize = new Size(816, 489);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)imgOriginal).EndInit();
			((System.ComponentModel.ISupportInitialize)imgModified).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnLoadImg;
		private Button btnDesaturate;
		private PictureBox imgOriginal;
		private PictureBox imgModified;
		private Button btnSaveImg;
		private Button btnEdgeDetect;
	}
}