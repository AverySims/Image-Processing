using Emgu.CV;
using Emgu.CV.CvEnum;

namespace ImgProc.Classes
{
	public static class FilterMethods
	{
		/// <summary>
		/// Desaturates a given Mat reference.
		/// </summary>
		/// <param name="image">The Mat to desaturate.</param>
		public static void Desaturate(ref Mat image)
		{
			if (image == null)
			{
				Console.WriteLine($"{nameof(Desaturate)}(): Mat is null, please provide a valid Mat.");
				return;
			}

			// Convert the image to grayscale
			CvInvoke.CvtColor(image, image, ColorConversion.Bgr2Gray);
		}

		/// <summary>
		/// Finds and draws detected edges found in the Mat reference
		/// </summary>
		/// <param name="image">The Mat to find edges in.</param>
		public static void EdgeDetect(ref Mat image)
		{
			if (image == null)
			{
				Console.WriteLine($"{nameof(EdgeDetect)}(): Mat is null, please provide a valid Mat.");
				return;
			}

			// Apply Canny edge detection
			Mat edges = new Mat();
			CvInvoke.Canny(image, edges, 100, 200);
			image = edges;
		}
	}
}