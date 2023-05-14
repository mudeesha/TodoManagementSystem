using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        //Get todos
        public List<Todo> AllTodos(int authourId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books fro school",
                Description = "Get vegitables for the week",
                Createdd = DateTime.Now,
                Due = DateTime.Now,
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get foods",
                Description = "Get foods for home",
                Createdd = DateTime.Now,
                Due = DateTime.Now,
                Status = TodoStatus.Compleated
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plant",
                Description = "Water all the plant quickely",
                Createdd = DateTime.Now,
                Due = DateTime.Now,
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo3);

            return todos;
        }

        public Todo GetTodo(int authourId, int id)
        {
            throw new NotImplementedException();
        }
    }
}
