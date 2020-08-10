using System;
using System.Collections.Generic;

/// <summary>
/// A class with one public method.
/// </summary>
class Shape
{
    /// <summary>
    /// Throws an exception error with a message.
    /// </summary>
    /// <returns>An exception.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
