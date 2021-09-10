/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

namespace cmdwtf.Dithering.Transforms
{
	/// <summary>
	/// A do-nothing pixel transformation.
	/// </summary>
	public class NopPixelTransform : IPixelTransform
	{
		public static NopPixelTransform Instance { get; } = new NopPixelTransform();

		private NopPixelTransform() { }

		public virtual string Name => GetType().Name;

		public virtual int PaletteSize => int.MaxValue;

		public ArgbColor Transform(ArgbColor[] data, ArgbColor pixel, int x, int y, int width, int height) =>
			pixel;
	}
}
