using Newtonsoft.Json;
using SavedTodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Services
{
    public class TextFileService
    {
        private const string DATA_URL = "./Data/Data.txt";

        public List<TodoItem> GetItemsFromFile()
        {
            if (!System.IO.File.Exists(DATA_URL))
            {
                System.IO.File.WriteAllText(DATA_URL, "");
            }

            List<TodoItem> items = new();

            string[] lines = System.IO.File.ReadAllLines(DATA_URL);

            foreach (string line in lines)
            {
                string[] parameters = line.Split(";");
                TodoItem item = new()
                {
                    Id = parameters[0],
                    Name = parameters[1],
                    Description = parameters[2],
                    Completed = bool.Parse(parameters[3])
                };
            }

            return items;
        }

        public void WriteItemsToFile(List<TodoItem> items)
        {
            System.IO.File.WriteAllText(DATA_URL, "");
            foreach (TodoItem item in items)
            {
                System.IO.File.AppendText($"{item.Id};{item.Name};{item.Description};{item.Completed}");
            }
        }
    }
}
