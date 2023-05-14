using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Models
{
    public class TodoDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    
        public DateTime Createdd { get; set; }

        public DateTime Due { get; set; }

        public String Status { get; set; }

        public int AuthourId { get; set; }
        public Authour? Authour { get; set; }
    }
}
