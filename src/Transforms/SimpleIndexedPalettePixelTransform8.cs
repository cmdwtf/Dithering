/* Finding nearest colors using Euclidean distance
 * https://www.cyotek.com/blog/finding-nearest-colors-using-euclidean-distance
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2017 Cyotek Ltd.
 */

namespace cmdwtf.Dithering.Transforms
{
	public sealed class SimpleIndexedPalettePixelTransform8 : SimpleIndexedPalettePixelTransform
	{
		#region Constructors

		public SimpleIndexedPalettePixelTransform8()
		  : base(new[]
				 {
			   ArgbColor.FromArgb(0, 0, 0),
			   ArgbColor.FromArgb(255, 0, 0),
			   ArgbColor.FromArgb(0, 255, 0),
			   ArgbColor.FromArgb(0, 0, 255),
			   ArgbColor.FromArgb(255, 255, 0),
			   ArgbColor.FromArgb(255, 0, 255),
			   ArgbColor.FromArgb(0, 255, 255),
			   ArgbColor.FromArgb(255, 255, 255)
				 })
		{ }

		#endregion
	}
}
