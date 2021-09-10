/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

namespace cmdwtf.Dithering.Transforms
{
	public sealed class SimpleIndexedPalettePixelTransformInky : SimpleIndexedPalettePixelTransform
	{
		/// <summary>
		/// A constructor to forward a map to the base class constructor.
		/// </summary>
		/// <param name="map">The map to use for the palette.</param>
		private SimpleIndexedPalettePixelTransformInky(ArgbColor[] map) : base(map)
		{
		}

		/// <summary>
		/// A constructor for making a palette with black and white.
		/// </summary>
		private SimpleIndexedPalettePixelTransformInky()
			: this(new[]
			{
				ArgbColor.FromArgb(0, 0, 0), // black
				ArgbColor.FromArgb(255, 255, 255), // white
			})
		{ }

		/// <summary>
		/// A constructor for making a palette with black, white, and any third color.
		/// </summary>
		/// <param name="thirdColor">The third color of the palette.</param>
		private SimpleIndexedPalettePixelTransformInky(ArgbColor thirdColor)
			: this(new[]
			{
				ArgbColor.FromArgb(0, 0, 0), // black
				ArgbColor.FromArgb(255, 255, 255), // white
				thirdColor, // the third palette color, whatever it may be
			})
		{ }

		/// <summary>
		/// A color palette suitable for a two color Inky display.
		/// Display: https://shop.pimoroni.com/products/inky-phat?variant=12549254938707
		/// Display: https://shop.pimoroni.com/products/inky-what?variant=21214020436051
		/// </summary>
		public static SimpleIndexedPalettePixelTransformInky Inky2 =>
			new();

		/// <summary>
		/// A color palette suitable for a two color Inky display.
		/// Display: https://shop.pimoroni.com/products/inky-phat?variant=12549254217811
		/// Display: https://shop.pimoroni.com/products/inky-what?variant=13590497624147
		/// Display: https://shop.pimoroni.com/products/inky-bit
		/// </summary>
		public static SimpleIndexedPalettePixelTransformInky Inky3Red =>
			new(
				ArgbColor.FromArgb(255, 0, 0) // red
				);

		/// <summary>
		/// A color palette suitable for a two color Inky display.
		/// Display: https://shop.pimoroni.com/products/inky-phat?variant=12549254905939
		/// Display: https://shop.pimoroni.com/products/inky-what?variant=21441988558931
		/// </summary>
		public static SimpleIndexedPalettePixelTransformInky Inky3Yellow =>
			new(
				ArgbColor.FromArgb(255, 255, 0) // yellow
				);

		/// <summary>
		/// A color palette suitable for the Inky Impression 7 color display.
		/// Display: https://pimoroni.com/impression
		/// </summary>
		/// <remarks>
		/// The order of the color in the palette is important: https://github.com/pimoroni/inky/issues/115#issuecomment-877007007
		/// Based on the colors from https://github.com/pimoroni/inky/blob/fa59811bb5a9aad9eac82da3e58b6dc2ead75b8c/library/inky/inky_uc8159.py#L26-L46
		/// </remarks>
		public static SimpleIndexedPalettePixelTransformInky InkyImpression7 =>
			new(new[]
			{
				ArgbColor.FromArgb(0, 0, 0), // black
				ArgbColor.FromArgb(255, 255, 255), // white
				ArgbColor.FromArgb(0, 255, 0), // green
				ArgbColor.FromArgb(0, 0, 255), // blue
				ArgbColor.FromArgb(255, 0, 0), // red
				ArgbColor.FromArgb(255, 255, 0), // yellow
				ArgbColor.FromArgb(255, 140, 0), // orange
				ArgbColor.FromArgb(255, 255, 255), // white
			});

		/// <summary>
		/// A more 'saturated' color palette than <see cref="InkyImpression7"/>.
		/// Display: https://pimoroni.com/impression
		/// </summary>
		/// <remarks>
		/// The order of the color in the palette is important: https://github.com/pimoroni/inky/issues/115#issuecomment-877007007
		/// Based on the colors from https://github.com/pimoroni/inky/blob/fa59811bb5a9aad9eac82da3e58b6dc2ead75b8c/library/inky/inky_uc8159.py#L26-L46
		/// </remarks>
		public static SimpleIndexedPalettePixelTransformInky InkyImpression7Saturated =>
			new(new[]
			{
				ArgbColor.FromArgb(57, 48, 57), // black
				ArgbColor.FromArgb(255, 255, 255), // white
				ArgbColor.FromArgb(58, 91, 70), // green
				ArgbColor.FromArgb(61, 59, 94), // blue
				ArgbColor.FromArgb(156, 72, 75), // red
				ArgbColor.FromArgb(208, 190, 71), // yellow
				ArgbColor.FromArgb(177, 106, 73), // orange
				ArgbColor.FromArgb(255, 255, 255), // white
			});
	}
}