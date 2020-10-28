using System;

/// <summary>
/// A public class with the properties `name`, `maxHp`, `hp` and a constructor.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary> Creates the Player and sets the properties. </summary>
    /// <param name="name"> The name of the Player, default is set to `Player`. </param>
    /// <param name="maxHp"> The max HP of the Player, default is set to `100f`. </param>
    public Player(string name = "Player", float maxHp = 100f) {
        this.name = name;
        if (maxHp < 1) {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary> Prints information on current status of HP of a Player.</summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
