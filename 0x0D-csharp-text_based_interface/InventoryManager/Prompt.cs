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
        Console.WriteLine();
    }

    /// <summary> To be called upon if there are no objects of that Class. </summary>
    /// <param name="ClassName"> The ClassName given by the user. </param>
    /// <param name="Flag"> Specifies the reason why there are no objects. </param>
    public static void ErrorClass(string ClassName, int Flag)
    {
        if (Flag != 2)
            Console.WriteLine($"No Results.");
        if (Flag == 1) {
            Console.WriteLine($"There are currently no objects of type {ClassName}");
        } else if (Flag == 2) {
            Console.WriteLine($"{ClassName} is not a valid object type");
        } else if (Flag == 3) {
            Console.WriteLine("There are currently no objects of any ClassNames loaded in JSONStorage.");
            Console.WriteLine("\r\nUse Create to make an object with a valid ClassName type:");
            Console.WriteLine("- Item\r\n- User\r\n- Inventory");
        }
    }

    /// <summary> To be called upon if the given id is invalid. </summary>
    /// <param name="id"> The invalid id given by the user. </param>
    public static void ErrorId(string id)
    {
        Console.WriteLine($"Object {id} could not be found");
    }
}
