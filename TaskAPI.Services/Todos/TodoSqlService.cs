using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Db;
using TasakAPI.DataAccess;

namespace TaskAPI.Services.Todos
{
    public class TodoSqlService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();

        public List<Todo> AllTodos(int authourId)
        {
            return _context.Todos.Where(t => t.AuthourId == authourId).ToList();
        }

        public Todo GetTodo(int authourId, int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id && t.AuthourId == authourId);
        }
    }
}
