using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListService.Models;

namespace TodoListService.Stores
{
    public class TodoItemStore : List<TodoItem>
    {
        public new void Add(TodoItem todoItem)
        {
            int newId =this.OrderByDescending(t => t.Id).Select(t => t.Id).FirstOrDefault() + 1;

            todoItem.Id = newId;

            base.Add(todoItem);
        }
    }
}
