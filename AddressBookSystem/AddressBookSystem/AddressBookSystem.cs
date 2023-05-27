using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void CreateAddressBook(string addressBookName)
        {
            if (!addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = new AddressBook();
                addressBooks.Add(addressBookName, addressBook);
                Console.WriteLine("Address book created successfully.");
            }
            else
            {
                Console.WriteLine("Address book already exists with the same name.");
            }
        }

        public void AddContactToAddressBook(string addressBookName, Contact contact)
        {
            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.AddContact(contact);
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public List<Contact> SearchContactsByCity(string city)
        {
            List<Contact> result = new List<Contact>();

            foreach (var addressBook in addressBooks.Values)
            {
                List<Contact> contacts = addressBook.GetContacts();
                foreach (Contact contact in contacts)
                {
                    if (contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(contact);
                    }
                }
            }

            return result;
        }

        public List<Contact> SearchContactsByState(string state)
        {
            List<Contact> result = new List<Contact>();

            foreach (var addressBook in addressBooks.Values)
            {
                List<Contact> contacts = addressBook.GetContacts();
                foreach (Contact contact in contacts)
                {
                    if (contact.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(contact);
                    }
                }
            }

            return result;
        }

        public AddressBook GetAddressBook(string addressBookName)
        {
            if (addressBooks.ContainsKey(addressBookName))
            {
                return addressBooks[addressBookName];
            }

            return null;
        }
    }

}
