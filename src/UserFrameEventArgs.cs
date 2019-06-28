using nuitrack;
using System;

namespace VL.Devices.Nuitrack
{
    public class UserFrameEventArgs : EventArgs
    {
        public readonly UserFrame UserFrame;
        
        public UserFrameEventArgs(UserFrame userFrame)
        {
            UserFrame = userFrame;
        }
    }
}
