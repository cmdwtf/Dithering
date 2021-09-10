/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

/*
 * Sierra Lite Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *           *  2/4
 *      1/4 1/4
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Sierra Lite")]
	public sealed class SierraLiteDithering : ErrorDiffusionDithering
	{
		#region Constructors

		public SierraLiteDithering()
		  : base(new byte[,]
				 {
			   {
				 0, 0, 2
			   },
			   {
				 1, 1, 0
			   }
				 }, 2, true)
		{ }

		#endregion
	}
}
