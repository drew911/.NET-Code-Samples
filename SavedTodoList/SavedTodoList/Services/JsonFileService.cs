using Newtonsoft.Json;
using SavedTodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Services
{
    public class JsonFileService
    {
        private const string DATA_URL = "./Data/Data.json";

        public List<TodoItem> GetItemsFromFile()
        {
            if (!System.IO.File.Exists(DATA_URL))
            {
                System.IO.File.WriteAllText(DATA_URL, "[]");
            }

            string itemsText = System.IO.File.ReadAllText(DATA_URL);
            return JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);
        }

        public void WriteItemsToFile(List<TodoItem> items)
        {
            string itemsText = JsonConvert.SerializeObject(items);
            System.IO.File.WriteAllText(DATA_URL, itemsText);
        }
    }
}
