namespace GildedRoseConsole
{
    using System;

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
