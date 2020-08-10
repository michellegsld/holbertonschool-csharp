using System;
using System.Reflection;

/// <summary>
/// A class containing one public static void method.
/// </summary>
class Obj
{
    /// <summary>
    /// A method that prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to print info from.</param>
    public static void Print(object myObj)
    {
        // NOTE: var is not specific! This is what var is replacing in these cases:
        // PropertyInfo
        // MethodInfo
        // So instead of var, you can place these to be more specific

        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach(var item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach(var item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
