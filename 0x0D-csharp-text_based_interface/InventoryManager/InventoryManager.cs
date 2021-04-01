using System;
using System.Linq;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main()
        {
            JSONStorage storage = new JSONStorage();
            Commands command = new Commands();
            string input;
            string[] inputSplit;
            List<string> commands = new List<string>() { "ClassNames", "All", "Create", "Show", "Update", "Delete", "Exit" };

            storage.Load();
            Prompt.Print();
            for (;;)
            {
                input = "";
                input = Console.ReadLine();
                inputSplit = input.Split();

                if (commands.Contains(inputSplit[0], StringComparer.OrdinalIgnoreCase) == false) {
                    Console.WriteLine("Please input a valid command.");
                    continue;
                } else if (inputSplit[0].Equals("All", StringComparison.OrdinalIgnoreCase)) {
                    if (inputSplit.Count() > 1) {
                        command.All(storage, inputSplit[1]);
                    } else {
                        command.All(storage);
                    }
                } else if (inputSplit[0].Equals("Exit", StringComparison.OrdinalIgnoreCase)) {
                    storage.Save();
                    System.Environment.Exit(0);
                }

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("_________________________");

                Prompt.Print();
            }
        }
    }
}
