using System.Collections.Generic;
using XFwMvx.Core.Models;

namespace XFwMvx.Core.Services
{
    public class ContactService : IContactService
    {
        public IEnumerable<Contact> FetchContacts()
        {
            var contacts = new List<Contact>();
            for (int i = 0; i < 1000; i++)
            {
                contacts.Add(new Contact { Id = i, Name = $"Contact {i}" });
            }
            return contacts;
        }
    }
}
