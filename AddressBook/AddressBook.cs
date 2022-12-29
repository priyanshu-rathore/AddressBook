using System;

namespace AddressBook
{
    class addressBook
    {
        private List<Contacts> contactList;

        public addressBook()
        {
            this.contactList = new List<Contacts>();
        }

        public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contacts newContact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            this.contactList.Add(newContact);

        }

        public void showList(){
            foreach(var contact in contactList){
                Console.WriteLine("FirstName: "+contact.FirstName);
                Console.WriteLine("LastName: "+contact.LastName);
                Console.WriteLine("Address: "+contact.Address);
                Console.WriteLine("City: "+contact.City);
                Console.WriteLine("State: "+contact.State);
                Console.WriteLine("ZipCode: "+contact.Zip);
                Console.WriteLine("Phone Number: "+contact.PhoneNumber);
                Console.WriteLine("Email: "+contact.Email);
                Console.WriteLine("-----------------");
            }
        }

    }
}
