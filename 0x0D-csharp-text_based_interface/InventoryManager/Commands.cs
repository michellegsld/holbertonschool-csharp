using System;
using System.Linq;
using System.Collections.Generic;
using InventoryLibrary;

/// <summary> This is where each command is handled. </summary>
public class Commands
{
    /// <summary> Contains all valid ClassNames </summary>
    List<string> classnames = new List<string>() { "BaseClass", "Item", "User", "Inventory" };

    /// <summary> Displays all class names of objects loaded in JSONStorage. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    public void ClassNames(JSONStorage storage)
    {
        List<string> classes = new List<string>();

        foreach(KeyValuePair<string, object> item in storage.objects) {
            classes.Add(item.Value.GetType().Name);
        }

        HashSet<string> hash = new HashSet<string>(classes);
        string[] found = hash.ToArray();

        Console.WriteLine("\r\nResults:\r\n--------");
        Console.WriteLine(string.Join(",", found));

        if (found.Count() == 0)
            Prompt.ErrorClass(null, 3);
    }

    /// <summary> Prints all objects or all objects of a specified ClassName. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    /// <param name="ClassName"> The user input. </param>
    public void All(JSONStorage storage, string ClassName = null)
    {
        int flag = -1;
        List<object> objs = new List<object>();

        if (ClassName == null || classnames.Contains(ClassName, StringComparer.OrdinalIgnoreCase)) {
            foreach(KeyValuePair<string, object> item in storage.objects) {
                if (ClassName == null) {
                    objs.Add(item.Value);
                } else if (item.Value.GetType().Name.Equals(ClassName, StringComparison.OrdinalIgnoreCase)) {
                    objs.Add(item.Value);
                }
            }
            if (objs.Count() == 0 && ClassName == null) {
                flag = 0;
            } else if (objs.Count() == 0 && ClassName != null) {
                flag = 1;
            }
        } else {
            flag = 2;
        }

        Console.WriteLine("\r\nResults:\r\n--------");
        Console.WriteLine(String.Join("\n", objs.ToString()));

        if (flag >= 0)
            Prompt.ErrorClass(ClassName, flag);

        Console.WriteLine("\r\nThat was everything.");
    }

    /// <summary> Creates a new object to add to storage. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    /// <param name="ClassName"> The type of object to be created. </param>
    public void Create(JSONStorage storage, string ClassName)
    {
        if (classnames.Contains(ClassName, StringComparer.OrdinalIgnoreCase) == false) {
            Prompt.ErrorClass(ClassName, 2);
            return;
        } else if (String.Compare(ClassName, classnames[1], StringComparison.OrdinalIgnoreCase) == 0) {
            Console.WriteLine("\r\nPlease input the name of the Item:");
            string name = Console.ReadLine();

            if (name == "") {
                Console.WriteLine("\r\nThe Item name is required and cannot be left blank.");
                Console.WriteLine("\r\n...Cancelling creation of Item.\r\nCreation was cancelled.");
                return;
            }

            Console.WriteLine("Please input a description:");
            string describe = Console.ReadLine();
            if (describe == "")
                Console.WriteLine("\r\nThe Item description is optional and will be left blank.\r\n");

            Console.WriteLine("Please input the price:");
            string price = Console.ReadLine();
            if (price == "")
                Console.WriteLine("\r\nThe Item price is optional and will be left as 0.00\r\n");

            Console.WriteLine("Please input any tags in one line and separated by spaces:");
            string tags = Console.ReadLine();
            if (tags == "")
                Console.WriteLine("\r\nThe Item tags are optional and will be left blank.\r\n");

            Console.WriteLine("\r\n...CREATING ITEM...");

            if (price == "")
                price = "0.00";

            Item obj = new Item(name, describe, float.Parse(price), tags.Split().ToList());

            storage.New(obj);
            storage.Save();

            Console.WriteLine("...SAVING ITEM...");
            Console.WriteLine("Item successfully created!");
        } else if (String.Compare(ClassName, classnames[2], StringComparison.OrdinalIgnoreCase) == 0) {
            // ask for name, and other info
            Console.WriteLine("This would make a User.");
        } else if (String.Compare(ClassName, classnames[3], StringComparison.OrdinalIgnoreCase) == 0) {
            // ask for name, and other info
            Console.WriteLine("This would make an inventory");
        }
    }

    /// <summary> Shows information about a given object from storage. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    public void Show(JSONStorage storage)
    {

    }

    /// <summary> Updates a given object from storage. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    public void Update(JSONStorage storage)
    {

    }

    /// <summary> Deletes a given object from storage. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    public void Delete(JSONStorage storage)
    {

    }

    /// <summary> Closes the Console Application. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    public void Exit(JSONStorage storage)
    {
        storage.Save();
        Console.WriteLine("\r\n...SAVING...");
        Console.WriteLine("Goodbye!");
        System.Environment.Exit(0);
    }
}
