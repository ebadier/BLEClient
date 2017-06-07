using System.Collections.Generic;

using Windows.Devices.Enumeration;

namespace BLESDK.Internal
{
    class BleDeviceInformationComparer : IEqualityComparer<DeviceInformation>
    {
        public bool Equals(DeviceInformation x, DeviceInformation y)
        {
            return true;
            //int guidStart = x.Id.LastIndexOf("{");
            //int lenght = x.Id.LastIndexOf("}") - guidStart;
            //return x.Id.Substring(guidStart, lenght) == y.Id.Substring(guidStart, lenght);
        }

        public int GetHashCode(DeviceInformation obj)
        {
            return 0; // obj.Id.GetHashCode();
        }
    }
}
