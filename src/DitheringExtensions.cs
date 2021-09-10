/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.Drawing;

using cmdwtf.Dithering.Extensions;

namespace cmdwtf.Dithering
{
	/// <summary>
	/// A public interface to easily access common dithering methods.
	/// </summary>
	public static class DitheringExtensions
	{
		public static Bitmap TransformImage(this Bitmap image, TransformationOptions options)
		{
			ArgbColor[] pixels = image.GetPixelsFrom32BitArgbImage();
			Size size = image.Size;

			if (options.Dither != null && options.Dither.Prescan)
			{
				// pre-handle dithering if it needs to happen before primary transform
				pixels.Process(size, null, options.Dither);
			}

			// transform and dither each pixel
			pixels.Process(size, options.Transform, options.Dither);

			// create the resultant bitmap
			Bitmap result = pixels.ToBitmap(size);

			// all done!
			return result;
		}
	}
}
