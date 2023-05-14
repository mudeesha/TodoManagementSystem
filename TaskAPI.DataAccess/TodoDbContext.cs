using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        //connect db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "Server=localhost; Database=MyTodoDb";
            var connectionString = "server=localhost; user=root; database=MyTodoDb100; Trusted_Connection=True; Encrypt=False; ";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
