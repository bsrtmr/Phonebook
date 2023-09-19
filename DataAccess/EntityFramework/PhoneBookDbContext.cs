using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Models;

namespace DataAccess.EntityFramework
{
    public class PhoneBookDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost; Database=PhoneBook; Username=postgres; Password=1234");
        }

        public DbSet<User.Domain.Models.User> user { get; set; }
        public DbSet<Contact> contact { get; set; }

    }
}
