using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelHub.Models;

namespace TravelHub.Repository
{
    public class TravelHubContext : DbContext
    {

        public TravelHubContext() : base("TravelHub")
        {
                
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<ContactNumber> ContactNumber { get; set; }
        public DbSet<UserCredentials> UserCredential { get; set; }
    }
}
