using System;
using Newtonsoft.Json;
namespace Util
{
    public static class Serialize
    {
        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="obj">Object.</param>
        public static string SerializeObject(object obj)
        {
            string serializeString = string.Empty;
            serializeString = JsonConvert.SerializeObject(obj);
            return serializeString;
        }

        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="str">String.</param>
        /// <param name="type">Type.</param>
        public static object DeserializeObject(string str, Type type)
        {
            object deserializeObject = null;
            deserializeObject = JsonConvert.DeserializeObject(str, type);
            return deserializeObject;
        }
    }
}
