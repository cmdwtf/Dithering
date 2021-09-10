/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace cmdwtf.Dithering.Transforms
{
	/// <summary>
	/// A do-nothing pixel transformation.
	/// </summary>
	public sealed class NopPixelTransform : IPixelTransform
	{
		public static NopPixelTransform Instance { get; } = new NopPixelTransform();

		private NopPixelTransform() { }

		public string Name => GetType().Name;

		public IReadOnlyCollection<ArgbColor> Palette { get; } = new ReadOnlyCollection<ArgbColor>(System.Array.Empty<ArgbColor>());

		public int PaletteSize => int.MaxValue;

		public ArgbColor Transform(ArgbColor[] data, ArgbColor pixel, int x, int y, int width, int height) =>
			pixel;
	}
}
