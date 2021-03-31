using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding an item. </summary>
    public class Item : BaseClass
    {
        /// <summary> The name of an item. </summary>
        /// <value> A string. Required. </value>
        public string name { get; set; }

        /// <summary> A description of the item. </summary>
        /// <value> A string. Optional. </value>
        public string description { get; set; }

        /// <summary> The price of the item. </summary>
        /// <value> A float limited to 2 decimal points. Optional. </value>
        public float price { get; set; }

        /// <summary> The tags of the item. </summary>
        /// <value> A list of strings. Optional. </value>
        public List<string> tags { get; set; }
    }
}
