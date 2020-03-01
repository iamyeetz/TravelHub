using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelHub.Repository.Interface;

namespace TravelHub.Repository.ImplementingClass
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TravelHubContext _context;
        public UnitOfWork(TravelHubContext context)
        {
            _context = context;
        }

        public IUserRepository UsersRepository { get; private set; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
