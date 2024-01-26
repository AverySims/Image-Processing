namespace ImgProc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void LoadImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image File (*.bmp,*.png)| *.bmp;*.png";

			if (DialogResult.OK == ofd.ShowDialog())
			{
				imgOriginal.Image = new Bitmap(ofd.FileName);
			}
		}

		private void ApplyFilter_Click(object sender, EventArgs e)
		{

		}
	}
}