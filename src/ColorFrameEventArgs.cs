using nuitrack;
using System;

namespace VL.Devices.Nuitrack
{
    public class ColorFrameEventArgs : EventArgs
    {
        public readonly ColorFrame ColorFrame;
        
        public ColorFrameEventArgs(ColorFrame colorFrame)
        {
            ColorFrame = colorFrame;
        }
    }
}
