/* Pixel data transformation
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

namespace cmdwtf.Dithering.Transforms
{
	public interface IPixelTransform
	{
		#region Methods

		ArgbColor Transform(ArgbColor[] data, ArgbColor pixel, int x, int y, int width, int height);

		#endregion
	}
}
