using System;
using nuitrack;
using VL.Lib.Collections;

namespace VL.Devices.Nuitrack
{
    public static class PointCloud
    {
        public static unsafe Spread<Xenko.Core.Mathematics.Vector3> GetPoints(DepthImage image, int minZ, int maxZ, int decimation)
        {
            DepthFrame frame = image.frame;
            var step = Math.Max(1, decimation + 1);
            var width = frame.Cols / step;
            var height = frame.Rows / step;
            var count = width * height;
            SpreadBuilder<Xenko.Core.Mathematics.Vector3> sb = new SpreadBuilder<Xenko.Core.Mathematics.Vector3>(count);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    ushort z = frame[ row * step, col * step];
                    if (z > minZ && z < maxZ)
                        sb.Add(new Xenko.Core.Mathematics.Vector3(col * step, row * step, z));
                }
            }
            return sb.ToSpread();
        }
    }
}
