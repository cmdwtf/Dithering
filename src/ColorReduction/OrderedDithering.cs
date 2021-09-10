/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System;

namespace cmdwtf.Dithering.ColorReduction
{
	public abstract class OrderedDithering : IErrorDiffusion
	{
		#region Constants

		private readonly byte[,] _matrix;

		private readonly byte _matrixHeight;

		private readonly byte _matrixWidth;

		#endregion

		#region Constructors

		protected OrderedDithering(byte[,] matrix)
		{
			int max;
			int scale;

			if (matrix == null)
			{
				throw new ArgumentNullException(nameof(matrix));
			}

			if (matrix.Length == 0)
			{
				throw new ArgumentException("Matrix is empty.", nameof(matrix));
			}

			_matrixWidth = (byte)(matrix.GetUpperBound(1) + 1);
			_matrixHeight = (byte)(matrix.GetUpperBound(0) + 1);

			max = _matrixWidth * _matrixHeight;
			scale = 255 / max;

			_matrix = new byte[_matrixHeight, _matrixWidth];

			for (int x = 0; x < _matrixWidth; x++)
			{
				for (int y = 0; y < _matrixHeight; y++)
				{
					_matrix[x, y] = Clamp(matrix[x, y] * scale);
				}
			}

		}

		#endregion

		#region Static Methods

		private static byte Clamp(int value)
		{
			byte result;

			if (value < 0)
			{
				result = 0;
			}
			else if (value > 255)
			{
				result = 255;
			}
			else
			{
				result = Convert.ToByte(value);
			}

			return result;
		}

		#endregion

		#region IErrorDiffusion Interface

		void IErrorDiffusion.Diffuse(ArgbColor[] data, ArgbColor original, ArgbColor transformed, int x, int y, int width, int height)
		{
			int row;
			int col;
			byte threshold;

			col = x % _matrixWidth;
			row = y % _matrixHeight;

			threshold = _matrix[col, row];

			if (threshold > 0)
			{
				byte r;
				byte g;
				byte b;

				r = Clamp(transformed.R + threshold);
				g = Clamp(transformed.G + threshold);
				b = Clamp(transformed.B + threshold);

				data[y * width + x] = ArgbColor.FromArgb(original.A, r, g, b);
			}
		}

		bool IErrorDiffusion.Prescan
		{
			get { return true; }
		}

		#endregion
	}
}
