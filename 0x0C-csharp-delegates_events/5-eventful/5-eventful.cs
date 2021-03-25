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

/// <summary> A delegate that takes a float amount for calculating new health. </summary>
/// <param name="amount"> This is either the amount of damage or amount healed. </param>
public delegate void CalculateHealth(float amount);

/// <summary> A public class mainly for the current HP of a Player. </summary>
public class CurrentHPArgs : EventArgs {
    /// <summary> In order to be visible but not editable. </summary>
    public readonly float currentHp;

    /// <summary> Constructor for the CurrentHPArgs class to update HP. </summary>
    /// <param name="newHp"> The Player's new `Hp` value. </param>
    public CurrentHPArgs(float newHp) {
        this.currentHp = newHp;
    }
}

/// <summary>
/// A public class with the properties `name`, `maxHp`, `hp` and a constructor.
/// </summary>
public class Player {
    private string name;
    private float maxHp;
    private float hp;
    /// <summary> Will be for printing information on current HP status. </summary>
    public EventHandler<CurrentHPArgs> HPCheck;
    private string status;

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
        this.status = $"<name> is ready to go!";
        this.HPCheck = this.CheckStatus;
    }

    /// <summary> Prints information on current status of HP of a Player.</summary>
    public void PrintHealth() {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary> Follows `CalculateHealth`, prints and calculates reguarding how much damage the Player took. </summary>
    /// <param name="damage"> The amoung of damage to take. </param>
    public void TakeDamage(float damage) {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    /// <summary> Follows `CalculateHealth`, prints and calculates reguarding how much the Player healed. </summary>
    /// <param name="heal"> The amount to heal. </param>
    public void HealDamage(float heal) {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    /// <summary> Follows `CalculateHealth`, sets the new value of the Player's `hp`. </summary>
    /// <param name="newHp"> The new value to set `hp` to. </param>
    public void ValidateHP(float newHp) {
        if (newHp < 0)
            newHp = 0;
        if (newHp > maxHp)
            newHp = maxHp;
        hp = newHp;
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    /// <summary> Follows the `CalculateModifier` prototype to calculate updated damage. </summary>
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

    /// <summary> Prints a statement reguarding the current status of the Player. </summary>
    /// <param name="sender"> </param>
    /// <param name="e"> </param>
    private void CheckStatus(object sender, CurrentHPArgs e) {
        if (e.currentHp == this.maxHp)
            Console.WriteLine($"{name} is in perfect health!");
        else if (e.currentHp >= this.maxHp / 2 && e.currentHp < maxHp)
            Console.WriteLine($"{name} is doing well!");
        else if (e.currentHp >= this.maxHp / 4 && e.currentHp < maxHp / 2)
            Console.WriteLine($"{name} isn't doing too great...");
        else if (e.currentHp > 0 && e.currentHp < maxHp / 2)
            Console.WriteLine($"{name} needs help!");
        else
            Console.WriteLine($"{name} is knocked out!");
    }

    /// <summary> Prints output depending upon `e`'s `currentHp`. </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HPValueWarning(object sender, CurrentHPArgs e) {
        if (e.currentHp == 0) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        } else {
            Console.WriteLine("Health is low!");
        }
    }

    /// <summary> Adds the value warning to the `HPCheck` </summary>
    /// <param name="e"> </param>
    private void OnCheckStatus(CurrentHPArgs e) {
        if (e.currentHp < this.maxHp / 4)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}
