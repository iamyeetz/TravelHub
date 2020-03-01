using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelHub.Repository.Interface;

namespace TravelHub.Repository.ImplementingClass
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
