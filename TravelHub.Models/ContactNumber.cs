using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub.Models
{
    public class ContactNumber
    {
        public int ContactNumberId { get; set; }
        public int UserId { get; set; }
        public string Number { get; set; }
        public string Network  { get; set; }
        public string ContactType { get; set; }
        public bool IsActive { get; set; }
    }
}
