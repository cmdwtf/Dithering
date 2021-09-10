using System.Drawing;

namespace cmdwtf.Dithering.Example
{
	internal sealed class WorkerData
	{
		public Bitmap Image { get; set; }

		public TransformationOptions TransformOptions { get; set; }

		public int ColorCount { get; set; }
	}
}
