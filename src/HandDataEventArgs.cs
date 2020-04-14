using nuitrack;
using System;

namespace VL.Devices.Nuitrack
{
    public class HandTrackerDataEventArgs : EventArgs
    {
        public readonly HandTrackerData HandTrackerData;
        
        public HandTrackerDataEventArgs(HandTrackerData handTrackerData)
        {
            HandTrackerData = handTrackerData;
        }
    }
}
