using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.ModelDtos;
using User.Domain.Models;
using User.Domain.Services;

namespace User.Infastructure.Services
{
    public class ContactService : IContactService
    {
        IContactDal _contactDal;
        public ContactService(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public int Add(Contact contact)
        {
            _contactDal.Add(contact);
            return contact.id;
        }
        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public bool Delete(ContactDeleteRequest request)
        {
            _contactDal.Delete(c => c.id == request.id && c.user_id == request.user_id);
            return true;
        }

        public int Update(Contact contact)
        {
            _contactDal.Update(contact);
            return contact.id;
        }

        public Contact GetContactById(int id)
        {
            return _contactDal.Get(c => c.id == id);
        }

        public List<Contact> GetContactByUserId(int userId)
        {
            return _contactDal.GetAll(c => c.user_id == userId);
        }
    }
}
