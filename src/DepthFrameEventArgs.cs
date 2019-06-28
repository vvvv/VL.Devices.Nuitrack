using nuitrack;
using System;

namespace VL.Devices.Nuitrack
{
    public class DepthFrameEventArgs : EventArgs
    {
        public readonly DepthFrame DepthFrame;
        
        public DepthFrameEventArgs(DepthFrame depthFrame)
        {
            DepthFrame = depthFrame;
        }
    }
}
