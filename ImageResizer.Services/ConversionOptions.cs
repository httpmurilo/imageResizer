using ImageMagick;

namespace ImageResizer.Services 
{
    public class ConversionOptions 
    {
        public const int MaxSize = 1000;

        public string Name { get; set; }

        public MagickFormat TargetFormat { get; set; }

        public int Width { get; set; } = MaxSize;

        public int Height { get; set; }

        public int Quality { get; set; }

        public string TargetMineType => GetTargetMineType ();
        private string GetTargetMineType ()
         {
            switch (TargetFormat) {
                case MagickFormat.Png24:
                    return "image/png";

                default:
                    return "image/jpeg";
            }
        }
    }
}