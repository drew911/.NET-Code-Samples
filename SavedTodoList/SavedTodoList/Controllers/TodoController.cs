using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SavedTodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult TodoList()
        {
            string itemsText = System.IO.File.ReadAllText("./Data/Data.json");
            List<TodoItem> items = JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);

            return View(items);
        }

        public IActionResult CreateTodo()
        {
            return View();
        }

        public IActionResult ToggleTodo(string id, bool value)
        {
            string itemsText = System.IO.File.ReadAllText("./Data/Data.json");
            List<TodoItem> items = JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);

            TodoItem selectedItem = items.FirstOrDefault(i => i.Id == id);
            selectedItem.Completed = !selectedItem.Completed;

            itemsText = JsonConvert.SerializeObject(items);
            System.IO.File.WriteAllText("./Data/Data.json", itemsText);

            return Ok();
        }

        public IActionResult SubmitTodo(TodoItem todoItem)
        {
            if (!System.IO.File.Exists("./Data/Data.json"))
            {
                System.IO.File.WriteAllText("./Data/Data.json", "[]");
            }

            string itemsText = System.IO.File.ReadAllText("./Data/Data.json");
            List<TodoItem> items = JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);

            if (items == null)
            {
                items = new();
            }

            items.Add(todoItem);

            itemsText = JsonConvert.SerializeObject(items);
            System.IO.File.WriteAllText("./Data/Data.json", itemsText);

            return RedirectToAction("TodoList");
        }

    }
}
