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
            switch (name)
            {
                case "Aged Brie":
                    return new AgedBrieInventoryItem(name, inputSellIn, inputQuality);
                case "Backstage passes": 
                    return new BackstagePassInventoryItem(name, inputSellIn, inputQuality);
                case "Sulfuras": 
                    return new SulfurasInventoryItem(name, inputSellIn, inputQuality);
                case "Normal Item": 
                    return new NormalInventoryItem(name, inputSellIn, inputQuality);
                case "Conjured": 
                    return new ConjuredInventoryItem(name, inputSellIn, inputQuality);
                default: 
                    return new InvalidInventoryItem(name, inputSellIn, inputQuality);
            };
        }

        public abstract void ProcessInventoryUpdate();
    }
}
