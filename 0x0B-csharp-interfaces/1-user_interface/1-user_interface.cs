using System;

/// <summary>
/// An abstract class, contains public property name and overrides ToString().
/// </summary>
public abstract class Base
{
    /// <summary> Public property that should be a string. </summary>
    public string name;

    /// <summary> Overrides the ToString() method. </summary>
    /// <returns> A string with the set up: `name` is a `type` </returns>
    public override String ToString() {
        return $"{name} is a {this.GetType()}";
    }
}

/// <summary>
/// An interface called IInteractive.
/// </summary>
interface IInteractive
{
    /// <summary> A method that currently does nothing. </summary>
    void Interact();
}

/// <summary>
/// An interface called IBreakable.
/// </summary>
interface IBreakable
{
    /// <summary> An int property. </summary>
    int durability { get; set; }

    /// <summary> A method that currently does nothing. </summary>
    void Break();
}

/// <summary>
/// An interface called ICollectable.
/// </summary>
interface ICollectable
{
    /// <summary> A boolean property. </summary>
    bool isCollected { get; set; }

    /// <summary> A method that currently does nothing. </summary>
    void Collect();
}

/// <summary>
/// A new empty public class that inherits from Base and all interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary> Determines the durability of an item. </summary>
    public int durability { get; set; }

    /// <summary> Determines if the item can be collected. </summary>
    public bool isCollected { get; set; }

    /// <summary> Currently does nothing. </summary>
    public void Interact() { }

    /// <summary> Currently does nothing. </summary>
    public void Break() { }

    /// <summary> Currently does nothing. </summary>
    public void Collect() { }
}
