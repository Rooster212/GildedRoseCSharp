namespace GildedRoseConsole
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                Welcome to the Gilded Rose Inventory System!                ");
            Console.WriteLine("                --------------------------------------------                ");
            Console.ResetColor();

            Console.Write(Environment.NewLine);
            Console.WriteLine("Please enter an inventory item to update in the format:");
            Console.Write(Environment.NewLine);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    <item> <sellInDays> <quality>");
            Console.Write(Environment.NewLine);
            Console.ResetColor();

            Console.WriteLine("For example, an Aged Brie with a sell by date of 3 days time and a quality of 2:");
            Console.Write(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    Aged Brie 3 2");
            Console.Write(Environment.NewLine);
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(To quit, press the Enter key with no input, or enter 'exit'.)");
            Console.ResetColor();
            Console.Write(Environment.NewLine);

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var userInput = Console.ReadLine();
                Console.ResetColor();

                if (string.Equals(userInput, "") || string.Equals(userInput, "exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                else
                {
                    Tuple<string, int, int> inputVariables;
                    try
                    {
                        inputVariables = ConsoleProcessing.GetInputVariablesFromUserInput(userInput);
                    }
                    catch (InvalidOperationException)
                    {
                        WriteErrorToConsole("Invalid input detected. Please try again.");
                        continue;
                    }

                    var inventoryItem = InventoryItem.CreateInventoryItem(inputVariables.Item1, inputVariables.Item2, inputVariables.Item3);

                    if (inventoryItem is InvalidInventoryItem)
                    {
                        WriteErrorToConsole($"NO SUCH ITEM");
                        continue;
                    }

                    inventoryItem.ProcessInventoryUpdate();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(inventoryItem.ToString());
                    Console.ResetColor();
                }
            } while (true);
        }

        static void WriteErrorToConsole(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
            Console.Write(Environment.NewLine);
        }
    }
}
