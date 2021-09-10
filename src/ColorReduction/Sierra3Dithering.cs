/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

/*
 * Sierra Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *                  *  5/32 3/32
 *      2/32 4/32 5/32 4/32 2/32
 *           2/32 3/32 2/32
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Sierra")]
	public sealed class Sierra3Dithering : ErrorDiffusionDithering
	{
		#region Constructors

		public Sierra3Dithering()
		  : base(new byte[,]
				 {
			   {
				 0, 0, 0, 5, 3
			   },
			   {
				 2, 4, 5, 4, 2
			   },
			   {
				 0, 2, 3, 2, 0
			   }
				 }, 5, true)
		{ }

		#endregion
	}
}
