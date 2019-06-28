using nuitrack;
using System;
using System.Reactive.Linq;
using VL.Lib.Basics.Imaging;

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

        public static IObservable<DepthFrameEventArgs> DepthFrameArrived(DepthSensor sensor)
        {
            return Observable.FromEvent<DepthSensor.OnUpdate, DepthFrameEventArgs>(handler =>
            {
                DepthSensor.OnUpdate cfaHandler = (x) =>
                {
                    handler(new DepthFrameEventArgs(x));
                };

                return cfaHandler;
            },
                    cfaHandler => sensor.OnUpdateEvent += cfaHandler,
                    cfaHandler => sensor.OnUpdateEvent -= cfaHandler);
        }

        public static IObservable<UserFrameEventArgs> UserFrameArrived(UserTracker userTracker)
        {
            return Observable.FromEvent<UserTracker.OnUpdate, UserFrameEventArgs>(handler =>
            {
                UserTracker.OnUpdate cfaHandler = (x) =>
                {
                    handler(new UserFrameEventArgs(x));
                };

                return cfaHandler;
            },
                    cfaHandler => userTracker.OnUpdateEvent += cfaHandler,
                    cfaHandler => userTracker.OnUpdateEvent -= cfaHandler);
        }

        public static IImage ToColorImage(ColorFrame frame)
        {

            ImageInfo info = new ImageInfo(frame.Cols, frame.Rows, PixelFormat.R8G8B8);
            ArrayImage<byte> image = new ArrayImage<byte>(frame.Data, info, true);
            return image;
        }

        public static IImage ToDepthImage(DepthFrame frame)
        {

            ImageInfo info = new ImageInfo(frame.Cols, frame.Rows, PixelFormat.R16);
            ArrayImage<byte> image = new ArrayImage<byte>(frame.Data, info, true);
            return image;
        }

        public static IImage ToUserImage(UserFrame frame)
        {

            ImageInfo info = new ImageInfo(frame.Cols, frame.Rows, PixelFormat.R8);
            ArrayImage<byte> image = new ArrayImage<byte>(frame.Data, info, true);
            return image;
        }
    }
}
