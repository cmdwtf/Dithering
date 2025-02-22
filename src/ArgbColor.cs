using System.Runtime.InteropServices;

/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015-2017 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

namespace cmdwtf.Dithering
{
	/// <summary>
	/// Represents an ARGB (alpha, red, green, blue) color.
	/// </summary>
	/// <remarks>The color of each pixel is represented as a 32-bit number: 8 bits each for alpha, red, green, and blue (ARGB). Each of the four components is a number from 0 through 255, with 0 representing no intensity and 255 representing full intensity. The alpha component specifies the transparency of the color: 0 is fully transparent, and 255 is fully opaque. To determine the alpha, red, green, or blue component of a color, use the A, R, G, or B property, respectively.</remarks>
	[StructLayout(LayoutKind.Explicit)]
	public struct ArgbColor
	{
		[FieldOffset(0)]
		private readonly int _value;

		/// <summary>
		/// Gets the blue component value of this <see cref="ArgbColor"/> structure.
		/// </summary>
		[FieldOffset(0)]
		public byte B;

		/// <summary>
		/// Gets the green component value of this <see cref="ArgbColor"/> structure.
		/// </summary>
		[FieldOffset(1)]
		public byte G;

		/// <summary>
		/// Gets the red component value of this <see cref="ArgbColor"/> structure.
		/// </summary>
		[FieldOffset(2)]
		public byte R;

		/// <summary>
		/// Gets the alpha component value of this <see cref="ArgbColor"/> structure.
		/// </summary>
		[FieldOffset(3)]
		public byte A;

		public ArgbColor(int red, int green, int blue)
		  : this(255, red, green, blue)
		{ }

		public ArgbColor(int alpha, int red, int green, int blue)
		  : this()
		{
			A = (byte)alpha;
			R = (byte)red;
			G = (byte)green;
			B = (byte)blue;
		}

		internal static ArgbColor FromArgb(byte a, byte r, byte g, byte b)
			=> new(a, r, g, b);

		internal static ArgbColor FromArgb(byte r, byte g, byte b)
			=> new(r, g, b);

		public int ToArgb() => _value;

		/// <summary>
		/// Creates a <see cref="System.Drawing.Color"/> from this instance.
		/// </summary>
		/// <returns>A System.Drawing.Color that represents the same color as this instance.</returns>
		public System.Drawing.Color ToDrawingColor()
			=> System.Drawing.Color.FromArgb(_value);


		public static implicit operator System.Drawing.Color(ArgbColor c)
			=> c.ToDrawingColor();
	}
}
