using System;

/// <summary>
/// A class containing one public static bool method.
/// </summary>
class Obj
{
    /// <summary>
    /// A method that returns true if an object is an instance of another class.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>true or false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return typeof(Array).IsInstanceOfType(obj);
    }
}
