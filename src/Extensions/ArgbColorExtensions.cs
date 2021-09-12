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

					index = (row * size.Width) + col;

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

		/// <summary>
		/// Linearly interpolates between by the amount specified. The result is unclamped.
		/// This method *does* guarantee result = value1 when t = 1. However, this method is
		/// *only* monotonic when (value0 * value1 < 0). Lerping between the same values might not produce
		/// the same result.
		/// If you need the result to be monotonic, use  <see cref="LerpMonotonic(double, double, double)"/>
		/// instead.
		/// </summary>
		/// <param name="value0">The start value.</param>
		/// <param name="value1">The end value.</param>
		/// <param name="t">The amount of way to interpolate where 0.0f is the start value, and 1.0f is the end value.</param>
		/// <returns>The interpolated value.</returns>
		/// <remarks>See also: https://en.wikipedia.org/wiki/Linear_interpolation#Programming_language_support </remarks>
		public static double Lerp(this double value0, double value1, double t)
			=> ((1 - t) * value0) + (t * value1);

		/// <inheritdoc cref="Lerp(double, double, double)"/>
		public static float Lerp(this float value0, float value1, float t)
			=> ((1 - t) * value0) + (t * value1);


		/// <summary>
		/// A color based linear interpolation.
		/// </summary>
		/// <param name="color">The color to lerp from.</param>
		/// <param name="to">The color to lerp to.</param>
		/// <param name="amount">The amount of distance to lerp, as a value from 0.0f-1.0f. This value is unclamped.</param>
		/// <returns>The interpolated color.</returns>
		public static ArgbColor Lerp(this ArgbColor color, ArgbColor to, float amount)
		{
			// start colors as lerp-able floats
			float sr = color.R, sg = color.G, sb = color.B, sa = color.A;

			// end colors as lerp-able floats
			float er = to.R, eg = to.G, eb = to.B, ea = to.A;

			// lerp the colors to get the difference
			byte r = (byte)sr.Lerp(er, amount),
				 g = (byte)sg.Lerp(eg, amount),
				 b = (byte)sb.Lerp(eb, amount),
				 a = (byte)sa.Lerp(ea, amount);

			// return the new color
			return ArgbColor.FromArgb(a, r, g, b);
		}
	}
}
