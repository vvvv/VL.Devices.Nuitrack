using System;
using nuitrack;
using VL.Lib.Basics.Imaging;
using System.Reactive;
using System.Reactive.Linq;

namespace VL.Devices.Nuitrack
{
    // Keep all implementing classes internal and just expose them publicly through interface
    public static class FrameExtensions
    {
        public static IObservable<ColorFrameEventArgs> ColorFrameArrived(ColorSensor sensor)
        {
            return Observable.FromEvent<ColorSensor.OnUpdate, ColorFrameEventArgs>(handler =>
            {
                ColorSensor.OnUpdate cfaHandler = (x) =>
                {
                    handler(new ColorFrameEventArgs(x));
                };

                return cfaHandler;
            },
                    cfaHandler => sensor.OnUpdateEvent += cfaHandler,
                    cfaHandler => sensor.OnUpdateEvent -= cfaHandler);
        }
        /*
        public static IImage ToColorImage(this ColorFrame frame) => new ColorImage(frame);

        public static IImage ToConvertedColorImage(this ColorFrame frame, ColorImageFormat colorImageFormat) => new ConvertedColorImage(frame, colorImageFormat);

        public static IImage ToDepthImage(this DepthFrame frame) => new DepthImage(frame);

        public static IImage ToInfraredImage(this InfraredFrame frame) => new InfraredImage(frame);

        public static IImage ToPlayerImage(this BodyIndexFrame frame) => new PlayerImage(frame);

        public static IImage ToDepthColorImage(this DepthFrame frame) => new DepthColorImage(frame);

        public static IImage ToColorDepthImage(this DepthFrame frame, bool isRaw, bool relativeLookup) => new ColorDepthImage(frame, isRaw, relativeLookup);

        public static ImageInfo ToImageInfo(this FrameDescription frameDescription, ColorImageFormat colorImageFormat)
        {
            return new ImageInfo(
                width: frameDescription.Width,
                height: frameDescription.Height,
                format: colorImageFormat.ToPixelFormat(),
                originalFormat: colorImageFormat.ToString());
        }

        public static ImageInfo ToImageInfo(this FrameDescription frameDescription, PixelFormat pixelFormat)
        {
            return new ImageInfo(
                width: frameDescription.Width,
                height: frameDescription.Height,
                format: pixelFormat,
                originalFormat: pixelFormat.ToString());
        }

        public static PixelFormat ToPixelFormat(this ColorImageFormat format)
        {
            switch (format)
            {
                case ColorImageFormat.None:
                    return PixelFormat.Unknown;
                case ColorImageFormat.Rgba:
                    return PixelFormat.R8G8B8A8;
                case ColorImageFormat.Bgra:
                    return PixelFormat.B8G8R8A8;
                case ColorImageFormat.Yuv:
                case ColorImageFormat.Bayer:
                case ColorImageFormat.Yuy2:
                    throw new NotSupportedException(); // TODO: Make me nicer
                default:
                    throw new NotImplementedException();
            }
        }
        */
    }
}
