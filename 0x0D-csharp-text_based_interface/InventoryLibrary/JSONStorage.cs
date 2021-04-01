using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> A public class that manages all the information obtained. </summary>
    public class JSONStorage
    {
        /// <summary> Dictionary containing all objects. </summary>
        /// <value> Comes from storage stored through JSON. </value>
        public Dictionary<TKey,TValue> objects = new Dictionary<TKey, TValue>();

        /// <summary> Used to get all objects. </summary>
        /// <returns> The entire `objects` dictionary. </returns>
        public Dictionary<TKey,TValue> All()
        {
            return objects;
        }

        /// <summary> Adds a new key-value pair to `objects`. </summary>
        /// <param name="obj"> The new object to save into `objects`. </param>
        public void New(Type obj)
        {
            objects.Add(GetClassName(obj) + "." + obj.id, obj);
        }

        /// <summary> Saves `objects` to the JSON file in Storage after serializing. </summary>
        public void Save()
        {
            string JSONString = JsonSerializer.Serialize(objects);
            string JSONFile = @"../storage/inventory_manager.json";
            using (StreamWriter sw = File.OpenWrite(JSONFile)) {
                sw.WriteLine(JSONString);
            }
        }

        /// <summary> Creates `objects` based off the deserialization of the JSON file. </summary>
        public void Load()
        {
            string JSONFile = @"../storage/inventory_manager.json";
            string JSONString = JSONFile.ReadAllText(JSONFile);
            objects = JsonSerializer.Deserialize<Dictionary<TKey,TValue>>(JSONString);
        }
    }
}
