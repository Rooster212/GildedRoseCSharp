namespace GildedRoseConsole.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class InventoryItemTests
    {
        [Test]
        [TestCase("Cheddar", 2, 3)]
        [TestCase("1239", -1, 14)]
        [TestCase("Nintendo Switch", -1, 14)]
        public void TestInventoryItemCanBeConstructed(string name, int sellIn, int quality)
        {
            Assert.DoesNotThrow(() => new InventoryItem(name, sellIn, quality));
        }

        [Test]
        [TestCase("Aged​ ​Brie​", 1, 1, 0, 2)]
        [TestCase("Backstage​ ​passes​", -1, 2, -2, 0)]
        [TestCase("Backstage​ ​passes​", 9, 2, 8, 4)]
        [TestCase("Sulfuras​",2, 2, 2, 2)]
        [TestCase("Aged​ ​Brie​", 1, 1, 0, 2)]
        [TestCase("Normal​ ​Item​", -1, 55, -2, 50)]
        [TestCase("Normal​ ​Item​​", 2, 2, 1, 1)]
        [TestCase("Conjured", 2, 2, 1, 0)]
        [TestCase("Conjured", -1, 5, -2, 1)]
        public void TestItemInventoryUpdate(string name, int inputSellIn, int inputQuality, int outputSellIn, int outputQuality)
        {
            var item = new InventoryItem(name, inputSellIn, inputQuality);
            var itemProcessed = InventoryItem.ProcessInventoryUpdate(item);

            Assert.AreEqual(name, itemProcessed.Name);
            Assert.AreEqual(outputSellIn, itemProcessed.SellIn);
            Assert.AreEqual(outputQuality, itemProcessed.Quality);
        }
    }
}
