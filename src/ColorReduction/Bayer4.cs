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
	[Description("Bayer-4")]
	[Browsable(false)]
	public class Bayer4 : OrderedDithering
	{
		#region Constructors

		public Bayer4()
		  : base(new byte[,]
				 {
			   {  0,  8,  2, 10 },
			   { 12,  4, 14,  6 },
			   {  3, 11,  1,  9 },
			   { 15,  7, 13,  5 }
				 })
		{ }

		#endregion
	}
}
