using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavedTodoList.Models
{
    public class TodoItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Completed { get; set; } = false;
    }
}
