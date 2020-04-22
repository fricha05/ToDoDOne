using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Persistence
{
    public static class JsonPersistence
    {
        public static void Write<T>(T obj, string file)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(file, json);
        }
 
        public static T ReadAll<T>(string file)
        {
            string json = File.ReadAllText(file);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}