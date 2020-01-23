namespace GildedRoseConsole.Tests
{
    using System;
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
    }
}
