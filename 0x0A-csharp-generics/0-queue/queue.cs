using System;

/// <summary>
/// The generic Queue class.
/// </summary>
/// <typeparam name="T">The generic type parameter.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Method that returns the Queue's type.
    /// </summary>
    /// <returns>The type of whatever T is.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
