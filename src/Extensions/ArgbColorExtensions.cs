/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.Drawing;
using System.Linq;

using cmdwtf.Dithering.ColorReduction;

using cmdwtf.Dithering.Transforms;

namespace cmdwtf.Dithering.Extensions
{
	public static class ArgbColorExtensions
	{
		/// <summary>
		/// Processes pixel data with the given transform and dither.
		/// </summary>
		/// <param name="pixelData">The data to process.</param>
		/// <param name="size">The size of the image data.</param>
		/// <param name="pixelTransform">The pixel transformation to apply.</param>
		/// <param name="dither">The dither method to apply.</param>
		public static void Process(this ArgbColor[] pixelData, Size size, IPixelTransform? pixelTransform, IErrorDiffusion? dither)
		{
			for (int row = 0; row < size.Height; row++)
			{
				for (int col = 0; col < size.Width; col++)
				{
					int index;
					ArgbColor current;
					ArgbColor transformed;

					index = row * size.Width + col;

					current = pixelData[index];

					// transform the pixel
					if (pixelTransform != null)
					{
						transformed = pixelTransform.Transform(pixelData, current, col, row, size.Width, size.Height);
						pixelData[index] = transformed;
					}
					else
					{
						transformed = current;
					}

					// apply a dither algorithm to this pixel
					dither?.Diffuse(pixelData, current, transformed, col, row, size.Width, size.Height);
				}
			}
		}


		/// <summary>
		/// Gets the number of unique colors in an <see cref="ArgbColor"/> array.
		/// </summary>
		/// <param name="pixels">The color array to look for distinct values in.</param>
		/// <returns>The number of unique colors in the array.</returns>
		public static int GetColorCount(this ArgbColor[] pixels) =>
			pixels.Select(c => c.ToArgb()).Distinct().Count();
	}
}
