using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ContactsApp.Model
{
    public static class ContactData
    {
        public static List<Contact> contacts = new List<Contact>();

        public static List<Contact> Contacts
        {
            get
            {
                contacts = new List<Contact>(contacts.OrderBy(contact => contact.LastName));
                return contacts;
            }
        }

        static ContactData()
        {
            Contacts.Add(new Contact
            {
                FirstName = "Hannah",
                LastName = "Wiles",
                ContactType = "Me"
            });

            Contacts.Add(new Contact
            {
                FirstName = "Nico",
                LastName = "Sandoval",
                ContactType = "Number One"
            });

            Contacts.Add(new Contact
            {
                FirstName = "Michele",
                LastName = "Wiles",
                ContactType = "Mother"
            });

            Contacts.Add(new Contact
            {
                FirstName = "Courtney",
                LastName = "Wiles",
                ContactType = "Sister"
            });

            Contacts.Add(new Contact
            {
                FirstName = "Selia",
                LastName = "Araiza",
                ContactType = "Friend"
            });
        }
    }
}
