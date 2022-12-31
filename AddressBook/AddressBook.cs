using System;

namespace AddressBook
{
    class addressBook
    {
        public Dictionary<string, Contacts> contactList;

        public addressBook()
        {
            this.contactList = new Dictionary<string, Contacts>();
        }

        public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contacts newContact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            this.contactList.Add(firstName, newContact);

        }

        public void showList()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("FirstName: " + contact.Value.FirstName);
                Console.WriteLine("LastName: " + contact.Value.LastName);
                Console.WriteLine("Address: " + contact.Value.Address);
                Console.WriteLine("City: " + contact.Value.City);
                Console.WriteLine("State: " + contact.Value.State);
                Console.WriteLine("ZipCode: " + contact.Value.Zip);
                Console.WriteLine("Phone Number: " + contact.Value.PhoneNumber);
                Console.WriteLine("Email: " + contact.Value.Email);
                Console.WriteLine("-----------------");
            }
        }


        public void deleteContact(string fName)
        {


            foreach (var contact in contactList)
            {
                if (contact.Key == fName)
                {
                    contactList.Remove(contact.Key);
                    break;

                }
            }

        }

        public void editContact(string fName)
        {
            foreach (var contact in contactList)
            {
                if (contact.Key == fName)
                {
                    Console.WriteLine("Edit? Old FirstName: " + contact.Value.FirstName);
                    string newFirstName = Console.ReadLine();
                    Console.WriteLine("Edit? Old LastName: " + contact.Value.LastName);
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Edit? Old Address: " + contact.Value.Address);
                    string newAddress = Console.ReadLine();
                    Console.WriteLine("Edit? Old City: " + contact.Value.City);
                    string newCity = Console.ReadLine();
                    Console.WriteLine("Edit? Old State: " + contact.Value.State);
                    string newState = Console.ReadLine();
                    Console.WriteLine("Edit? Old ZipCode: " + contact.Value.Zip);
                    string newZip = Console.ReadLine();
                    Console.WriteLine("Edit? Old Phone Number: " + contact.Value.PhoneNumber);
                    string newPhoneNumber = Console.ReadLine();
                    Console.WriteLine("Edit? Old Email: " + contact.Value.Email);
                    string newEmail = Console.ReadLine();
                    Console.WriteLine("-----------------");

                    if (newFirstName != "")
                    {
                        contact.Value.FirstName = newFirstName;
                    }
                    if (newLastName != "")
                    {
                        contact.Value.LastName = newLastName;
                    }
                    if (newAddress != "")
                    {
                        contact.Value.Address = newAddress;
                    }
                    if (newCity != "")
                    {
                        contact.Value.City = newCity;
                    }
                    if (newState != "")
                    {
                        contact.Value.State = newState;
                    }
                    if (newZip != "")
                    {
                        contact.Value.Zip = newZip;
                    }
                    if (newPhoneNumber != "")
                    {
                        contact.Value.PhoneNumber = newPhoneNumber;
                    }
                    if (newEmail != "")
                    {
                        contact.Value.Email = newEmail;
                    }
                }
            }
        }

    }
}
