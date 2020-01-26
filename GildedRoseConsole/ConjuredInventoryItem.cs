namespace GildedRoseConsole
{
    using System;

    public class ConjuredInventoryItem : InventoryItem
    {
        public ConjuredInventoryItem(string name, int sellIn, int quality) : base (name, sellIn, quality)
        {

        }

        public override void ProcessInventoryUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
