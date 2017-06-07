using System;

namespace BLESDK.Model
{
    public class CharacteristicChangeArgs : EventArgs
    {
        public byte[] Data
        {
            get;
            set;
        }

    }
}
