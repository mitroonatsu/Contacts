using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Models;

namespace Webapi.Services
{
    public interface IContactService
    {
        //CRUD
        Contact Create(Contact contact);
        List<Contact> Read();
        Contact Read(int id);
        Contact Update(int id, Contact contact);
        void Delete(int id);
    }
}
