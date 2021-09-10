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
	[Description("Bayer-3")]
	[Browsable(false)]
	public class Bayer3 : OrderedDithering
	{
		#region Constructors

		public Bayer3()
		  : base(new byte[,]
				 {
			   { 0, 7, 3 },
			   { 6, 5, 2 },
			   { 4, 1, 8 }
				 })
		{ }

		#endregion
	}
}
