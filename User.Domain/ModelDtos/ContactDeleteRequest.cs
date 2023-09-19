using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.ModelDtos
{
    public class ContactDeleteRequest
    {
        public int id { get; set; }
        public int user_id { get; set; }
    }
}
