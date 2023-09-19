using Reporting.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using User.Domain.ModelDtos;

namespace DataAccess.EntityFramework
{
    public class EfUserDal : EfEntityRepository<User.Domain.Models.User, PhoneBookDbContext>, IUserDal
    {
        public List<UserDetailModel> GetUserDetails(Expression<Func<UserDetailModel, bool>> filter = null)
        {
            using (PhoneBookDbContext context = new PhoneBookDbContext())
            {
                var result = from u in context.user
                             join c in context.contact
                             on u.id equals c.user_id                             
                             select new UserDetailModel { company = u.company, contact_id = c.id, email = c.email, id = u.id, details = c.details, location = c.location, name = u.name, phone_number = c.phone_number, surname = u.surname };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
        public List<ReportingDTO> GetReport()
        {
            using (PhoneBookDbContext context = new PhoneBookDbContext())
            {
                var resultUser = (from u in context.user
                                  join c in context.contact
                                  on u.id equals c.user_id
                                  select new UserDetailModel
                                  {
                                      company = u.company,
                                      id = u.id,
                                      location = c.location,
                                      name = u.name,
                                      surname = u.surname
                                  }
                             ).Distinct().GroupBy(x => x.location).Select(x => new { Location = x.Key, Count = x.Count() });

                var resultContact = from r in context.contact
                                    group r by r.location into g
                                    select new
                                    {
                                        Location = g.Key,
                                        Count = g.Count()
                                    };


                var result = from u in resultUser
                             join c in resultContact
                             on u.Location equals c.Location
                             select new ReportingDTO { Location = u.Location, UserCount = u.Count, ContactCount = c.Count };

                return result.ToList();
            }
        }
    }
}
