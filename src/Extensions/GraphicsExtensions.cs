using System.Drawing;
using System.Drawing.Drawing2D;

namespace cmdwtf.Dithering.Extensions
{
	internal static class GraphicsExtensions
	{
		/// <summary>
		/// Sets a common set of high quality render modes for the given graphics object.
		/// </summary>
		/// <param name="graphics">The graphics object to set the high quality modes on.</param>
		public static void SetHighQualityModes(this Graphics graphics)
		{
			graphics.CompositingMode = CompositingMode.SourceCopy;
			graphics.CompositingQuality = CompositingQuality.HighQuality;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		}
	}
}
