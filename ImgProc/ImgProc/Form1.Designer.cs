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
			btnApplyFilter = new Button();
			imgOriginal = new PictureBox();
			imgModified = new PictureBox();
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
			// btnApplyFilter
			// 
			btnApplyFilter.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
			btnApplyFilter.Location = new Point(471, 316);
			btnApplyFilter.Name = "btnApplyFilter";
			btnApplyFilter.Size = new Size(256, 39);
			btnApplyFilter.TabIndex = 1;
			btnApplyFilter.Text = "Apply Desaturation Filter";
			btnApplyFilter.UseVisualStyleBackColor = true;
			btnApplyFilter.Click += ApplyFilter_Click;
			// 
			// imgOriginal
			// 
			imgOriginal.AccessibleName = "ImgOriginal";
			imgOriginal.Location = new Point(75, 54);
			imgOriginal.Name = "imgOriginal";
			imgOriginal.Size = new Size(256, 256);
			imgOriginal.TabIndex = 2;
			imgOriginal.TabStop = false;
			// 
			// imgModified
			// 
			imgModified.AccessibleName = "ImgModified";
			imgModified.Location = new Point(471, 54);
			imgModified.Name = "imgModified";
			imgModified.Size = new Size(256, 256);
			imgModified.TabIndex = 3;
			imgModified.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(imgModified);
			Controls.Add(imgOriginal);
			Controls.Add(btnApplyFilter);
			Controls.Add(btnLoadImg);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)imgOriginal).EndInit();
			((System.ComponentModel.ISupportInitialize)imgModified).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnLoadImg;
		private Button btnApplyFilter;
		private PictureBox imgOriginal;
		private PictureBox imgModified;
	}
}