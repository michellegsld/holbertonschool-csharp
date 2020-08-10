using System;

/// <summary>
/// A class containing one public static bool method.
/// </summary>
class Obj
{
    /// <summary>
    /// A method that returns true if the object is a subclass of a class, but false if is an instance.
    /// </summary>
    /// <param name="derivedType">The subclass/child.</param>
    /// <param name="baseType">The class/parent.</param>
    /// <returns>true or false.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
