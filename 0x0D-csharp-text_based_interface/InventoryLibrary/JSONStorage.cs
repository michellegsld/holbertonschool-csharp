using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    /// <summary> A public class that manages all the information obtained. </summary>
    public class JSONStorage
    {
        /// <summary> Dictionary containing all objects. </summary>
        /// <value> Comes from storage stored through JSON. </value>
        public Dictionary<String,Type> objects { get; set; }

        /// <summary> Used to get all objects. </summary>
        /// <returns> The entire `objects` dictionary. </returns>
        public Dictionary<String,Type> All()
        {
            return objects;
        }

        /// <summary> Adds a new key-value pair to `objects`. </summary>
        public void New(Type obj)
        {
            objects.Add(GetClassName(obj) + "." + obj.id, obj);
        }

        /// <summary> Saves `objects` to a JSON file after serializing. </summary>
        public void Save()
        {
            
        }

        /// <summary> Creates `objects` based off JSON file deserialization. </summary>
        public void Load()
        {
            
        }
    }
}
