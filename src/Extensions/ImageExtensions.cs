/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace cmdwtf.Dithering.Extensions
{
	public static class ImageExtensions
	{
		/// <summary>
		/// Draws an image scaled to fit into an image of a specific width and height.
		/// </summary>
		/// <param name="image">The image to fit.</param>
		/// <param name="width">The desired result image width.</param>
		/// <param name="height">The desired result image height.</param>
		/// <param name="backgroundFill">The background color to fil areas that the image does not, defaulting to transparent.</param>
		/// <returns>The result image of width and height, with the original image drawn scaled inside it.</returns>
		/// <remarks>Based on https://stackoverflow.com/a/10445101</remarks>
		public static Image FitToResolution(this Image image, int width, int height, Color? backgroundFill = null)
		{
			backgroundFill ??= Color.FromKnownColor(KnownColor.Transparent);

			// calculate correct size to draw the image to fit in the result
			float scale = Math.Min((float)width / image.Width, (float)height / image.Height);
			int scaledWidth = (int)(image.Width * scale);
			int scaledHeight = (int)(image.Height * scale);
			int imageX = (width - scaledWidth) / 2;
			int imageY = (height - scaledHeight) / 2;

			// create result and the gdi handle to draw to it with
			Bitmap result = new(width, height);
			using var graphics = Graphics.FromImage(result);
			graphics.SetHighQualityModes();

			// fill background
			graphics.Clear(backgroundFill.Value);

			// fill scaled image
			graphics.DrawImage(image, imageX, imageY, scaledWidth, scaledHeight);

			return result;
		}

		/// <summary>
		/// Resize the image to the specified width and height.
		/// </summary>
		/// <param name="image">The image to resize.</param>
		/// <param name="width">The width to resize to.</param>
		/// <param name="height">The height to resize to.</param>
		/// <returns>The resized image.</returns>
		public static Image ResizeImage(this Image image, int width, int height)
		{
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using var graphics = Graphics.FromImage(destImage);
			using var wrapMode = new ImageAttributes();

			graphics.SetHighQualityModes();
			wrapMode.SetWrapMode(WrapMode.TileFlipXY);
			graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);

			return destImage;
		}
	}
}
