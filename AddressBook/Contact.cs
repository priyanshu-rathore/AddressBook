using LINQtoCSV;
using System;

namespace AddressBook
{
    [Serializable]
    class Contacts
    {
        [CsvColumn(Name ="First Name",FieldIndex =1)]
        private string firstName;
        [CsvColumn(Name ="Last Name",FieldIndex =2)]
        private string lastName;
        [CsvColumn(Name ="Address",FieldIndex =3)]    
        private string address;
        [CsvColumn(Name = "City", FieldIndex = 4)]

        private string city;

        [CsvColumn(Name = "State", FieldIndex = 5)]

        private string state;

        [CsvColumn(Name = "Zip", FieldIndex = 6)]

        private string zip;

        [CsvColumn(Name ="Phone Number",FieldIndex =7)]
        private string phoneNumber;
        [CsvColumn(Name ="Email",FieldIndex =8)]
        private string email;

        public Contacts()
        {

        }

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
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