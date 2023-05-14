using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TaskAPI.Models;
using TaskAPI.Services.Models;
using TaskAPI.Services.Todos;

namespace WebApplication3.Controllers
{
    [Route("api/authours/{authourId}/todos")] 
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodoController(ITodoRepository repository, IMapper mapper) {
            
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authourId) {

            var myTodos = _todoService.AllTodos(authourId);

            var mappedTodos = _mapper.Map<ICollection<Todo>>(myTodos);
            return Ok(mappedTodos); 
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int authourId, int id)
        { 
            var todo = _todoService.GetTodo(authourId, id);

            if (todo is null)
            {
                return NotFound();
            }

            var mappedTodo = _mapper.Map<TodoDto>(todo);

            return Ok(mappedTodo);
        }

        
    }
}
