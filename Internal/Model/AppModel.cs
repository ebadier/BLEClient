using BleClient.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLESDK.Model
{
    /// <summary>
    /// Each application should implement own Appmodel. It is a container for Model items
    /// </summary>
    /// 
    public class AppModel :
        NotifyPropertyChangedImpl
    {
        public IList<ModelItem> Items
        {
            get;
            private set;
        }

        public AppModel()
        {
            Items = new List<ModelItem>();
        }

        public async Task EnableAllNotificationsAsync(bool enable)
        {
            foreach (var item in Items)
            {
                foreach (var character in item.BleCharacteristics)
                {
                    await character.Value.EnableNotificationsAsync(enable);
                }
             }
        }

        protected void RegisterItem(ModelItem item)
        {
            Items.Add(item);
        }
    }
}

