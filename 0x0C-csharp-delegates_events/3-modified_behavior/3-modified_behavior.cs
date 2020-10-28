using System;

/// <summary> An enum to help calculate the value of damage. </summary>
public enum Modifier {
    /// <summary> Changes damage to half. </summary>
    Weak,
    /// <summary> Does not change value of damage. </summary>
    Base,
    /// <summary> Multiplies the damage by `1.5`. </summary>
    Strong
}

/// <summary> A deleate that takes a float amount and kind of modifier for the following method. </summary>
/// <param name="baseValue"> The regular value of the damage. </param>
/// <param name="modifier"> How the damage is to be modified. </param>
/// <returns> The new damage amount. </returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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

    /// <summary> A delegate that takes a float amount for the following 3 methods. </summary>
    /// <param name="amount"> This is either the amount of damage or amount healed. </param>
    public delegate void CalculateHealth(float amount);

    /// <summary> Prints and calculates reguarding how much damage the Player took. </summary>
    /// <param name="damage"> The amoung of damage to take. </param>
    public void TakeDamage(float damage) {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary> Prints and calculates reguarding how much the Player healed. </summary>
    /// <param name="heal"> The amount to heal. </param>
    public void HealDamage(float heal) {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary> Sets the new value of the Player's `hp`. </summary>
    /// <param name="newHp"> The new value to set `hp` to. </param>
    public void ValidateHP(float newHp) {
        if (newHp < 0)
            newHp = 0;
        if (newHp > maxHp)
            newHp = maxHp;
        hp = newHp;
    }

    /// <summary> Follows the CalculateModifier prototype to calculate updated damage. </summary>
    /// <param name="baseValue"> The original damage amount. </param>
    /// <param name="modifier"> To determine how the damage amount is modified. </param>
    /// <returns> The new damage total. </returns>
    public float ApplyModifier(float baseValue, Modifier modifier) {
        if (modifier == Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
}
}
