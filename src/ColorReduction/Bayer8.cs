/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Bayer-8")]
	[Browsable(false)]
	public class Bayer8 : OrderedDithering
	{
		#region Constructors

		public Bayer8()
		  : base(new byte[,]
				{
				{  0, 48, 12, 60,  3, 51, 15, 63 },
				{ 32, 16, 44, 28, 35, 19, 47, 31 },
				{  8, 56,  4, 52, 11, 59,  7, 55 },
				{ 40, 24, 36, 20, 43, 27, 39, 23 },
				{  2, 50, 14, 62,  1, 49, 13, 61 },
				{ 34, 18, 46, 30, 33, 17, 45, 29 },
				{ 10, 58,  6, 54,  9, 57,  5, 53 },
				{ 42, 26, 38, 22, 41, 25, 37, 21 }
				})
		{ }

		#endregion
	}
}
