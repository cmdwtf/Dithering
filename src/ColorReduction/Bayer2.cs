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
	[Description("Bayer-2")]
	[Browsable(false)]
	public class Bayer2 : OrderedDithering
	{
		#region Constructors

		public Bayer2()
		  : base(new byte[,]
				 {
			   { 0, 2 },
			   { 3, 1 }
				 })
		{ }

		#endregion
	}
}
