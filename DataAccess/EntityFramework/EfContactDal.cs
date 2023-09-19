using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Models;

namespace DataAccess.EntityFramework
{
    public class EfContactDal:EfEntityRepository<Contact, PhoneBookDbContext>, IContactDal
    {

    }
}
