using System;
using Math;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding an Item. </summary>
    public class Item : BaseClass
    {
        /// <summary> A required string that's the name of an Item. </summary>
        public string name;

        /// <summary> An optional string that's the description of the Item. </summary>
        public string description;

        /// <summary> An optional 2 point float that's the price of the Item. </summary>
        public float price;

        /// <summary> An optional list of strings that's the tags of the Item. </summary>
        public List<string> tags = new List<string>();

        public Item(string n = "Item_Name", string describe, float cost, List<string> info)
        {
            this.name = n;
            if (describe)
                this.description = describe;
            if (cost)
                this.price = Math.Round(cost, 2);
            if (info)
                this.tags = info;
        }
    }
}
