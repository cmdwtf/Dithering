/* Dithering an image using the Floyd–Steinberg algorithm in C#
 * https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Floyd-Steinberg")]
	public sealed class FloydSteinbergDithering : ErrorDiffusionDithering
	{
		#region Constructors

		public FloydSteinbergDithering()
		  : base(new byte[,]
				 {
			   {
				 0, 0, 7
			   },
			   {
				 3, 5, 1
			   }
				 }, 4, true)
		{ }

		#endregion
	}
}
