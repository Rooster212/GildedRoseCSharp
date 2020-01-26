namespace GildedRoseConsole
{
    using System;

    public class InvalidInventoryItem : InventoryItem
    {
        public InvalidInventoryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void ProcessInventoryUpdate()
        {
            throw new InvalidOperationException($"Cannot process invaid item {Name}");
        }
    }
}
