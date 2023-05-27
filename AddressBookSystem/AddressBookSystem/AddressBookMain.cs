using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        private Dictionary<string, AddressBook> addressBooks;
        

        public AddressBookMain()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void CreateAddressBook()
        {
            Console.WriteLine("Enter the name of the address book:");
            string addressBookName = Console.ReadLine();
            addressBooks[addressBookName] = new AddressBook();
            Console.WriteLine("Address book created successfully.");
        }

        public void AddContact()
        {
            Console.WriteLine("Enter the name of the address book to add the contact:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                Console.WriteLine("Enter the contact details:");
                Console.WriteLine("First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Address:");
                string address = Console.ReadLine();

                Console.WriteLine("City:");
                string city = Console.ReadLine();

                Console.WriteLine("State:");
                string state = Console.ReadLine();

                Console.WriteLine("ZIP:");
                string zip = Console.ReadLine();

                Console.WriteLine("Phone Number:");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Email:");
                string email = Console.ReadLine();

                Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);


                addressBook.AddContact(contact);
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void EditContact()
        {
            Console.WriteLine("Enter the name of the address book to edit the contact:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                Console.WriteLine("Enter the first name of the contact to edit:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter the last name of the contact to edit:");
                string lastName = Console.ReadLine();

                addressBook.EditContact(firstName, lastName);
                Console.WriteLine("Contact edited successfully.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the name of the address book to delete the contact:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                Console.WriteLine("Enter the first name of the contact to delete:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter the last name of the contact to delete:");
                string lastName = Console.ReadLine();

                addressBook.DeleteContact(firstName, lastName);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }
        public void ViewContacts()
        {
            Console.WriteLine("Enter the name of the address book to view contacts:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                addressBooks[addressBookName].ViewContacts();
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void SortContactsByName()
        {
            Console.WriteLine("Enter the name of the address book to sort contacts by name:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.SortContactsByName();
                Console.WriteLine("Contacts sorted by name.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void SortContactsByCity()
        {
            Console.WriteLine("Enter the name of the address book to sort contacts by city:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.SortContactsByCity();
                Console.WriteLine("Contacts sorted by city.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void SortContactsByState()
        {
            Console.WriteLine("Enter the name of the address book to sort contacts by state:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.SortContactsByState();
                Console.WriteLine("Contacts sorted by state.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void SortContactsByZip()
        {
            Console.WriteLine("Enter the name of the address book to sort contacts by ZIP:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.SortContactsByZip();
                Console.WriteLine("Contacts sorted by ZIP.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void WriteContactsToFile()
        {
            Console.WriteLine("Enter the name of the address book to write contacts to a file:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                Console.WriteLine("Enter the file path to write contacts to:");
                string filePath = Console.ReadLine();

                addressBook.WriteContactsToFile(filePath);
                Console.WriteLine("Contacts written to file successfully.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void ReadContactsFromFile()
        {
            Console.WriteLine("Enter the name of the address book to read contacts from a file:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = addressBooks[addressBookName];
                Console.WriteLine("Enter the file path to read contacts from:");
                string filePath = Console.ReadLine();

                addressBook.ReadContactsFromFile(filePath);
                Console.WriteLine("Contacts read from file successfully.");
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }
        public void ExportContacts()
        {
            Console.WriteLine("Enter the name of the address book to export contacts:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Enter the file path to export contacts as CSV:");
                string filePath = Console.ReadLine();

                addressBooks[addressBookName].ExportContactsToCsv(filePath);
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void ImportContacts()
        {
            Console.WriteLine("Enter the name of the address book to import contacts:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Enter the file path to import contacts from CSV:");
                string filePath = Console.ReadLine();

                addressBooks[addressBookName].ImportContactsFromCsv(filePath);
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }
        public void ExportContactsJson()
        {
            Console.WriteLine("Enter the name of the address book to export contacts:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Enter the file path to export contacts as JSON:");
                string filePath = Console.ReadLine();

                addressBooks[addressBookName].ExportContactsToJson(filePath);
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }

        public void ImportContactsjson()
        {
            Console.WriteLine("Enter the name of the address book to import contacts:");
            string addressBookName = Console.ReadLine();

            if (addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Enter the file path to import contacts from JSON:");
                string filePath = Console.ReadLine();

                addressBooks[addressBookName].ImportContactsFromJson(filePath);
            }
            else
            {
                Console.WriteLine("Address book not found.");
            }
        }
    }

}
