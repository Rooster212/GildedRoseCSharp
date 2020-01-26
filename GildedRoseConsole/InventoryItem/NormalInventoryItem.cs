namespace GildedRoseConsole
{
    using System;

    public class NormalInventoryItem : InventoryItem
    {
        public NormalInventoryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void ProcessInventoryUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
