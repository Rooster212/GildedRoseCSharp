namespace GildedRoseConsole
{
    using System;

    public class SulfurasInventoryItem : InventoryItem
    {
        public SulfurasInventoryItem(string name, int sellIn, int quality) : base (name, sellIn, quality)
        {

        }

        public override void ProcessInventoryUpdate()
        {
            // Never has to be sold and never decreases in quality so no further implementation required.
        }
    }
}
