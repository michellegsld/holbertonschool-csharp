using System;

namespace InventoryLibrary
{
    /// <summary> A public class that sets information regarding the Inventory. </summary>
    public class Inventory : BaseClass
    {
        /// <summary> The id of a User. </summary>
        public string user_id;

        /// <summary> The id of an Item. </summary>
        public string item_id;

        /// <summary> The amount of items in the inventory. </summary>
        public int quantity;

        public Inventory(string u_id = this.User.id, string i_id = this.Item_id.id, int total = 1)
        {
            if (total < 1)
                total = 1;
            this.quantity = total;
        }
    }
}
