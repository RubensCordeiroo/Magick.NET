﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using ImageMagick.Formats;
using Xunit;

namespace Magick.NET.Tests;

public partial class PngWriteDefinesTests
{
    public class ThreCompressionStrategy
    {
        [Fact]
        public void ShouldSetTheDefine()
        {
            using var image = new MagickImage();
            image.Settings.SetDefines(new PngWriteDefines
            {
                CompressionStrategy = PngCompressionStrategy.HuffmanOnly,
            });

            Assert.Equal("huffmanonly", image.Settings.GetDefine(MagickFormat.Png, "compression-strategy"));
        }

        [Fact]
        public void ShouldSetTheDefineNull()
        {
            using var image = new MagickImage();
            image.Settings.SetDefines(new PngWriteDefines
            {
                CompressionStrategy = null,
            });

            Assert.Null(image.Settings.GetDefine(MagickFormat.Png, "compression-strategy"));
        }
    }
}
