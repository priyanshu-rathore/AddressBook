using System;

namespace AddressBook
{
    class Contacts
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        string zip;
        string phoneNumber;
        string  email;

        public Contacts(string firstName,string lastName,string address,string city,string state,string zip,string phoneNumber,string email){
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

    }
}