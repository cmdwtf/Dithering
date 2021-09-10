Image Dithering using C#
========================

This sample program demonstrates how to use various algorithms to dither an image using C#.

![Sample program screenshot](dithering-atkinson.png)

Please refer to the following articles on cyotek.com for more details

* [An introduction to dithering images](https://www.cyotek.com/blog/an-introduction-to-dithering-images)
* [Dithering an image using the Floyd–Steinberg algorithm in C#](https://www.cyotek.com/blog/dithering-an-image-using-the-floyd-steinberg-algorithm-in-csharp)
* [Dithering an image using the Burkes algorithm in C#](https://www.cyotek.com/blog/dithering-an-image-using-the-burkes-algorithm-in-csharp)
* [Even more algorithms for dithering images using C#](https://www.cyotek.com/blog/even-more-algorithms-for-dithering-images-using-csharp)
* [Finding nearest colors using Euclidean distance](https://www.cyotek.com/blog/finding-nearest-colors-using-euclidean-distance)

Resources
---------
`DHALF.TXT` was obtained from <http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT>
`DITHER.TXT` was obtained from <http://cd.textfiles.com/graphics16000/FORMATS/GIF/DITHER2.TXT>

Referenced, but missing - if you find copies of these documents let [me know!](https://github.com/cyotek/Dithering/issues)

* BURKES.ARC
* NUDTHR.ARC
* IDTVGA.TXT
* DGIF.ZIP

Screenshots
-----------

An example of Atkinson error diffusion, this time used in conjunction with a 256 fixed palette quantization.

![dithering-atkinson-color](dithering-atkinson-color.png)

An example of ordering dithering using an 8x8 Bayer matrix, demonstrating the classic hatching patterns associated with this style of dithering.

![dithering-bayer8](dithering-bayer8.png)
