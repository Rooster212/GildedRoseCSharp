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
            Assert.DoesNotThrow(() => InventoryItem.CreateInventoryItem(name, sellIn, quality));
        }

        [Test]
        [TestCase("Aged Brie", 1, 1, 0, 2)]
        [TestCase("Backstage passes", -1, 2, -2, 0)]
        [TestCase("Backstage passes", 9, 2, 8, 4)]
        [TestCase("Sulfuras", 2, 2, 2, 2)]
        [TestCase("Normal Item", -1, 55, -2, 50)]
        [TestCase("Normal Item", 2, 2, 1, 1)]
        [TestCase("Conjured", 2, 2, 1, 0)]
        [TestCase("Conjured", -1, 5, -2, 1)]
        public void TestItemInventoryUpdate(string name, int inputSellIn, int inputQuality, int outputSellIn, int outputQuality)
        {
            var item = InventoryItem.CreateInventoryItem(name, inputSellIn, inputQuality);
            item.ProcessInventoryUpdate();

            if (item is InvalidInventoryItem)
            {
                Assert.Fail("Item is invalid");
            }

            Assert.AreEqual(name, item.Name);
            Assert.AreEqual(outputSellIn, item.SellIn);
            Assert.AreEqual(outputQuality, item.Quality);
        }

        [Test]
        [TestCase("Aged Brie", true)]
        [TestCase("Aged brie​", false)]
        [TestCase("Backstage passes", true)]
        [TestCase("Backstage​ ​Passes", false)]
        [TestCase("Sulfuras", true)]
        [TestCase("SULFURAS", false)]
        [TestCase("Normal Item", true)]
        [TestCase("Normal​ ​item", false)]
        [TestCase("Conjured", true)]
        [TestCase("conjured", false)]
        public void TestItemValidName(string name, bool valid)
        {
            var newItem = InventoryItem.CreateInventoryItem(name, 1, 2);

            if (valid)
            {
                Assert.IsFalse(newItem is InvalidInventoryItem);
            }
            else
            {
                Assert.IsTrue(newItem is InvalidInventoryItem);
            }
        }
    }
}
