﻿namespace GildedRoseConsole
{
    using System;

    public class AgedBrieInventoryItem : InventoryItem
    {
        public AgedBrieInventoryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {

        }

        public override void ProcessInventoryUpdate()
        {
            this.SellIn--;
            this.Quality++;

            if (this.Quality < 0) {
                this.Quality = 0;
            }
        }
    }
}
