using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding the User. </summary>
    public class User : BaseClass
    {
        /// <summary> A required string that is the name of a User. </summary>
        public string name;

        /// <summary> This is to initialize the User object </summary>
        /// <param name="n"> The name of the User </param>
        public User(string n)
        {
            this.name = n;
        }
    }
}
