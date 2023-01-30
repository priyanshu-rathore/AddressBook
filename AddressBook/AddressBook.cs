using System;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;

namespace AddressBook
{
    class addressBook
    {
        public Dictionary<string, Contacts> contactList;//UC
        public List<Contacts> contacts = new List<Contacts>();

        public addressBook()
        {
            this.contactList = new Dictionary<string, Contacts>();
            
        }

        public void SortName()//UC11
        {
            SortByName sortByName= new SortByName();

            contacts.Sort(sortByName);
        }
    
        public void SortCity()//UC12
        {
            SortByCity sortByCity = new SortByCity();
            contacts.Sort(sortByCity);
        }

        public void SortState()//UC12
        {
            SortByState sortByState = new SortByState();
            contacts.Sort(sortByState);
        }

        public void SortZip()//UC12
        {
            SortByZip sortByZip = new SortByZip();
            contacts.Sort(sortByZip);
        }
     
   

        public override string ToString()
        {
            try {
                foreach (var contact in contacts)
                {
                    return "First Name " + contact.FirstName + "\nLast Name "+ contact.LastName   ;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            return default;
           
        }



        public void SearchByCityOrState(string cityOrState)//UC8
        {
            List<Contacts> searchResults = new List<Contacts>();
            foreach (var addressBook in contactList)
            {
                if (addressBook.Value.City == cityOrState || addressBook.Value.State == cityOrState)
                {
                    searchResults.Add(addressBook.Value);
                }
            }

            if (searchResults.Count() > 0)
            {
                Console.WriteLine("Search Results:");
                foreach (var result in searchResults)
                {
                    Console.WriteLine(result.FirstName + " " + result.LastName + " - " + result.City + " , " + result.State);
                }

                Console.WriteLine(searchResults.Count + "Person contacts present");//UC10
            }
            else
            {
                Console.WriteLine("No results found.");
            }

        }

            public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contacts newContact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);


            if (contactList.Count > 0)
            {
                foreach (var contact in contactList)
                {
                    if (contact.Value.FirstName.Equals(newContact.FirstName))
                    {
                        Console.WriteLine("Duplicate Entry");
                        break;
                    }
                    else
                    {
                        this.contactList.Add(firstName, newContact);
                        contacts.Add(newContact);
                        break;
                    }

                }
            }
            else
            {
                this.contactList.Add(firstName, newContact);
                this.contacts.Add(newContact);
                
            }


        }

        public void showList()
        {
            foreach (var contact in contacts)
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

        internal Contacts SearchContact(string? first, string? last)
        {
            foreach(var contact in contactList)
            {
                if(contact.Value.FirstName==first && contact.Value.LastName == last)
                {
                    Console.WriteLine($"Full Name : {contact.Value.FirstName} {contact.Value.LastName} city : {contact.Value.City} phone : {contact.Value.PhoneNumber}");
                    return contact.Value;
                }

            }

            return default;
        }

        internal void showList(Contacts contact)
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

        private class SortByName : IComparer<Contacts>//UC11
        {
            public int Compare(Contacts x, Contacts y)
            {
                return string.Compare(x.FirstName, y.FirstName);
            }
        }

        private class SortByCity : IComparer<Contacts>//UC12
        {
            public int Compare(Contacts x,Contacts y)
            {
                return string.Compare(x.City, y.City);
            }
        }

        private class SortByState : IComparer<Contacts> {
            public int Compare(Contacts x, Contacts y)
            {
                return string.Compare(x.State, y.State);
            }
        }

        private class SortByZip : IComparer<Contacts> 
        {
            public int Compare(Contacts x, Contacts y)
            {
                return string.Compare(x.Zip, y.Zip);
            }
        }
    }
}
