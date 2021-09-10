/* Even more algorithms for dithering images using C#
 * https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp
 *
 * Copyright © 2021 Chris Marc Dailey (nitz)
 * Copyright © 2015 Cyotek Ltd.
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

/*
 * Atkinson Dithering
 * http://www.tannerhelland.com/4660/dithering-eleven-algorithms-source-code/
 *
 *           *  1/8 1/8
 *      1/8 1/8 1/8
 *          1/8
 */

using System.ComponentModel;

namespace cmdwtf.Dithering.ColorReduction
{
	[Description("Atkinson")]
	public sealed class AtkinsonDithering : ErrorDiffusionDithering
	{
		#region Constructors

		public AtkinsonDithering()
		  : base(new byte[,]
				 {
			   {
				 0, 0, 1, 1
			   },
			   {
				 1, 1, 1, 0
			   },
			   {
				 0, 1, 0, 0
			   }
				 }, 3, true)
		{ }

		#endregion
	}
}
