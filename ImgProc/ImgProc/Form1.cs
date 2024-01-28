using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using ImgProc.Classes;

namespace ImgProc
{
	/* 
	 * Project requires the following NuGet packages:
	 * Emgu.CV
	 * Emgu.CV.Bitmap
	 * Emgu.CV.runtime.windows
	 */
	public partial class Form1 : Form
	{
		private Mat? _matOriginal;
		private Mat? _matModified;

		public Form1()
		{
			InitializeComponent();
		}

		private void LoadImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image File (*.png,*.jpg,*.bmp)| *.png;*.jpg;*.bmp";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				// load image file to CV material
				_matOriginal = CvInvoke.Imread(ofd.FileName);

				// convert CV material to bitmap for WinForm images
				imgOriginal.Image = _matOriginal.ToBitmap();

				// clear existing
				DisposeFilteredImage();

				// Debug statement
				Console.WriteLine(ofd.FileName);
			}
		}

		private void ApplyFilter_Click(object sender, EventArgs e)
		{
			// convert the sender to a button for later use
			Button filterButton = (Button)sender;

			// make sure the image we are copying is valid
			if (_matOriginal == null || _matOriginal.IsEmpty)
			{
				Console.WriteLine("Cannot apply image filter to an empty image, " +
					"please select a valid image file before applying a filter.");
				return;
			}

			// pre-dispose the image we will be modifying
			DisposeFilteredImage();

			// clone the original image to the modifiable one
			_matModified = _matOriginal.Clone();

			if (filterButton != null) Console.WriteLine(filterButton.AccessibleName);

			// select the filter based on the name given to the button
			switch (filterButton?.AccessibleName)
			{
				case "edgeDetect":
					FilterMethods.EdgeDetect(ref _matModified);
					break;
				case "desaturate":
					FilterMethods.Desaturate(ref _matModified);
					break;
				default:
					Console.WriteLine("Button type not specified");
					return;
			}

			// if the modified image is valid, apply it to the image box
			if (_matModified != null && !_matModified.IsEmpty) imgModified.Image = _matModified.ToBitmap();
		}

		private void SaveImage_Clicked(object sender, EventArgs e)
		{
			// make sure our image is valid
			if (imgModified == null || imgModified.Image == null)
			{
				Console.WriteLine("Cannot save an empty image, " +
					"please create an image before trying to save a new image.");
				return;
			}

			// init a save file dialog
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "PNG Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
			sfd.Title = "Save an Image File";
			sfd.ShowDialog();

			// If the file name is not an empty string open it for saving.
			if (sfd.FileName != "")
			{
				// Saves the Image via a FileStream created by the OpenFile method.
				FileStream fs = (FileStream)sfd.OpenFile();

				// Saves the appropriate image type based on the file type selected in the dialog box.
				switch (sfd.FilterIndex)
				{
					case 1:
						imgModified.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
						break;

					case 2:
						imgModified.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
						break;

					case 3:
						imgModified.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
						break;

					case 4:
						imgModified.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
						break;
				}

				// close the file stream
				fs.Close();
			}
		}

		/// <summary>
		/// Clears any references related to the modified images
		/// </summary>
		private void DisposeFilteredImage()
		{
			if (_matModified != null) _matModified?.Dispose();
			imgModified.Image = null;
		}
	}
}