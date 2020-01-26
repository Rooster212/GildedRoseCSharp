namespace GildedRoseConsole
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }

        public InventoryItem(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public static InventoryItem ProcessInventoryUpdate(InventoryItem item)
        {
            return new InventoryItem("", 1, 2);
        }

        public static bool NameIsValid(string name)
        {
            return false;
        }
    }
}
