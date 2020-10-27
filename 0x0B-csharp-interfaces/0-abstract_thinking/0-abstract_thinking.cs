using System;

/// <summary>
/// An abstract class, contains public property name and overrides ToString().
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public property that should be a string.
    /// </summary>
    public string name;

    /// <summary>
    /// Overrides the ToString() method.
    /// </summary>
    /// <returns> A string with the set up: `name` is a `type` </returns>
    public override String ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
