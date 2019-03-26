using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Models;
using Webapi.Repositories;

namespace Webapi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository personRepository)
        {
            _contactRepository = personRepository;
        }

        public Contact Create(Contact contact)
        {
            return _contactRepository.Create(contact);
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        public List<Contact> Read()
        {
            return _contactRepository.Read();
        }

        public Contact Read(int id)
        {
            return _contactRepository.Read(id);
        }

        public Contact Update(int id, Contact contact)
        {
            var savedContact = _contactRepository.Read(id);
            if (savedContact == null)
                throw new Exception("Contact not found");
            return _contactRepository.Update(contact);
        }
    }
}

