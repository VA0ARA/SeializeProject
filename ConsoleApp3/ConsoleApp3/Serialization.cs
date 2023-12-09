using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public  class Serialization<T>

    {
        //serialize list of object to file
        public void SerializeListOfData(List<T> ListOfOBJ, string FilePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(ListOfOBJ, options);
            File.WriteAllText(FilePath, jsonString);
        }
        //deserialize string  to list object
        public List<T> Deserialize(string FilePath)
        {
            List<T> ListOfObject = new List<T>();
            string AllObject = File.ReadAllText(FilePath);
            ListOfObject = JsonConvert.DeserializeObject<List<T>>(AllObject);
            //ListOfObject = System.Text.Json.JsonSerializer.Deserialize<List<T>>(AllObject);
            return ListOfObject;
        }
       







    }
}
