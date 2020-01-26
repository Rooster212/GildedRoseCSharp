namespace GildedRoseTests.Unit
{
    using GildedRoseConsole;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class ConsoleProcessingTests
    {
        [TestCase("hello world 1 1", "hello world", 1, 1)]
        [TestCase("Aged Brie 1 1", "Aged Brie", 1, 1)]
        [TestCase("Backstage passes -1 2", "Backstage passes", -1, 2)]
        [TestCase("Backstage passes 9 2", "Backstage passes", 9, 2)]
        [TestCase("Sulfuras 2 2", "Sulfuras", 2, 2)]
        [TestCase("Normal Item -1 55", "Normal Item", -1, 55)]
        [TestCase("Normal Item 2 2", "Normal Item", 2, 2)]
        [TestCase("INVALID ITEM 2 2", "INVALID ITEM", 2, 2)]
        [TestCase("Conjured -1 5", "Conjured", -1, 5)]
        public void TestValidUserInputCanBeSplitCorrectly(string inputString, string outputName, int outputSellIn, int outputQuality)
        {
            var inputVariables = ConsoleProcessing.GetInputVariablesFromUserInput(inputString);

            Assert.AreEqual(outputName, inputVariables.Item1);
            Assert.AreEqual(outputSellIn, inputVariables.Item2);
            Assert.AreEqual(outputQuality, inputVariables.Item3);
        }

        [TestCase("hello world")]
        [TestCase("")]
        [TestCase("foo bar bar bar")]
        [TestCase("foobar")]
        [TestCase("foobar 5")]
        public void TestInvalidUserInputThrowsException(string input)
        {
            Assert.Throws<InvalidOperationException>(() => ConsoleProcessing.GetInputVariablesFromUserInput(input));
        }
    }
}
