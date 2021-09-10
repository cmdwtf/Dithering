/*
 * Copyright © 2021 Chris Marc Dailey (nitz)
 *
 * Licensed under the MIT License. See LICENSE for the full text.
 */

using cmdwtf.Dithering.ColorReduction;
using cmdwtf.Dithering.Transforms;

namespace cmdwtf.Dithering
{
	public record TransformationOptions(IPixelTransform Transform, IErrorDiffusion Dither)
	{
		public TransformationOptions() : this(NopPixelTransform.Instance, NopDithering.Instance)
		{
		}
	}
}