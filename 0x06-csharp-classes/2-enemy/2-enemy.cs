using System;

namespace Enemies
{
    /// <summary>
    /// An class that defines a zombie.
    /// </summary>
    class Zombie
    {
        /// <summary>
        /// A public field that is an int with no value.
        /// </summary>
        public int health;

        /// <summary>
        /// A public constructor that sets the value of health to 0.
        /// </summary>
        public Zombie() => health = 0;

        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}
