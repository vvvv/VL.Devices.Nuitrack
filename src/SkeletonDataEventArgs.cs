using nuitrack;
using System;

namespace VL.Devices.Nuitrack
{
    public class SkeletonDataEventArgs : EventArgs
    {
        public readonly SkeletonData SkeletonData;
        
        public SkeletonDataEventArgs(SkeletonData skeletonData)
        {
            SkeletonData = skeletonData;
        }
    }
}
