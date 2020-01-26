namespace GildedRoseConsole
{
    using System;

    public abstract class InventoryItem : IInventoryItem
    {
        public string Name { get; protected set; }
        public int SellIn { get; protected set; }
        public int Quality { get; protected set; }

        protected InventoryItem(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public static IInventoryItem CreateInventoryItem(string name, int inputSellIn, int inputQuality)
        {
            return name switch
            {
                "Backstage passes" => new BackstagePassInventoryItem(name, inputSellIn, inputQuality),
                _ => new InvalidInventoryItem(name, inputSellIn, inputQuality)
            };
        }

        public abstract void ProcessInventoryUpdate();
    }
}
