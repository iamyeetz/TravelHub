using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub.Models
{
    public class UserCredentials
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer  { get; set; }
        public bool IsLocked { get; set; }
    }
}
