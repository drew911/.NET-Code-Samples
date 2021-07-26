using SavedTodoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Services
{
    public class MemoryFileService : IFileService
    {
        private List<TodoItem> _items = new List<TodoItem>();

        public MemoryFileService()
        {

        }

        public List<TodoItem> GetItemsFromFile()
        {
            return _items;
        }

        public void WriteItemsToFile(List<TodoItem> items)
        {
            _items = items;
        }
    }
}
