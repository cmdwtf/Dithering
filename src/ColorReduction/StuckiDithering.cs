/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

/*
 * Stucki Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *                  *  8/42 4/42
 *      2/42 4/42 8/42 4/42 2/42
 *      1/42 2/42 4/42 2/42 1/42
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Stucki")]
	public sealed class StuckiDithering : ErrorDiffusionDithering
	{
		#region Constructors

		public StuckiDithering()
		  : base(new byte[,]
				 {
			   {
				 0, 0, 0, 8, 4
			   },
			   {
				 2, 4, 8, 4, 2
			   },
			   {
				 1, 2, 4, 2, 1
			   }
				 }, 42, false)
		{ }

		#endregion
	}
}
