using SavedTodoList.Models;
using System.Collections.Generic;

namespace SavedTodoList.Services
{
    public interface IFileService
    {
        List<TodoItem> GetItemsFromFile();
        void WriteItemsToFile(List<TodoItem> items);
    }
}