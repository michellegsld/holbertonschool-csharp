using System;

namespace InventoryLibrary
{
    /// <summary> The class all other classes will inherit from. </summary>
    public class BaseClass
    {
        /// <summary> The id of an object. </summary>
        /// <value> A string. </value>
        public string id { get; set; }

        /// <summary> The time an object was created. </summary>
        /// <value> A DateTime. </value>
        public DateTime date_created { get; set; }

        /// <summary> The time an object was updated. </summary>
        /// <value> A DateTime. </value>
        public DateTime date_updated { get; set; }
    }
}
