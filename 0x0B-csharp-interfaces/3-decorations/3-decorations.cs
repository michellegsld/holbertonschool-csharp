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
/// A class that inherits from Base and IInteractive.
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

/// <summary>
/// A class that inherits from Base, IInteractive, and IBreakable.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> An int that sets the durability. </summary>
    public int durability { get; set; }

    /// <summary> Either true or false. </summary>
    public bool isQuestItem;

    /// <summary> Adds information about an item. </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> Prints information depending on attributes of an item. </summary>
    public void Interact() {
        if (durability < 1) {
            Console.WriteLine($"The {name} has been broken.");
        } else if (isQuestItem == true) {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        } else if (isQuestItem == false) {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary> Decrements durability and prints information. </summary>
    public void Break() {
        durability -= 1;

        if (durability > 0) {
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability < 0) {
            Console.WriteLine($"The {name} is already broken.");
        } else {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
    }
}
