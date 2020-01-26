namespace GildedRoseConsole
{
    using System;
    public class InvalidInventoryItem : InventoryItem
    {
        public InvalidInventoryItem(string name)
        {
            this.Name = name;
        }

        public override void ProcessInventoryUpdate()
        {
            throw new InvalidOperationException($"Cannot process invaid item {Name}");
        }
    }
}
