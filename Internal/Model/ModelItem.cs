using BleClient.Internal;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLESDK.Model
{
    /// <summary>
    /// Any entity that needs access to ble characters should be inherited from ModelItem.
    /// The entity can be single service with characters ( see DeviceInformationService.cs)
    /// but this is not a requirement. 
    /// </summary>
    public class ModelItem :
        NotifyPropertyChangedImpl
    {
        public ModelItem()
        {
            BleCharacteristics = new Dictionary<string, BleCharacteristic>();
        }

        public IDictionary<string,BleCharacteristic> BleCharacteristics
        {
            get;
            protected set;
        }

        virtual public async Task ConfigureAsync()
        {
            await new Task(() => 
            {
                throw new Exception("not implemented");
            });
        }

        virtual public async Task<bool> ReadValuesAsync()
        {
            return await new Task<bool>(() => true);
        }

    }
}
