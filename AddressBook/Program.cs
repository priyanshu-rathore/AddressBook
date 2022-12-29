using System;

namespace AddressBook
{
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Welcome to Address Book Program");
            addressBook contactOperation = new addressBook();
            contactOperation.addContact("Priyanshu", "Rathore", "addrezzz", "cityx", "statez", "766452", "8756473625", "priyanshu@gmail.com");
            contactOperation.showList();
        }
    }
}