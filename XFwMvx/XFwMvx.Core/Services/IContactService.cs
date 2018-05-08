using System.Collections.Generic;
using XFwMvx.Core.Models;

namespace XFwMvx.Core.Services
{
    public interface IContactService
    {
        IEnumerable<Contact> FetchContacts();
    }
}
