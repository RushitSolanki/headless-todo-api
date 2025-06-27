using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Core.Models;
using TodoApp.Infrastructure;

namespace TodoApp.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly TodoAppDbContext _context;

        public TodosController(TodoAppDbContext context)
        {
            _context = context;
        }

        // GET: api/v1/todos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Todo>>> GetTodos()
        {
            return await _context.Todos.ToListAsync();
        }

        // GET: api/v1/todos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetTodo(Guid id)
        {
            var todo = await _context.Todos.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            return todo;
        }

        // POST: api/v1/todos
        [HttpPost]
        public async Task<ActionResult<Todo>> CreateTodo(CreateTodoRequest request)
        {
            var todo = new Todo
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Description = request.Description,
                Status = TodoStatus.Pending,
                Priority = request.Priority,
                DueDate = request.DueDate,
                UserId = request.UserId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
        }

        // PUT: api/v1/todos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodo(Guid id, UpdateTodoRequest request)
        {
            var todo = await _context.Todos.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            todo.Title = request.Title;
            todo.Description = request.Description;
            todo.Status = request.Status;
            todo.Priority = request.Priority;
            todo.DueDate = request.DueDate;
            todo.UpdatedAt = DateTime.UtcNow;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/v1/todos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(Guid id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoExists(Guid id)
        {
            return _context.Todos.Any(e => e.Id == id);
        }
    }

    public class CreateTodoRequest
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; } = Priority.Medium;
        public DateTime? DueDate { get; set; }
        public Guid UserId { get; set; }
    }

    public class UpdateTodoRequest
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public TodoStatus Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime? DueDate { get; set; }
    }
} 