using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.Extensions.Options;

namespace TasakAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Authour> Authours { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=MytodoDb; user=root; charset=utf8mb4;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version()));
        }
        //model ekak trigger wenakota me method eka wada karanawa
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authour>().HasData(new Authour[]
            {
                new Authour {Id = 1, FullName = "Mudeesha Tharindu", AddressNo="827/1", Street="Street 1", City="colombo"},
                new Authour {Id = 2, FullName = "John Cena", AddressNo="750", Street="Street 2", City="Galle"},
                new Authour {Id = 3, FullName = "Breat Lee", AddressNo="103", Street="Street 3", City="Matara"},
                new Authour {Id = 4, FullName = "Sharuk Khan", AddressNo="85", Street="Street 4", City="kandy"},
            });
            
            modelBuilder.Entity<Todo>().HasData(new Todo[] {
                
                new Todo{
                    Id = 1,
                    Title = "Get books fro school from db",
                    Description = "Get vegitables for the week",
                    Createdd = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthourId= 1,
                },

                new Todo{
                    Id = 2,
                    Title = "Need some grocceries",
                    Description = "Get some text book for school",
                    Createdd = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthourId= 1,
                },

                new Todo{
                    Id = 3,
                    Title = "Get books fro school from db",
                    Description = "Get vegitables for the week",
                    Createdd = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthourId= 2,
                },

            });
        }
    }
}
