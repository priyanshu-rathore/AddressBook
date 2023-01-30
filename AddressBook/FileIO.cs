using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBook
{
    internal class FileIO
    {
        public string _file = @"C:/Users/scorp/Desktop/AddressBook/AddressBook/FileIO/contacts.txt";

        public void WriterContactsToFile(List<Contacts> contacts)
        {

            //FileStream file = new FileStream(_file, FileMode.Create);
            using (StreamWriter writer = File.AppendText(_file))
            {


                foreach (var contact in contacts)
                {

                    writer.WriteLine(contact.FirstName);
                    writer.WriteLine(contact.LastName);
                    writer.WriteLine(contact.Address);
                    writer.WriteLine(contact.City);
                    writer.WriteLine(contact.State);
                    writer.WriteLine(contact.Zip);
                    writer.WriteLine(contact.PhoneNumber);
                    writer.WriteLine(contact.Email);
                }
                writer.Close();

            }
        }

        public void ReadContactsFromFile() {
            StreamReader reader = new StreamReader(_file);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
