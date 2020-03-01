using nuitrack;
using VL.Lib.Basics.Imaging;

namespace VL.Devices.Nuitrack
{
    // Exposes the kinect frame buffer directly
    public class ColorImage : IImage
    {
        public readonly ColorFrame Frame;
        private readonly ArrayImage<byte> image;

        public ColorImage(ColorFrame frame)
        {
            Frame = frame;
            Info = new ImageInfo(frame.Cols, frame.Rows, PixelFormat.B8G8R8);
            image = new ArrayImage<byte>(frame.Data, Info, true);
        }

        public ImageInfo Info { get; }

        public bool IsVolatile => true;

        public IImageData GetData()
        {
            return image.GetData();
        }
    }
}
