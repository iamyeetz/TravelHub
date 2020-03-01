using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelHub.Models;
using TravelHub.Repository.Interface;

namespace TravelHub.Repository.ImplementingClass
{
    public class UserRepository :BaseRepository<Users>, IUserRepository
    {

        public UserRepository(DbContext context) : base(context)
        {

        }

    }
}
