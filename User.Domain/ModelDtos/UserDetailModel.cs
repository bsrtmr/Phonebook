using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.ModelDtos
{
    public class UserDetailModel
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? company { get; set; }
        public int contact_id { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        public string details { get; set; }
    }
}
