using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub.Repository.Interface
{
    interface IUnitOfWork : IDisposable
    {
        IUserRepository UsersRepository { get; }
        void Complete();
    }
}
