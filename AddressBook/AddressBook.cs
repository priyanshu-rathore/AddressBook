using System;

namespace AddressBook
{
    class addressBook
    {
        public List<Contacts> contactList;

        public addressBook()
        {
            this.contactList = new List<Contacts>();
        }

        public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contacts newContact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            this.contactList.Add(newContact);

        }

        public Contacts SearchContact(string firstName, string lastName)
        {
            return contactList.Find(contact => contact.FirstName.Equals(firstName, StringComparison.InvariantCultureIgnoreCase) &&
                                           contact.LastName.Equals(lastName, StringComparison.InvariantCultureIgnoreCase));
        }

        public void showList()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("FirstName: " + contact.FirstName);
                Console.WriteLine("LastName: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("ZipCode: " + contact.Zip);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);
                Console.WriteLine("-----------------");
            }
        }

        public void showList(Contacts contact)
        {
            Console.WriteLine("FirstName: " + contact.FirstName);
            Console.WriteLine("LastName: " + contact.LastName);
            Console.WriteLine("Address: " + contact.Address);
            Console.WriteLine("City: " + contact.City);
            Console.WriteLine("State: " + contact.State);
            Console.WriteLine("ZipCode: " + contact.Zip);
            Console.WriteLine("Phone Number: " + contact.PhoneNumber);
            Console.WriteLine("Email: " + contact.Email);
            Console.WriteLine("-----------------");
        }


        public void deleteContact(string fName)
        {


            foreach (var contact in contactList)
            {
                if (contact.FirstName == fName)
                {
                    contactList.Remove(contact);
                    break;

                }
            }

        }

        public void editContact(string fName)
        {
            foreach (var contact in contactList)
            {
                if (contact.FirstName == fName)
                {
                    Console.WriteLine("Edit? Old FirstName: " + contact.FirstName);
                    string newFirstName = Console.ReadLine();
                    Console.WriteLine("Edit? Old LastName: " + contact.LastName);
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Edit? Old Address: " + contact.Address);
                    string newAddress = Console.ReadLine();
                    Console.WriteLine("Edit? Old City: " + contact.City);
                    string newCity = Console.ReadLine();
                    Console.WriteLine("Edit? Old State: " + contact.State);
                    string newState = Console.ReadLine();
                    Console.WriteLine("Edit? Old ZipCode: " + contact.Zip);
                    string newZip = Console.ReadLine();
                    Console.WriteLine("Edit? Old Phone Number: " + contact.PhoneNumber);
                    string newPhoneNumber = Console.ReadLine();
                    Console.WriteLine("Edit? Old Email: " + contact.Email);
                    string newEmail = Console.ReadLine();
                    Console.WriteLine("-----------------");

                    if (newFirstName != "")
                    {
                        contact.FirstName = newFirstName;
                    }
                    if (newLastName != "")
                    {
                        contact.LastName = newLastName;
                    }
                    if (newAddress != "")
                    {
                        contact.Address = newAddress;
                    }
                    if (newCity != "")
                    {
                        contact.City = newCity;
                    }
                    if (newState != "")
                    {
                        contact.State = newState;
                    }
                    if (newZip != "")
                    {
                        contact.Zip = newZip;
                    }
                    if (newPhoneNumber != "")
                    {
                        contact.PhoneNumber = newPhoneNumber;
                    }
                    if (newEmail != "")
                    {
                        contact.Email = newEmail;
                    }
                }
            }
        }

    }
}
