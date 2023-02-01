using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class JsonIO
    {
        static string _file = @"C:\Users\scorp\Desktop\AddressBook\AddressBook\FileIO\contacts.json";

        public static void JsonSerializer(List<Contacts> contacts)
        {
            if(!File.Exists(_file))
            {
                File.Create(_file);
            }

            string json = JsonConvert.SerializeObject(contacts);

            using (StreamWriter jsonWriter = File.AppendText(_file))
            {
                jsonWriter.WriteLine(json);
            }

        }

        public static void JsonDeserializer()
        {
            if(File.Exists(_file))
            {
                StreamReader jsonReader = new StreamReader(File.OpenRead(_file));

                string json = jsonReader.ReadToEnd();

                List<Contacts> contacts = JsonConvert.DeserializeObject<List<Contacts>>(json);

                foreach(var contact in contacts)
                {
                    Console.WriteLine($"FirstName : {contact.FirstName} | LastName : {contact.LastName} | Email : {contact.Email} | Number : {contact.PhoneNumber}");
                }
            }
        }
    }
}
