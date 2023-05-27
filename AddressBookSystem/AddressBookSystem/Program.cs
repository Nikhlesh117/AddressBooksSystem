using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {         
        public static void Main(string[] args)
        {
            AddressBookMain addressBookMain = new AddressBookMain();

            while (true)
            {
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Sort Contacts by Name");
                Console.WriteLine("6. Sort Contacts by City");
                Console.WriteLine("7. Sort Contacts by State");
                Console.WriteLine("8. Sort Contacts by ZIP");
                Console.WriteLine("9. Write Contacts to File");
                Console.WriteLine("10. Read Contacts from File");
                Console.WriteLine("11. View Contacts");
                Console.WriteLine("12. Export Contacts as CSV");
                Console.WriteLine("13. Import Contacts from CSV");
                Console.WriteLine("14. Exit");
                Console.WriteLine("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addressBookMain.CreateAddressBook();
                        break;
                    case "2":
                        addressBookMain.AddContact();
                        break;
                    case "3":
                        addressBookMain.EditContact();
                        break;
                    case "4":
                        addressBookMain.DeleteContact();
                        break;
                    case "5":
                        addressBookMain.SortContactsByName();
                        break;
                    case "6":
                        addressBookMain.SortContactsByCity();
                        break;
                    case "7":
                        addressBookMain.SortContactsByState();
                        break;
                    case "8":
                        addressBookMain.SortContactsByZip();
                        break;
                    case "9":
                        addressBookMain.WriteContactsToFile();
                        break;
                    case "10":
                        addressBookMain.ReadContactsFromFile();
                        break;
                    case "11":
                        addressBookMain.ViewContacts();
                        break;
                    case "12":
                        addressBookMain.ExportContacts();
                        break;
                    case "13":
                        addressBookMain.ImportContacts();
                        break;
                    case "14":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }




        }
    }
}
