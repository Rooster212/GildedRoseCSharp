namespace GildedRoseConsole
{
    using System;

    public abstract class InventoryItem : IInventoryItem
    {
        public string Name { get; protected set; }
        public int SellIn { get; protected set; }
        public int Quality { get; protected set; }
        public bool Exists { get; protected set; }

        public static IInventoryItem CreateInventoryItem(string name, int inputSellIn, int inputQuality)
        {
            return name switch
            {
                _ => new InvalidInventoryItem(name)
            };
        }

        public abstract void ProcessInventoryUpdate();
    }
}
