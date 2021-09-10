/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

namespace cmdwtf.Dithering.ColorReduction
{
	/// <summary>
	/// A do-nothing dithering operation.
	/// </summary>
	public class NopDithering : IErrorDiffusion
	{
		public static NopDithering Instance { get; } = new NopDithering();

		public bool Prescan => false;

		private NopDithering() { }

		public void Diffuse(ArgbColor[] data, ArgbColor original, ArgbColor transformed, int x, int y, int width, int height) { }
	}
}
