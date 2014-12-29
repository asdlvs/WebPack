using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interaction.Web.Models
{
    public class ContactsModel : AngularModel
    {
        public List<Contact> Contacts { get; set; }

        public ContactsModel() : base("contacts")
        {
            this.Contacts = new List<Contact>();
        }

        public class Contact
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }
        }
    }
}