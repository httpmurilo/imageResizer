using System;
using ImageMagick;
using ImageResizer.Domain.Model;

namespace ImageResizer.Services {
    public static class ConversionFactory 
    {
        public static ConversionOptions FromResizeRequest (Properties request) 
        {
            var options = new ConversionOptions 
            {
                Name = request.Name
            };

            if (request.Width.HasValue && request.Width > 0) 
            {
                options.Width = Math.Min (request.Width.Value, ConversionOptions.MaxSize);
            }

            if (request.Height.HasValue && request.Height > 0) 
            {
                options.Height = Math.Min (request.Height.Value, ConversionOptions.MaxSize);
            }
            options.TargetFormat = GetMagickFormat (request.Format);
            if (request.Quality.HasValue && request.Quality.Value >= 1 && request.Quality.Value <= 100) 
            {
                options.Quality = request.Quality.Value;
            } else 
            {
                options.Quality = options.TargetFormat == MagickFormat.Png24 ? 100 : 82;
            }
            return options;
        }

        private static MagickFormat GetMagickFormat (string format) 
        {
            if (string.IsNullOrWhiteSpace (format) == false) 
            {
                switch (format.ToLower ())
                 {
                    case "png":
                        return MagickFormat.Png24;
                    case "jpeg":
                    case "jpg":
                        return MagickFormat.Jpeg;
                }
            }
            return MagickFormat.Jpeg;
        }
    }
}