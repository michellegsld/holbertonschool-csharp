using System;
using System.Collections.Generic;

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

        /// <summary>
        /// A public constructor that throws an error if value < 0.
        /// </summary>
        /// <param name="value">Must be greater than or equal to 0.</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}
