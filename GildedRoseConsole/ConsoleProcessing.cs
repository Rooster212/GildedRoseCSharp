namespace GildedRoseConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ConsoleProcessing
    {
        public static Tuple<string, int, int> GetInputVariablesFromUserInput(string userInputLine)
        {
            var splitVariables = userInputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var splitLength = splitVariables.Length;
            // 3 is our minimum input length
            if (splitLength < 3)
            {
                throw new InvalidOperationException();
            }

            var itemNameWords = new List<string>();
            int sellInValue = 0;
            int qualityValue = 0;

            for (var reverseIterator = 1; reverseIterator <= splitVariables.Length; reverseIterator++)
            {
                var currentIterationValue = splitVariables[splitLength - reverseIterator];
                switch (reverseIterator)
                {
                    case 1: // The last element in the array
                    case 2: // The second to last element in the array
                        int valueParsed;
                        var valid = int.TryParse(currentIterationValue, out valueParsed);
                        if (!valid)
                        {
                            throw new InvalidOperationException();
                        }
                        
                        if (reverseIterator == 1) 
                        {
                            qualityValue = valueParsed;
                        } 
                        else
                        {
                            sellInValue = valueParsed;
                        }

                        break;
                    default:
                        itemNameWords.Add(currentIterationValue);
                        break;
                }
            }

            // Reverse the item words as we added them to the list backwards
            itemNameWords.Reverse();

            return new Tuple<string, int, int>(string.Join(" ", itemNameWords.ToArray()), sellInValue, qualityValue);
        }
    }
}
