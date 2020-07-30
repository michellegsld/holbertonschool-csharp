﻿using System;
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
        /// A public constructor that sets the value of health to 0.
        /// </summary>
        public Zombie() => health = 0;

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
    }
}
