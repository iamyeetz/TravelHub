using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address  { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePicturePath { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public List<ContactNumber> ContactNumbers { get; set; }


    }
}
