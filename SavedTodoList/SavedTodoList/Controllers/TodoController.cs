using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SavedTodoList.Models;
using SavedTodoList.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Controllers
{
    public class TodoController : Controller
    {
        private TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult TodoList()
        {
            //string itemsText = System.IO.File.ReadAllText("./Data/Data.json");
            //List<TodoItem> items = JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);
            
            List<TodoItem> items = _todoService.GetAllTodos();

            return View(items);
        }

        public IActionResult CreateTodo()
        {
            return View();
        }

        public IActionResult ToggleTodo(string id)
        {
            //string itemsText = System.IO.File.ReadAllText("./Data/Data.json");
            //List<TodoItem> items = JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);

            //List<TodoItem> items = _jsonFileService.GetItemsFromFile();

            //TodoItem selectedItem = items.FirstOrDefault(i => i.Id == id);
            //selectedItem.Completed = !selectedItem.Completed;

            //itemsText = JsonConvert.SerializeObject(items);
            //System.IO.File.WriteAllText("./Data/Data.json", itemsText);

            //_jsonFileService.WriteItemsToFile(items);
            try
            {
                _todoService.ToggleTodo(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(502, ex.InnerException);
            }
            

           
        }

        public IActionResult SubmitTodo(TodoItem todoItem)
        {
            //if (!System.IO.File.Exists("./Data/Data.json"))
            //{
            //    System.IO.File.WriteAllText("./Data/Data.json", "[]");
            //}

            //string itemsText = System.IO.File.ReadAllText("./Data/Data.json");
            //List<TodoItem> items = JsonConvert.DeserializeObject<List<TodoItem>>(itemsText);
            //List<TodoItem> items = _jsonFileService.GetItemsFromFile();

            //if (items == null)
            //{
            //    items = new();
            //}

            //items.Add(todoItem);

            //itemsText = JsonConvert.SerializeObject(items);
            //System.IO.File.WriteAllText("./Data/Data.json", itemsText);

            //_jsonFileService.WriteItemsToFile(items);

            _todoService.CreateTodo(todoItem);

            return RedirectToAction("TodoList");
        }

    }
}
