using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100), MinLength(5)]
        public string Description { get; set; }

        [Required]
        public DateTime Createdd { get; set; }
        [Required]
        public DateTime Due { get; set; }
        [Required]
        public TodoStatus Status { get; set; }

        public int AuthourId { get; set; }
        public Authour? Authour { get; set; }
    }
}
