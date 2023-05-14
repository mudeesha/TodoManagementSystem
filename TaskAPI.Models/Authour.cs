using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public class Authour
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string AddressNo { get; set; }
        [Required]
        [MaxLength(100)]
        public string? FullName { get; set; }
        [MaxLength(100)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();



    }
}
