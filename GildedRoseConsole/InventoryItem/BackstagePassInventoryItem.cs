namespace GildedRoseConsole
{
    using System;

    public class BackstagePassInventoryItem : InventoryItem
    {
        public BackstagePassInventoryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            
        }

        public override void ProcessInventoryUpdate()
        {
            this.SellIn -= 1;
            
            if (this.SellIn <= 10 && this.SellIn > 5)
            {
                this.Quality += 2;
            } 
            else if (this.SellIn <= 5 && this.SellIn >= 0)
            {
                this.Quality += 3;
            } 
            else if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
