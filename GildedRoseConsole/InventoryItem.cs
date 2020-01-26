using System;
using System.Collections.Generic;

namespace GildedRoseConsole
{
    public class InventoryItem
    {
        private const string NO_SUCH_ITEM_NAME = "NO SUCH ITEM";

        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }

        public bool HasValidName { get => Name != NO_SUCH_ITEM_NAME; }

        public InventoryItem(string name, int sellIn, int quality)
        {
            if (!NameIsValid(name))
            {
                this.Name = NO_SUCH_ITEM_NAME;
                return;
            }

            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public static InventoryItem ProcessInventoryUpdate(InventoryItem item)
        {
            return new InventoryItem("", 1, 2);
        }

        private bool NameIsValid(string name)
        {
            return false;
        }
    }
}
