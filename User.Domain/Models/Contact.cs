using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Models
{
    public class Contact
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        public string details { get; set; }
    }
}
