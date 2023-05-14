using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Authours
{
    public interface IAuthourRepository
    {
        public List<Authour> GetAllAuthours();

        public Authour GetAuthour(int id);
    }
}
