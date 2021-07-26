using SavedTodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Services
{
    public class TodoService
    {

        private TextFileService _jsonFileService;

        public TodoService()
        {
            _jsonFileService = new TextFileService();
        }

        public void ToggleTodo(string id)
        {
            List<TodoItem> items = _jsonFileService.GetItemsFromFile();

            TodoItem selectedItem = items.FirstOrDefault(i => i.Id == id);
            selectedItem.Completed = !selectedItem.Completed;

            _jsonFileService.WriteItemsToFile(items);
        }

        public void CreateTodo(TodoItem todoItem)
        {
            List<TodoItem> items = _jsonFileService.GetItemsFromFile();

            if (items == null)
            {
                items = new();
            }

            items.Add(todoItem);

            _jsonFileService.WriteItemsToFile(items);
        }

        public List<TodoItem> GetAllTodos()
        {
            return _jsonFileService.GetItemsFromFile();
        }
    }
}
