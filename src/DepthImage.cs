using nuitrack;
using VL.Lib.Basics.Imaging;

namespace VL.Devices.Nuitrack
{
    // Exposes the kinect frame buffer directly
    public class DepthImage : IImage
    {
        public readonly DepthFrame frame;
        private readonly ArrayImage<byte> image;

        public DepthImage(DepthFrame frame)
        {
            this.frame = frame;
            Info = new ImageInfo(frame.Cols, frame.Rows, PixelFormat.R16);
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
