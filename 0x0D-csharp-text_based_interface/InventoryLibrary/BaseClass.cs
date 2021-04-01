using System;

namespace InventoryLibrary
{
    /// <summary> The class all other classes will inherit from. </summary>
    public class BaseClass
    {
        /// <summary> A string of the object's id. </summary>
        string id;

        /// <summary> DateTime object. The time an object was created. </summary>
        DateTime date_created;

        /// <summary> DateTime object. The time an object was updated. </summary>
        DateTime date_updated;
    }
}
