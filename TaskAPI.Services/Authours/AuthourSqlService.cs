using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Db;
using TasakAPI.DataAccess;

namespace TaskAPI.Services.Authours
{
    public class AuthourSqlService : IAuthourRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Authour> GetAllAuthours()
        {
            return _context.Authours.ToList();  
        }

        public Authour GetAuthour(int id)
        {
            return _context.Authours.Find(id);
        }
    }
}
