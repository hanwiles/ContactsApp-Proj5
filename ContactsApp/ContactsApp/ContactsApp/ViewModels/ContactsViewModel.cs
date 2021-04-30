using System;
using System.Collections.Generic;
using System.Text;
using MyClock.ViewModels;
using System.Windows.Input;
using ContactsApp.Model;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class ContactsViewModel: ViewModelBase
    {
        private Contact contact = new Contact();
        private static Contact selectedContact = null;
        private static Contact saveContact = new Contact();

        public ContactsViewModel()
        {
            AddNewContact = new Command(() =>
            {
                Contacts.Add(contact);
                Contact = new Contact();
            });

            CancelCommand = new Command(() =>
            {
                SelectedContact.FirstName = saveContact.FirstName;
                SelectedContact.LastName = saveContact.LastName;
                SelectedContact.ContactType = saveContact.ContactType;
            });

            DeleteCommand = new Command(() =>
            {
                Contacts.Remove(SelectedContact);
            });
        }

        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                OnPropertyChanged();
            }
        }

        public Contact SelectedContact
        {
            get => selectedContact;
            set
            {
                if (value != null)
                {
                    saveContact.FirstName = value.FirstName;
                    saveContact.LastName = value.LastName;
                    saveContact.ContactType = value.ContactType;
                    selectedContact = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand AddNewContact { protected set; get;  }
        public ICommand CancelCommand { protected set; get; }

        public ICommand DeleteCommand { protected set; get; }

        public static List<Contact> Contacts
        {
            get 
            { 
                return ContactData.Contacts; 
            }

            set { }
        }
    }
}
