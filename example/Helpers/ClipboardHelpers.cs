/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using cmdwtf.Dithering.Extensions;

namespace cmdwtf.Dithering.Example.Helpers
{
	internal static class ClipboardHelpers
	{
		#region Constants

		public const string PngFormat = "PNG";

		#endregion

		#region Static Methods

		public static void CopyImage(Bitmap image)
		{
			if (image != null)
			{
				try
				{
					Clipboard.SetImage(image);
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("Failed to copy image. {0}", ex.GetBaseException().Message), "Copy Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Nothing to copy.", "Copy Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public static Bitmap GetImage()
		{
			Bitmap result;

			// http://csharphelper.com/blog/2014/09/paste-a-png-format-image-with-a-transparent-background-from-the-clipboard-in-c/

			result = null;

			try
			{
				if (Clipboard.ContainsData(PngFormat))
				{
					object data;

					data = Clipboard.GetData(PngFormat);

					if (data != null)
					{
						Stream stream;

						stream = data as MemoryStream;

						if (stream == null)
						{
							byte[] buffer;

							buffer = data as byte[];

							if (buffer != null)
							{
								stream = new MemoryStream(buffer);
							}
						}

						if (stream != null)
						{
							result = Image.FromStream(stream).Copy();

							stream.Dispose();
						}
					}
				}

				if (result == null)
				{
					result = (Bitmap)Clipboard.GetImage();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Failed to obtain image. {0}", ex.GetBaseException().Message), "Paste Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return result;
		}

		#endregion
	}
}
