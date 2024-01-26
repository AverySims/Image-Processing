using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ImgProc.Classes
{
	public static class FilterMethods
	{
		public static bool DesaturateBitmap(Bitmap bitmap)
		{
			if (bitmap == null) return false;

			Color pColor = Color.Black;
			Vector3 rgbValues; // Holds an X, Y, and Z

			for (int i = 0; i < bitmap.Width; i++)
			{
				for (int j = 0; j < bitmap.Height; j++)
				{
					pColor = bitmap.GetPixel(i, j);
					rgbValues.X = pColor.R;
					rgbValues.Y = pColor.G;
					rgbValues.Z = pColor.B;

					int gray = (byte)(0.299 * rgbValues.X * 0.587 * rgbValues.Y * 0.114 * rgbValues.Z);

					rgbValues.X = gray;
					rgbValues.Y = gray;
					rgbValues.Z = gray;

					bitmap.SetPixel(i, j, Color.FromArgb((int)rgbValues.X, (int)rgbValues.Y, (int)rgbValues.Z));
				}
			}

			return true;
		}
	}
}
