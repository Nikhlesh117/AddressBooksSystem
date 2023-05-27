using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact : IComparable<Contact>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{Address},{City},{State},{Zip},{PhoneNumber},{Email}";
        }

        public int CompareTo(Contact other)
        {
            return string.Compare(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
        }

        public static Contact Parse(string contactString)
        {
            string[] contactData = contactString.Split(',');

            if (contactData.Length == 8)
            {
                string firstName = contactData[0].Trim();
                string lastName = contactData[1].Trim();
                string address = contactData[2].Trim();
                string city = contactData[3].Trim();
                string state = contactData[4].Trim();
                string zip = contactData[5].Trim();
                string phoneNumber = contactData[6].Trim();
                string email = contactData[7].Trim();

                return new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            }

            return null;
        }
    }

}
