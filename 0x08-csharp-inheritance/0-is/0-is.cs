using System;

/// <summary>
/// A class containing one public static bool method.
/// </summary>
class Obj
{
    /// <summary>
    /// A method that returns true if an object is an int, else false.
    /// </summary>
    /// <param name="obj">The object to check if is an int.</param>
    /// <returns>true or false.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj.GetType() == typeof(int));
    }
}
