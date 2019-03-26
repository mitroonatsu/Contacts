﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi.Models;

namespace Webapi.Repositories
{
    public interface IContactRepository
    {
        Contact Create(Contact contact);
        List<Contact> Read();
        Contact Read(int id);
        Contact Update(Contact contact);
        void Delete(int id);
    }
}
