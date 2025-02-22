/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

/*
 * Jarvis, Judice & Ninke Dithering
 * http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
 *
 *                  *  8/48 5/48
 *      3/48 5/48 7/48 5/48 3/48
 *      1/48 3/48 5/48 3/48 1/48
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Jarvis, Judice & Ninke")]
	public sealed class JarvisJudiceNinkeDithering : ErrorDiffusionDithering
	{
		#region Constructors

		public JarvisJudiceNinkeDithering()
		  : base(new byte[,]
				 {
			   {
				 0, 0, 0, 7, 5
			   },
			   {
				 3, 5, 7, 5, 3
			   },
			   {
				 1, 3, 5, 3, 1
			   }
				 }, 48, false)
		{ }

		#endregion
	}
}
