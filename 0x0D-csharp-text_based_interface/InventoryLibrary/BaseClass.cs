using System;

namespace InventoryLibrary
{
    /// <summary> The class all other classes will inherit from. </summary>
    public class BaseClass
    {
        /// <summary> A string of the object's id. </summary>
        public string id;

        /// <summary> DateTime object. The time an object was created. </summary>
        public DateTime date_created;

        /// <summary> DateTime object. The time an object was updated. </summary>
        public DateTime date_updated;
    }
}
