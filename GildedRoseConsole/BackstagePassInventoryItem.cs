using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseConsole
{
    public class BackstagePassInventoryItem : InventoryItem
    {
        public BackstagePassInventoryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            
        }

        public override void ProcessInventoryUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
