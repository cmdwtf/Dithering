/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.Drawing;
using System.Drawing.Imaging;

namespace cmdwtf.Dithering.Extensions
{
	public static class BitmapExtensions
	{
		/// <summary>
		/// Creates a bitmap that is a copy of an image.
		/// </summary>
		/// <param name="image">The image to copy.</param>
		/// <returns>The resultant bitmap.</returns>
		public static Bitmap Copy(this Image image)
		{
			Bitmap copy;

			copy = new Bitmap(image.Size.Width, image.Size.Height, PixelFormat.Format32bppArgb);

			using Graphics g = Graphics.FromImage(copy);

			g.Clear(Color.Transparent);
			g.PageUnit = GraphicsUnit.Pixel;
			g.SetHighQualityModes();
			g.DrawImage(image, new Rectangle(Point.Empty, image.Size));


			return copy;
		}


		/// <summary>
		/// Creates a bitmap based on an array of <see cref="ArgbColor"/>s.
		/// </summary>
		/// <param name="data">The data to create a bitmap of.</param>
		/// <param name="size">The size of the bitmap to create.</param>
		/// <returns>The new bitmap.</returns>
		public static Bitmap ToBitmap(this ArgbColor[] data, Size size)
		{
			int height;
			int width;
			BitmapData bitmapData;
			Bitmap result;

			// Based on code from http://blog.biophysengr.net/2011/11/rapid-bitmap-access-using-unsafe-code.html

			result = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
			width = result.Width;
			height = result.Height;

			// Lock the entire bitmap
			bitmapData = result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

			//Enter unsafe mode so that we can use pointers
			unsafe
			{
				ArgbColor* pixelPtr;

				// Get a pointer to the beginning of the pixel data region
				// The upper-left corner
				pixelPtr = (ArgbColor*)bitmapData.Scan0;

				// Iterate through rows and columns
				for (int row = 0; row < size.Height; row++)
				{
					for (int col = 0; col < size.Width; col++)
					{
						int index;
						ArgbColor color;

						index = row * size.Width + col;
						color = data[index];

						// Set the pixel (fast!)
						*pixelPtr = color;

						// Update the pointer
						pixelPtr++;
					}
				}
			}

			// Unlock the bitmap
			result.UnlockBits(bitmapData);

			return result;
		}

		/// <summary>
		/// Creates an <see cref="ArgbColor"/> array based on the image data in the given bitmap.
		/// </summary>
		/// <param name="bitmap">The bitmap to create the array from.</param>
		/// <returns>The resultant array.</returns>
		public static ArgbColor[] GetPixelsFrom32BitArgbImage(this Bitmap bitmap)
		{
			int width;
			int height;
			BitmapData bitmapData;
			ArgbColor[] results;

			// NOTE: As the name should give a hint, it only supports 32bit ARGB images.
			// Don't rely on this for production, it needs expanding to support multiple other types

			width = bitmap.Width;
			height = bitmap.Height;
			results = new ArgbColor[width * height];
			bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

			unsafe
			{
				ArgbColor* pixel;

				pixel = (ArgbColor*)bitmapData.Scan0;

				for (int row = 0; row < height; row++)
				{
					for (int col = 0; col < width; col++)
					{
						results[row * width + col] = *pixel;

						pixel++;
					}
				}
			}

			bitmap.UnlockBits(bitmapData);

			return results;
		}
	}
}
