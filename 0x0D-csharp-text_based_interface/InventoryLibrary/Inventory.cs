using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding the Inventory. </summary>
    public class Inventory : BaseClass
    {
        /// <summary> The id of a User. </summary>
        /// <value> Comes from User `id`. Required. </value>
        public id user_id { get; set => this.User.id; }

        /// <summary> The id of an Item. </summary>
        /// <value> Comes from Item `id`. Required. </value>
        public id item_id { get; set => this.Item.id; }

        /// <summary> The amount of items in the inventory. </summary>
        /// <value> An int defaulted to 1 and can't be less than 0. Required. </value>
        public int quantity { get; set; }
    }
}
