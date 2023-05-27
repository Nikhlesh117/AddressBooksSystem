using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine("Enter the new details for the contact:");
                Console.Write("First Name: ");
                contact.FirstName = Console.ReadLine();
                Console.Write("Last Name: ");
                contact.LastName = Console.ReadLine();
                Console.Write("Address: ");
                contact.Address = Console.ReadLine();
                Console.Write("City: ");
                contact.City = Console.ReadLine();
                Console.Write("State: ");
                contact.State = Console.ReadLine();
                Console.Write("Zip: ");
                contact.Zip = Console.ReadLine();
                Console.Write("Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();
                Console.Write("Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DeleteContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void ViewContacts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("Contacts in the address book:\n");
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No contacts found in the address book.");
            }
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public void SortContactsByName()
        {
            contacts.Sort();
            Console.WriteLine("Contacts sorted by name.");
        }

        public void SortContactsByCity()
        {
            contacts.Sort((c1, c2) => string.Compare(c1.City, c2.City, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted by city.");
        }

        public void SortContactsByState()
        {
            contacts.Sort((c1, c2) => string.Compare(c1.State, c2.State, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted by state.");
        }

        public void SortContactsByZip()
        {
            contacts.Sort((c1, c2) => string.Compare(c1.Zip, c2.Zip, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Contacts sorted by ZIP.");
        }

        public void WriteContactsToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Contact contact in contacts)
                {
                    writer.WriteLine(contact.ToString());
                }
            }

            Console.WriteLine("Contacts written to file successfully.");
        }

        public void ReadContactsFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            contacts.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Contact contact = Contact.Parse(line);
                    if (contact != null)
                    {
                        contacts.Add(contact);
                    }
                }
            }

            Console.WriteLine("Contacts read from file successfully.");
        }

        public void ExportContactsToCsv(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contacts);
            }

            Console.WriteLine("Contacts exported to CSV file successfully.");
        }

        public void ImportContactsFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var importedContacts = csv.GetRecords<Contact>().ToList();
                contacts.AddRange(importedContacts);
            }

            Console.WriteLine("Contacts imported from CSV file successfully.");
        }


        private Contact FindContact(string firstName, string lastName)
        {
            return contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
    }

}
