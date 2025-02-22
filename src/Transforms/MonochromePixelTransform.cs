/* Pixel data transformation — Monochrome
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace cmdwtf.Dithering.Transforms
{
	public sealed class MonochromePixelTransform : IPixelTransform
	{
		#region Constants

		private static readonly ArgbColor _black =
			new(0, 0, 0);
		private static readonly ArgbColor _white =
			new(255, 255, 255);
		private readonly byte _threshold;

		#endregion

		#region Constructors

		public MonochromePixelTransform(byte threshold)
		{
			_threshold = threshold;
		}

		#endregion

		#region IPixelTransform Interface

		public string Name => GetType().Name;

		public IReadOnlyCollection<ArgbColor> Palette { get; } = new ReadOnlyCollection<ArgbColor>(new ArgbColor[] { _black, _white });

		public int PaletteSize => 2;

		public ArgbColor Transform(ArgbColor[] data, ArgbColor pixel, int x, int y, int width, int height)
		{
			byte gray;

			gray = (byte)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

			/*
			 * I'm leaving the alpha channel untouched instead of making it fully opaque
			 * otherwise the transparent areas become fully black, and I was getting annoyed
			 * by this when testing images with large swathes of transparency!
			 */

			return gray < _threshold ? _black : _white;
		}

		#endregion
	}
}
