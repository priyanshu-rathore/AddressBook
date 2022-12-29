using System;

namespace AddressBook
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("State:");
            string state = Console.ReadLine();
            Console.WriteLine("Zip Code:");
            string zip = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Email Address:");
            string email = Console.ReadLine();

            System.Console.WriteLine("");


            System.Console.WriteLine("Welcome to Address Book Program");
            addressBook contactOperation = new addressBook();
            contactOperation.addContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            contactOperation.showList();
        }
    }
}