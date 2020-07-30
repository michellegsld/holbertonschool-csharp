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
        /// A private field that is an int with no value.
        /// </summary>
        private int health;

        /// <summary>
        /// A private field that is a string with a default value.
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// A public constructor that sets the value of health to 0.
        /// </summary>
        public Zombie() => health = 0;

        /// <summary>
        /// A public property with a get and set.
        /// </summary>
        /// <value> What to set name to. </value>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// A public constructor that throws an error if value less than 0.
        /// </summary>
        /// <param name="value">Must be greater than or equal to zero.</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        /// <summary>
        /// A public method that just returns a value.
        /// </summary>
        /// <returns> The value of health of the Zombie object</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Public .toString() override to print Zombie object's attributes to stdout
        /// </summary>
        /// <returns>A string with a format of Zombie Name: _name_ / Total Health: _health_ </returns>
        public override string ToString()
        {
            return "Zombie Name: " + name + " / Total Health: " + health;
        }
    }
}
