using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseConsole
{
    public interface IInventoryItem
    {
        public string Name { get; }
        public int SellIn { get; }
        public int Quality { get; }
        public bool Exists { get; }

        public void ProcessInventoryUpdate();
    }
}
