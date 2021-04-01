using System;
using InventoryLibrary;

/// <summary> Main purpose is to print the prompt in the Console </summary>
public static class Prompt
{
    /// <summary> To be called upon Console start and valid command completion. </summary>
    public static void Print()
    {
        Console.WriteLine(@"Inventory Manager
-------------------------
<ClassNames> show all ClassNames of objects
<All> show all objects
<All [ClassName]> show all objects of a ClassName
<Create [ClassName]> a new object
<Show [ClassName object_id]> an object
<Update [ClassName object_id]> an object
<Delete [ClassName object_id]> an object
<Exit>");
    }

    /// <summary> To be called upon if the given ClassName is invalid. </summary>
    /// <param name="ClassName"> The invalid ClassName given by the user. </param>
    public static void ErrorClass(string ClassName)
    {
        Console.WriteLine($"{ClassName} is not a valid object type");
    }

    /// <summary> To be called upon if the given id is invalid. </summary>
    /// <param name="id"> The invalid id given by the user. </param>
    public static void ErrorId(string id)
    {
        Console.WriteLine($"Object {id} could not be found");
    }
}
