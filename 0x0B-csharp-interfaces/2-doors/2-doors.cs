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
/// A class that inherits from Base and IInteractive,
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary> Sets the value of `name`. </summary>
    public Door(string n = "Door") {
        name = n;
    }

    /// <summary> Prints a sentence. </summary>
    public void Interact() {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
