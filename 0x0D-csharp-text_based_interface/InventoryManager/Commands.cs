using System;
using System.Linq;
using System.Collections.Generic;
using InventoryLibrary;

/// <summary> This is where each command is handled. </summary>
public class Commands
{
    List<string> classnames = new List<string>() { "Base", "User", "Item", "Inventory" };


    /// <summary> Prints all objects or all objects of a specified ClassName. </summary>
    /// <param name="storage"> The JSONStorage object that contains all information. </param>
    /// <param name="ClassName"> The user input. </param>
    public void All(JSONStorage storage, string ClassName = null)
    {
        int flag = -1;
        List<object> objs = new List<object>();

        if (ClassName == null || classnames.Contains(ClassName, StringComparer.OrdinalIgnoreCase)) {
            foreach(KeyValuePair<string, object> item in storage.objects) {
                string[] key = item.Key.Split(".");
                if (ClassName == null) {
                    objs.Add(item.Value);
                } else if (key[0].Equals(ClassName, StringComparison.OrdinalIgnoreCase)) {
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
        Console.WriteLine(String.Join("\n", objs));
        if (flag >= 0)
            Prompt.ErrorClass(ClassName, flag);
        Console.WriteLine("\r\nThat was everything.");
        //if (ClassName.Count() > 2)
        //    Console.WriteLine("Any argument after the first two was ignored.\r\n");
    }
}
