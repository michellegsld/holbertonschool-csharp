using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding the User. </summary>
    public class User : BaseClass
    {
        /// <summary> A requred string that is the name of a User. </summary>
        public string name;

        public User(string n = "User_Name")
        {
            this.name = n;
        }
    }
}
