using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.ModelDtos;
using User.Domain.Models;

namespace User.Domain.Services
{
    public interface IContactService
    {
        List<Contact> GetAll();
        int Add(Contact contact);
        int Update(Contact contact);
        bool Delete(ContactDeleteRequest request);
        Contact GetContactById(int id);
        List<Contact> GetContactByUserId(int userId);
    }
}
