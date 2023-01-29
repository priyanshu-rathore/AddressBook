using System;

namespace AddressBook
{
    class ContactBook
    {

        public static void addressBook()
        {
            System.Console.WriteLine("Welcome to Address Book");
            System.Console.WriteLine("_______________________");
            System.Console.WriteLine("");

            addressBook add = new addressBook();



            bool book = true;

            while (book == true)
            {
                System.Console.WriteLine("\n 1) Add Contact \n 2). Edit Contact \n 3). Show Contact \n 4). Delete Contact \n 5). Search Contact \n 6). Search Contact by City or State" );
                Console.WriteLine("7). Sort by Name \n 8.Sort by City \n 9). Sort by State \n 10. Sort by Zip)");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("Enter Address book details");

                        Contacts contacts = new Contacts();

                        System.Console.WriteLine("Enter First Name");
                        contacts.FirstName = Console.ReadLine();

                        System.Console.WriteLine("Enter Last Name");
                        contacts.LastName = Console.ReadLine();

                        System.Console.WriteLine("Enter Address");
                        contacts.Address = Console.ReadLine();

                        System.Console.WriteLine("Enter State");
                        contacts.State = Console.ReadLine();

                        System.Console.WriteLine("Enter city");
                        contacts.City = Console.ReadLine();

                        System.Console.WriteLine("Enter zip");
                        contacts.Zip = Console.ReadLine();

                        System.Console.WriteLine("Enter Phone Number");
                        contacts.PhoneNumber = Console.ReadLine();

                        System.Console.WriteLine("Enter Email");
                        contacts.Email = Console.ReadLine();


                        add.addContact(contacts.FirstName, contacts.LastName,contacts.Address, contacts.City, contacts.State, contacts.Zip, contacts.PhoneNumber, contacts.Email);

                        // add.showList();    
                        break;

                        case 2:
                        Console.WriteLine("Enter First Name of the Contact You Want to Edit.:");
                        string fName = Console.ReadLine();
                        add.editContact(fName);
                        break;
                        case 3:
                        add.showList();
                        break;
                        case 4:
                        System.Console.WriteLine("Enter First Name to Delete the contact you want");
                        string dName = Console.ReadLine();
                        add.deleteContact(dName);
                        break;
                    case 5:
                        Console.WriteLine("Search Contact");
                        Console.WriteLine("Enter First Name");
                        string first = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string last = Console.ReadLine();
                        Contacts cont = add.SearchContact(first, last);
                        add.showList(cont);
                        break;
                    case 6:
                        Console.WriteLine("Enter city or state");
                        string cityOrState = Console.ReadLine();
                        add.SearchByCityOrState(cityOrState);
                        break;
                    case 7:
                        add.SortName();
                        break;
                        case 8:
                            add.SortCity();
                        break;
                        case 9:
                        add.SortState();
                        break;
                    case 10:
                        add.SortZip();
                        break;
                        default:
                        book = false;
                        break;
                }

            }
        }
    }
}