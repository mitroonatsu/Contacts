using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Models;

namespace Webapi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactsdbContext _context;

        public ContactRepository(ContactsdbContext context)
        {
            _context = context;
        }

        public Contact Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public void Delete(int id)
        {
            var deletedContact = Read(id);
            _context.Remove(deletedContact);
            _context.SaveChanges();
            return;
        }

        public List<Contact> Read()
        {
            // SELECT * FROM CONTACT;
            return _context.Contact
                .AsNoTracking()
                .ToList();
        }

        public Contact Read(int id)
        {
            //SELECT * FROM CONTACT WHERE ID={id};
            return _context.Contact
                .FirstOrDefault(c => c.Id == id);
        }

        public Contact Update(Contact contact)
        {
            _context.Update(contact);
            _context.SaveChanges();
            return contact;
        }
    }
}
