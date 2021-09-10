# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.2.0] - 2020-09-10
### Added
- Added `Palette` property to `IPixelTransform`.

### Fixed
- `NopPixelTransform` correctly made sealed.

## [1.1.0] - 2020-09-10
### Added
- Added `PaletteSize` property to `IPixelTransform`.

## [1.0.1] - 2020-09-10
### Added
- Added `Name` property to `IErrorDiffusion` and `IPixelTransform`.

## [1.0.0] - 2020-09-10
### Added
- Initial release, based on [cyotek/Dithering 5fb11e7](https://github.com/cyotek/Dithering/tree/5fb11e7fddcec99bf848fe3a21779ebb18d78d69)
- Added `SimpleIndexedPalettePixelTransformInky` for [Pimoroni "Inky" eInk displays](https://shop.pimoroni.com/collections/pimoroni?filter=e-ink+Displays).
- Added functionality based on the example application to make invoking dithering transformations easier for a user.
- Added `Nop` ditherer and transform.

### Changed
- Retargeted to .NET 5.0 and .NET Standard 2.1
- Split example application out from dithering library.
- Retargeted example application to .NET 5.0 (Windows)
