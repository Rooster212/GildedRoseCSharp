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
            this.SellIn--;
            this.Quality -= 2;

            // If the sell by has passed, we apply the quality reduction twice
            if (this.SellIn < 0)
            {
                this.Quality -= 2;
            }

            if (this.Quality < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
