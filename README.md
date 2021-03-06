# Input / Output Helpers Library for .NET

ADN.IO is a cross-platform open-source library which provides input/output helpers to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.IO.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.IO)
[![NuGet](https://img.shields.io/nuget/v/ADN.IO.svg)](https://www.nuget.org/packages/ADN.IO/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.IO?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.IO&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.IO)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.IO&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.IO)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Copy directory example:

```csharp
var source = "sourceDir";
var destination = "destDir";
var overwrite = true;
DirectoryHelper.CopyDirectory(source, destination, overwrite);
```

## Installation

ADN.IO runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.IO NuGet package from the NuGet package manager:

```
Install-Package ADN.IO
```

Or alternatively you can add the ADN.IO package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.IO/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.IO is licensed under the [MIT license](LICENSE).
